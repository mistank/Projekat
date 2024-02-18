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
    public class SearchPassengerController
    {
        private static SearchPassengerController instance;
        public FrmMain FrmMain { get; set; }
        public FrmLogin FrmLogin { get; set; }
        public static SearchPassengerController Instance { get { if (instance == null) { instance = new SearchPassengerController(); } return instance; } }

        public object Search(SearchValue searchValue)
        {
            Response res = Communication.Instance.Search(searchValue);
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
