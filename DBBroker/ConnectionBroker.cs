using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class ConnectionBroker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public ConnectionBroker()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["projekat_baza"].ConnectionString);
            //connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekatBaza;Integrated Security=True;");
        }
        public void OpenConnection()
        {
            Console.WriteLine("Pokusaj otvaranja konekcije");
            connection?.Open();
            Console.WriteLine("Usepsno otvaranje konekcije");
        }
        public void CloseConnection()
        {
            connection?.Close();
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection,transaction);
        }
    }
}
