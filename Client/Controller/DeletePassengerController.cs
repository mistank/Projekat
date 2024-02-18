using Client.UserControls;
using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    internal class DeletePassengerController
    {
        private static DeletePassengerController instance;
        public static DeletePassengerController Instance { get { if (instance == null) { instance = new DeletePassengerController(); } return instance; } }
        
        public void Delete(Passenger passenger)
        {
            Response res = Communication.Instance.Delete(passenger);
            if (res.Exception != null)
            {
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed");
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
                MessageBox.Show(res.Exception.Message);
            }
            else if (res.Result == null)
            {
                MessageBox.Show($"Passenger {passenger} succesfully deleted!");
            }
        }
    }
}
