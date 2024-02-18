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
    public class EditPassengerController
    {
        private static EditPassengerController instance;
        public static EditPassengerController Instance { get { if (instance == null) { instance = new EditPassengerController(); } return instance; } }

        public object EditPassenger(EditValue editValue)
        {
            Response res = Communication.Instance.Edit(editValue);
            if (res.Exception == null)
            {
                return res.Result;
            }
            else
            {
                Debug.WriteLine(res.Exception);
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed");
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
                return null;
            }
        }
    }
}
