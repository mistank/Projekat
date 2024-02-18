using Common.Domain;
using Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Guna.UI2.WinForms;

namespace Client
{
    public partial class FrmMain : Form
    {
        private User loggedUser;
        private static bool dragging = false;
        private static Point startPoint = new Point(0, 0);
        public void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        public void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
        public  void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        public FrmMain(User user)
        {
            InitializeComponent();
            loggedUser = user;
            userLbl.Text = $"Hello, {loggedUser.FirstName}";
        }
        public FrmMain()
        {
            InitializeComponent();
        }
        public void menuBtnClick(object sender, EventArgs e)
        {
            /*event handler za svu dugmad u meniju glavne forme sem logout dugmeta*/
            MainController.Instance.ShowMenu(sender, e);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogoutController.Instance.Logout();
            this.Dispose();
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            reservationMenuBtn.FillColor = Color.FromArgb(10, 186, 180);
            reservationMenuBtn.ForeColor = Color.Black;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            reservationMenuBtn.FillColor = Color.Transparent;
            reservationMenuBtn.ForeColor = Color.White;
        }

        private void MenuBtn_MouseClick(object sender, MouseEventArgs e)
        {
            foreach(Guna2Button button in menuPnl.Controls.OfType<Guna2Button>().ToList())
            {
                if(button.Name != $"{((Guna2Button)sender).Name}")
                {
                    button.FillColor = Color.Transparent;
                    button.ForeColor = Color.White;
                }
            }
            ((Guna2Button)sender).FillColor = Color.FromArgb(10, 186, 180);
            ((Guna2Button)sender).ForeColor = Color.Black;
        }

        
    }
}
