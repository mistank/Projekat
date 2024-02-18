using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using System.IO;

namespace Client
{
    public class Communication
    {
        Socket socket;
        Sender sender;
        Receiver receiver;
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }
        public Response Login(User user)
        {
            Request req = new Request
            {
                Argument = user,
                Operation = Operation.Login
            };
            Response res = new Response();
            try
            {
                sender.Send(req);
                res = (Response)receiver.Receive();
            }
            catch (Exception ex)
            {
                res.Exception = ex;
            }
            return res;
        }
        public Response Search(SearchValue searchValue)
        {
            Request req = new Request()
            {
                Operation = Operation.Search,
                Argument = searchValue
            };
            Response res = new Response();
            try
            {
                sender.Send(req);
                res = (Response)receiver.Receive();
            }
            catch (Exception ex)
            {
                res.Exception = ex;
            }
            return res;
        }
        internal Response Edit(EditValue editValue)
        {
            Request req = new Request()
            {
                Operation = Operation.Edit,
                Argument = editValue
            };
            Response res = new Response();
            try
            {
                sender.Send(req);
                res = (Response)receiver.Receive();
            }
            catch (Exception ex)
            {
                res.Exception = ex;
            }
            return res;
        }
        internal Response Add(object parameter)
        {
            Request req = new Request()
            {
                Operation = Operation.Add,
                Argument = parameter
            };
            Response res = new Response();
            try
            {
                sender.Send(req);
                res = (Response)receiver.Receive();
            }
            catch (Exception ex)
            {
                res.Exception = ex;
            }
            return res;
        }
        internal Response Logout(User user)
        {
            Request req = new Request()
            {
                Operation = Operation.Logout,
                Argument = user
            };
            Response res = new Response();
            try
            {
                sender.Send(req);
                res = (Response)receiver.Receive();
            }
            catch (Exception ex)
            {
                res.Exception = ex;
            }
            return res;
        }

        internal Response Delete(object parameter)
        {
            Request req = new Request()
            {
                Operation = Operation.Delete,
                Argument = parameter
            };
            Response res = new Response();
            try
            {
                sender.Send(req);
                res = (Response)receiver.Receive();
            }
            catch (Exception ex)
            {
                res.Exception = ex;
            }
            return res;
        }
    }
}
