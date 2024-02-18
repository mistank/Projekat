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
    public class DeleteReservationController
    {
        private static DeleteReservationController instance;
        public static DeleteReservationController Instance { get { if (instance == null) { instance = new DeleteReservationController(); } return instance; } }

        public void Delete(Reservation reservation)
        {
            Response res = Communication.Instance.Delete(reservation);
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
                MessageBox.Show($"Reservation {reservation} succesfully deleted!");
            }
        }
    }
}
