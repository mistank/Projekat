using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using System.Runtime.InteropServices;
using Common.Domain;
using Common;
using Guna.UI2.WinForms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        private bool showPassword = false;
        private User User {  get; set; }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.FillColor = Color.FromArgb(10, 186, 180);
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.FillColor = Color.Transparent;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }
        public void Login()
        {
            User user = new User()
            {
                Username = usernameTb.Text,
                Password = passwordTb.Text,
            };
            User = user;
            LoginController.Instance.Login(User);
        }
        private void PasswordButton_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            // Postavi odgovarajući karakter za PasswordChar svojstvo TextBox-a
            if (showPassword)
            {
                passwordTb.PasswordChar = '\0'; // Prikaz lozinke
                showPasswordBtn.Image = Properties.Resources.hide_pass;
            }
            else
            {
                passwordTb.PasswordChar = '*'; // Maskirani prikaz lozinke
                showPasswordBtn.Image = Properties.Resources.show_pass;
            }

        }
    }
}
