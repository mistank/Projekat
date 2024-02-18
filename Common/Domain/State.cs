using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class State:IEntity
    {
        public int Id { get; set; }
        public string StateName { get; set; }

        public string TableName => "State";

        public string Values => StateName != null ? $"{StateName}" : null;

        public override string ToString()
        {
            return StateName;
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
