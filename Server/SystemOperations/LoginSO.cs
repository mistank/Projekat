using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class LoginSO : SOBase
    {
        private readonly User user;
        public LoginSO(User user)
        {
            this.user = user;
        }
        protected override void ExecuteConcreteOperation(object parameter = null)
        {
            Result = broker.Login(user);
        }
    }
}
