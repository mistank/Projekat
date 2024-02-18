using Common.Domain;
using DBBroker;
using Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        private List<User> activeUsers;
        public List<User> ActiveUsers { get { return activeUsers; } set { activeUsers = value; } }
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() {
        activeUsers = new List<User>();
        }
        private Boolean UserLoggedIn(User user)
        {
            foreach (var loggedUser in ActiveUsers)
            {
                if (loggedUser.Username == user.Username && loggedUser.Password==user.Password) return true;
            }
            return false;
        }
        private object LogoutUser(User user)
        {
            foreach (var loggedUser in ActiveUsers)
            {
                if (loggedUser.Username == user.Username && loggedUser.Password == user.Password)
                {
                    ActiveUsers.Remove(loggedUser);
                    break;
                }
                
            }
            return null;
        }
        public object Logout(User user)
        {
            LogoutUser(user);
            return null;
        }
        public object Login(User user)
        {
            if (!UserLoggedIn(user))
            {
                LoginSO login = new LoginSO(user);
                login.ExecuteTemplate();
                User logResult = (User)login.Result;
                if (logResult == null) return new Exception("Incorrect username or password.");
                else ActiveUsers.Add(logResult);
                return (User)login.Result;
            }
            else
            {
                return new Exception("User is already logged in.");
            }
            
        }
        public object Add(object parameter)
        {
            string SOName = "Add" + parameter.GetType().Name + "SO";
            Type sysOPType = Type.GetType("Server.SystemOperations." + SOName);
            ConstructorInfo constructor = sysOPType.GetConstructor(Type.EmptyTypes);
            SOBase addSO = (SOBase)constructor.Invoke(null);
            addSO.ExecuteTemplate(parameter);
            return addSO.Result;
        }
        public object Search(SearchValue searchValue)
        {
            string SOName = "Search" + searchValue.Type.Name + "SO";
            Type sysOPType = Type.GetType("Server.SystemOperations." + SOName);
            ConstructorInfo constructor = sysOPType.GetConstructor(Type.EmptyTypes);
            SOBase searchSO = (SOBase)constructor.Invoke(null);    
            searchSO.ExecuteTemplate(searchValue);

            //Cilj metode za pretragu nam je da vrati listu objekata, ali psoto se moze desiti da 
            //vrati samo jedan objekat, to ovde proveravamo i pretvaramo u listu objekata ako ima potrebe
            if (searchSO.Result.GetType().IsGenericType && searchSO.Result.GetType().GetGenericTypeDefinition() == typeof(List<>))
            {
                return searchSO.Result;
            }
            else
            {
                var list = new List<object>() { searchSO.Result };
                searchSO.Result = list;
                return searchSO.Result;
            }
        }
        public object Edit(EditValue editValue)
        {
            string SOName = "Edit" + editValue.Type.Name + "SO";
            Type sysOPType = Type.GetType("Server.SystemOperations." + SOName);
            ConstructorInfo constructor = sysOPType.GetConstructor(Type.EmptyTypes);
            SOBase editSO = (SOBase)constructor.Invoke(null);
            editSO.ExecuteTemplate(editValue);
            return editSO.Result;
        }
        public void RemoveClients()
        {
            activeUsers.Clear();
        }
        public object Delete(IEntity parameter)
        {
            string SOName = "Delete" + parameter.GetType().Name + "SO";
            Type sysOPType = Type.GetType("Server.SystemOperations." + SOName);
            ConstructorInfo constructor = sysOPType.GetConstructor(Type.EmptyTypes);
            SOBase editSO = (SOBase)constructor.Invoke(null);
            editSO.ExecuteTemplate(parameter);
            return editSO.Result;
        }
    }
}
