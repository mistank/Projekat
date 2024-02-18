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
    public class AddPassengerController
    {
        private static AddPassengerController instance;
        private UCAddPassenger addPassenger;
        public UCAddPassenger AddPassengerForm { get{ return addPassenger; } set { addPassenger = value; } }
        public static AddPassengerController Instance { get { if (instance == null) { instance = new AddPassengerController(); } return instance; } }
        public void AddPassenger(Passenger passenger)
        {
            
            Response res = Communication.Instance.Add(passenger);
            if (res.Exception != null)
            {
                Debug.WriteLine(res.Exception.Message);
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
            }
            else if (res.Result != null)
            {
                MessageBox.Show($"Passenger {passenger} succesfully added!");
            }
            else
            {
                MessageBox.Show("Passenger already exists", "Adding passenger unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
