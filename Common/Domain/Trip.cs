using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Trip:IEntity
    {
        public int Id { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Price {  get; set; }
        public Destination Destination { get; set; }
        public string TableName => "Trip";
        public string Values => $"'{string.Format("{0:yyyy-MM-dd}", DepartureDate)}','{string.Format("{0:yyyy-MM-dd}", ArrivalDate)}',{Price},{Destination.Id}";

        public override string ToString()
        {
            return $"{Destination}, {DepartureDate} - {ArrivalDate}";
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
