using Common;
using Common.Domain;
using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace DBBroker
{
    public class Broker
    {
        private ConnectionBroker connection;
        public Broker()
        {
            connection = new ConnectionBroker();
        }
        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }
        public void Commit()
        {
            connection.Commit();
        }
        public void Rollback()
        {
            connection.Rollback();
        }
        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }
        public User Login(User user)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [user] where Username COLLATE Latin1_General_CS_AS = '{user.Username}' and password COLLATE Latin1_General_CS_AS = '{user.Password}'";
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    user.LastName = (string)reader["LastName"];
                    user.FirstName = (string)reader["FirstName"];
                    user.Id = (int)reader["Id"];
                    return user;
                }
            }
            finally
            {
                reader.Close();
            }
            return null;
        }
        public object Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            List<string> propertyNames = obj.GetType().GetProperties().Select(prop => prop.Name).Where(prop => prop != "TableName" && prop != "Values" && prop != "Id").ToList();
            string sourceQuery;
            string values;
            string onQuery;
            //ako se radi o putniku, posto on jedini svoj PK unosi iz aplikacije
            //mana ovog pristupa je sto ako zelimo da dodamo jos neki objekat u bazu ciji se PK unosi iz aplikacije, moracemo ovde da dodamo uslov u contains,tkd ovo nije dobro resenje
            if (propertyNames.Contains("JMBG"))
            {
                sourceQuery = "JMBG";
                values = $"'{((Passenger)obj).JMBG}'";
                onQuery = $"target.JMBG = source.JMBG";
            }
            //ostali objekti
            else
            {
                sourceQuery = string.Join(",", propertyNames);
                values = obj.Values;
                onQuery = string.Join(" ", propertyNames.Select(key => $"target.{key} = source.{key} and").ToList());
                onQuery = onQuery.Remove(onQuery.LastIndexOf("and"), 3);
            }
            cmd.CommandText = $"MERGE INTO {obj.TableName} AS target USING (VALUES ({values})) AS source ({sourceQuery})" +
                $" ON {onQuery} WHEN NOT MATCHED THEN INSERT ({string.Join(",", propertyNames)}) VALUES ({obj.Values});";
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return rowsAffected == 1 ? obj : null;
        }
        public object Search(SearchValue searchValue)
        {
            string searchQuery;
            //pravi se konstruktor klase(tabele) u kojoj pretrazujemo, npr passenger
            ConstructorInfo constructor = searchValue.Type.GetConstructor(Type.EmptyTypes);
            //inicijalizacija objekta te klase 
            IEntity obj = (IEntity)constructor.Invoke(null);
            //nazivi kolona u tabeli   
            List<string> propertyNames = obj.GetType().GetProperties().Select(prop => prop.Name).Where(prop => prop != "TableName" && prop != "Values").ToList();
            //lsita objekata u koju smestamo vrednosti izvucene iz tabele
            List<object> objects = new List<object>();
            SqlCommand cmd = connection.CreateCommand();

            //kada se forma ucita prvi put prikazace se svi objekti u bazi, odnosno nema where query-ja
            if (searchValue.Value.GetType() == typeof(string))
            {
                if (string.IsNullOrEmpty((string)searchValue.Value)) searchQuery = string.Empty;
                else searchQuery = $"where {searchValue.Parameter} like '{searchValue.Value}%' ";
            }
            else searchQuery = $"where cast({searchValue.Parameter} as varchar) like '{searchValue.Value}%' ";

            cmd.CommandText = $"select * from {obj.TableName} " + $"{searchQuery}";
            Console.WriteLine(cmd.CommandText);
            SqlDataReader reader = cmd.ExecuteReader();

            //ucitan red iz tabele
            while (reader.Read())
            {
                obj = (IEntity)constructor.Invoke(null);
                //za svaku kolonu iz liste kolona te tabele postavi vrednost u property tog objekta
                foreach (string column in propertyNames)
                {
                    //property objekta u koji zelimo da upisemo odg vrednost dobijamo ovako
                    PropertyInfo property = obj.GetType().GetProperty(column);

                    Type interfaceType = typeof(IEntity);

                    /*Ako naidjemo na spoljni kljuc odnosno ako je naziv kolone ujedno i naziv domenske klase(to cemo znati ako nasledjuje IEntity),
                      ne mozemo u njega da ubacimo int vrednost nego moramo da napravimo objekat te klase
                      i da iz njegove tabele izvucemo objekat sa odg ID-jem */
                    if (property.PropertyType.GetInterfaces().Contains(interfaceType))
                    {
                        ConstructorInfo innerConstructor = property.PropertyType.GetConstructor(Type.EmptyTypes);
                        object innerObj = innerConstructor.Invoke(null);
                        List<string> innerObjColumns = innerObj.GetType().GetProperties().Select(prop => prop.Name).Where(prop => prop != "TableName" && prop != "Values").ToList();
                        SearchValue innerSearchValue = new SearchValue()
                        {
                            Type = property.PropertyType,
                            Parameter = property.PropertyType == typeof(Passenger) ? "JMBG" : "Id",
                            Value = reader[column],
                        };
                        innerObj = Search(innerSearchValue);
                        property.SetValue(obj, innerObj);
                    }
                    else
                    {
                        object value = reader[column];
                        Type valueType = property.PropertyType;
                        if (valueType.IsEnum) value = Enum.Parse(valueType, (string)value);
                        property.SetValue(obj, value);
                    }
                }
                objects.Add(obj);
            }
            reader.Close();
            return objects.Count == 1 ? objects[0] : objects;
        }
        //ako ne primi ime tabele vraca sve primarne kljuceve koji postoje u bazi podataka, u suprotnom vraca sve PK u datoj tabeli
        private List<string> GetAllPrimaryKeys(string tableName = "")
        {
            string tableQuery = string.IsNullOrEmpty(tableName) ? "" : $"and table_name = '{tableName}'";
            List<string> primaryKeys = new List<string>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + CONSTRAINT_NAME), 'IsPrimaryKey') = 1 {tableQuery};";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                primaryKeys.Add(reader[0].ToString());
            }
            return primaryKeys;
        }
        public string getUpdateQuery(EditValue editValue)
        {
            string setQuery = "set ";
            List<PropertyInfo> properties = editValue.Type.GetProperties().Where(prop => prop.Name != "TableName" && prop.Name != "Values").ToList();
            List<string> primaryKeys = GetAllPrimaryKeys(editValue.Type.Name);
            foreach (var property in properties)
            {
                if (primaryKeys.Contains(property.Name)) continue;
                object setValue = property.GetValue(editValue.EditedValue);
                //ako je property slozen, odnosno predstavlja domensku klasu
                if (property.PropertyType.GetInterfaces().ToList().Contains(typeof(IEntity)))
                {
                    string innerPrimaryKey = GetAllPrimaryKeys(property.PropertyType.Name)[0];
                    PropertyInfo innerProperty = property.PropertyType.GetProperty(innerPrimaryKey);
                    setValue = innerProperty.GetValue(setValue);
                }
                //ako je datum pretvori ga u string odg formata koji sql prepoznaje
                if (setValue.GetType() == typeof(DateTime)) setValue = String.Format("{0:yyyy-MM-dd}", setValue);
                //ako je setValue string samo mu dodaj navodnike da bi ga sql prepoznao kao string
                if (setValue.GetType().IsEnum) setValue = setValue.ToString();
                setValue = setValue.GetType() == typeof(string) ? $" '{setValue}' " : setValue;
                setQuery += $"{property.Name} = {setValue},";
            }
            setQuery = setQuery.TrimEnd(',');
            string whereQuery = "where ";
            foreach (var primaryKey in primaryKeys)
            {
                PropertyInfo idProperty = editValue.Type.GetProperty(primaryKey);
                var primaryKeyValue = idProperty.GetValue(editValue.OriginalValue);
                primaryKeyValue = primaryKeyValue.GetType() == typeof(string) ? $" '{primaryKeyValue}' " : primaryKeyValue;
                whereQuery += $"{primaryKey} = {primaryKeyValue} and";
            }
            whereQuery = whereQuery.Remove(whereQuery.LastIndexOf("and"), 3);

            return $"update {editValue.Type.Name} {setQuery} {whereQuery}";
        }
        public object Edit(EditValue editValue)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = getUpdateQuery(editValue);
            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();

            return null;
        }
        private string GetDeleteQuery(IEntity parameter)
        {
            string tableName = parameter.TableName;
            string deleteQuery = $"delete from {tableName} ";
            string whereQuery = $"where ";


            foreach (string pk in GetAllPrimaryKeys(tableName))
            {
                Type tableType = parameter.GetType();
                PropertyInfo pkProperty = tableType.GetProperty(pk);
                dynamic pkValue = pkProperty.GetValue(parameter);
                if (pkValue.GetType() == typeof(string)) pkValue = $"'{pkValue}'";
                whereQuery += $"{pk} = {pkValue} and ";
            }
            whereQuery = whereQuery.Remove(whereQuery.LastIndexOf("and"), 3);
            return deleteQuery + whereQuery;
        }
        public object Delete(IEntity parameter)
        {
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = GetDeleteQuery(parameter);

                cmd.ExecuteNonQuery();

                return null;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    int start = ex.Message.IndexOf("dbo.", StringComparison.OrdinalIgnoreCase) + 4;
                    int end = ex.Message.IndexOf('"', start);
                    string errorTableName = ex.Message.Substring(start, end - start);
                    return new Exception($"The object that you are trying to delete appears in a {errorTableName.ToLower()}.");
                }
            }
            return null;
        }
    }
}
