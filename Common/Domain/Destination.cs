using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Destination : IEntity
    {
        public int Id { get; set; }
        public string DestinationName { get; set; }
        public State State { get; set; }

        public string TableName => "Destination";

        public string Values => DestinationName != null && State != null ? $"{DestinationName},{State.StateName}" : null;

        public override string ToString()
        {
            return DestinationName + ", " + State;
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
