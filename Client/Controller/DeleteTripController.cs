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
    internal class DeleteTripController
    {
        private static DeleteTripController instance;
        public static DeleteTripController Instance { get { if (instance == null) { instance = new DeleteTripController(); } return instance; } }

        public void Delete(Trip trip)
        {
            Response res = Communication.Instance.Delete(trip);
            if (res.Exception != null)
            {
                MessageBox.Show(res.Exception.Message);
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed");
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
            }
            else if (res.Result == null)
            {
                MessageBox.Show($"Trip {trip} succesfully deleted!");
            }
        }
    }
}

