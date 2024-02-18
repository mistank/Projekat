using Common;
using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;
        public string Username { get; set; }
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }
        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    Response r = ProcessRequest(req);
                    sender.Send(r);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private Response ProcessRequest(Request req)
        {
            /*uradjeno preko refleksije. methodName je ime metode koje dobijamo iz enuma koji posaljemo, zatim tu metodu pronadjemo u klasi Controller i 
             preko method.Invoke izvrsavamo tu metodu u objektu koji zelimo sa argumentima koje saljemo preko niza objekata arguments.
            Ovime se izbegava potreba za switch(req.Operation). Napomena: Metode u Controller-u se moraju nazivati isto kao nazivi enuma, da bi refleksija bila moguca.*/
            Response r = new Response();
            object[] arguments = null;
            string methodName = Enum.GetName(typeof(Operation), req.Operation);
            MethodInfo method = typeof(Controller).GetMethod(methodName);
            ParameterInfo[] parameters = method.GetParameters();
            if(parameters.Length!=0) arguments = new object[1] { req.Argument };
            object returnValue = method.Invoke(Controller.Instance, arguments);
            if (returnValue!=null && returnValue.GetType() == typeof(Exception)) r.Exception = (Exception)returnValue;
            else r.Result = returnValue;
            return r;
        }
    
        public void CloseConnection()
        {
            socket.Close();
        }
    }
}
