using Common.Domain;
using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;
using Client.UserControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Reflection;

namespace Client
{
    public class MainController
    {
        private static MainController instance;
        public FrmMain frmMain;
        public static MainController Instance { get { if (instance == null) { instance = new MainController(); } return instance; } }
        public void ShowFrmMain(User loggedUser)
        {
            frmMain = new FrmMain(loggedUser);
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
        }
        public void ShowFrmMainForEdit()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
        }
        public void Logout(object sender, EventArgs e)
        {
            LogoutController.Instance.Logout();
        }
        internal void ShowMenu(object sender, EventArgs e)
        {
            /*uzimamo naziv dugmeta koje je okinulo eventHandler i preko njegovog naziva vidimo
            koji meni treba da pozovemo. Npr dugme se zove tripBtn, pa znamo da treba da pozovemo 
            trip meni. Pretvorimo "trip" u "Trip" i dodamo na pocetku "UC" a na kraju "Menu" jer sam po tom obrascu nazivao User Controle.
            Na kraju samo instanciramo objekat preko stringa koji sadrzi ime klase ("UCPassengerMenu").
            Tako izbegavamo zasebne event handlere za svaku klasu.
            */
            string buttonName = ((Control)sender).Name;
            string menuName = buttonName.Remove(buttonName.IndexOf("Btn"), 3);
            menuName = string.Concat(menuName[0].ToString().ToUpper(), menuName.Substring(1));
            menuName = "UC" + menuName;
            //mora se kao ime klase dati puno ime. "UCPassengerMenu" nece raditi, nego moramo staviti "Client.UserControls.UCPassengerMenu"
            Console.WriteLine(typeof(UCSearchTrip));
            Type className = Type.GetType("Client.UserControls." + menuName);
            ConstructorInfo constructor = className.GetConstructor(Type.EmptyTypes);
            UserControl userControl = (UserControl)constructor.Invoke(null);
            frmMain.MainPnl.Controls.Clear();
            frmMain.MainPnl.Controls.Add(userControl);
        }
        //metoda koja vec prima filtriranu user kontrolu koju smo filtrirali u passenger kontroleru
        internal void ShowMenu(UserControl userControl)
        {
            frmMain.MainPnl.Controls.Clear();
            frmMain.MainPnl.Controls.Add(userControl);
        }
    }
}
