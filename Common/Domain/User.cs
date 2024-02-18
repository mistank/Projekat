using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{

    [Serializable]
    public class User: IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        string IEntity.TableName => $"User";

        string IEntity.Values => $"{Username},{Password},{FirstName},{LastName}";

        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }

}
