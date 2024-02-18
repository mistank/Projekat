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
               
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed", "Searching trip unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainController.Instance.frmMain.Dispose();
                    LoginController.Instance.frmLogin.Dispose();
                }
                else
                {
                    MessageBox.Show(res.Exception.Message, "Searching tri unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }
        }
    }
}
