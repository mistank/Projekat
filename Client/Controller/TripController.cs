using Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    public class TripController
    {
        private static TripController instance;
        public static TripController Instance { get { if (instance == null) { instance = new TripController(); } return instance; } }
        //public void ShowMenu(object sender, EventArgs e)
        //{
        //    /*ista logika kao u main kontroleru  samo sto se ovde vrsi filtracija pa se u glavni
        //     kontroler salje vec odabrana user controla u metodu koja samo postavlja odg user 
        //    kontrolu na panel*/

        //    UserControl userControl = null;
        //    string buttonName = ((Button)sender).Name.ToLower();
        //    string menuName = buttonName.Remove(buttonName.IndexOf("btn"), 3);
        //    switch (menuName)
        //    {
        //        case "add":
        //            userControl = new UCAddTrip();
        //            break;
        //        case "search":
        //            userControl = new UCSearchTrip();
        //            break;
        //        default:
        //            break;
        //    }
        //    MainController.Instance.ShowMenu(userControl);
        //}
    }
}
