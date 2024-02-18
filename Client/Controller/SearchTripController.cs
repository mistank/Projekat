using Client.UserControls;
using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Client.Controller
{
    public class SearchTripController
    {
        private static SearchTripController instance;
        public SearchTripController SearchTripForm { get; set; }
        public static SearchTripController Instance { get { if (instance == null) { instance =  new SearchTripController(); } return instance; } }
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
