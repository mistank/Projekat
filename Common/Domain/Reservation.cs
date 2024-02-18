using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatus Status { get; set; }
        public Passenger Passenger { get; set; }
        public Trip Trip { get; set; }

        public string TableName => "Reservation";

        //Moguca greska ako ne posalje enum status kao string!!
        public string Values =>ReservationDate!=null &&
            Passenger!=null && Trip!=null ?  $"'{string.Format("{0:yyyy-MM-dd}", ReservationDate)}','{Status}','{Passenger.JMBG}',{Trip.Id}" : null;
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
