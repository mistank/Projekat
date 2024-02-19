using Client.UserControls;
using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Client.Controller
{
    public class AddTripController
    {
        private static AddTripController instance;
        public UCAddTrip AddTripForm { get; set; }
        public static AddTripController Instance { get { if (instance == null) { instance = new AddTripController(); } return instance; } }

        internal void AddTrip(Trip trip)
        {
            Response res = Communication.Instance.Add(trip);
            if (res.Exception != null)
            {
                Debug.WriteLine(res.Exception.Message);
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed", "Adding trip unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
            }
            else if (res.Result != null)
            {
                MessageBox.Show($"Trip {trip} successfuly added!","Trip successfully added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Trip already exists", "Adding trip unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
