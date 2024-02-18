using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    internal class LogoutController
    {
        private static LogoutController instance;
        public FrmLogin frmLogin;
        public User User {  get; set; }
        public static LogoutController Instance { get { if (instance == null) { instance = new LogoutController(); } return instance; } }
        public void Logout()
        {
            Console.WriteLine("Izlogovacu usera " + User.FirstName);
            Response res = Communication.Instance.Logout(User);
            if (res.Exception == null)
            {
                frmLogin.Visible = true;
            }
            else
            {
                MessageBox.Show(res.Exception.Message);
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed");
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
            }
        }
    }
}
