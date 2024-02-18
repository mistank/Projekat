using Client;
using Client.Controller;
using Client.UserControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCPassengerMenu : UserControl
    {
        public UCPassengerMenu()
        {
            InitializeComponent();
        }
        public void subMenuBtnClick(object sender, EventArgs e)
        {
            MainController.Instance.ShowMenu(sender, e);
        }
    }
}
