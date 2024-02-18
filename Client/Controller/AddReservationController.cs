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
    public class AddReservationController
    {
        private static AddReservationController instance;
        public static AddReservationController Instance { get { if (instance == null) { instance = new AddReservationController(); } return instance; } }
        public void AddReservation(Reservation reservation)
        {
            Response res = Communication.Instance.Add(reservation);
            if (res.Exception != null)
            {
                Debug.WriteLine(res.Exception.Message);
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed");
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
            }
            else if (res.Result != null)
            {
                MessageBox.Show("Reservation succesfully added!", "Reservation succesfully added!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reservation already exists", "Reservation cannot be added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
