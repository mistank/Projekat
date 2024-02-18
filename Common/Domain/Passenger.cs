using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Passenger: IEntity
    {
        public Passenger(string firstName,string lastName,string jmbg, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            JMBG = jmbg;
            Phone = phone;
        }
        public Passenger()
        {
            
        }
        public string JMBG { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public string Phone {  get; set; }
        public string TableName => "Passenger";
        public string Values => $"'{JMBG}','{FirstName}','{LastName}','{Phone}'";
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
