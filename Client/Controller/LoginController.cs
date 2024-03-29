﻿using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    public class LoginController
    {
        private static LoginController instance;
        public FrmLogin frmLogin;
        public static LoginController Instance { get { if (instance == null) { instance = new LoginController(); } return instance; } }
        public void Login(User user)
        {
            LogoutController.Instance.User = user;
            Response res = Communication.Instance.Login(user);
            if (res.Exception == null)
            {
                MessageBox.Show("Login successful" ,$"Welcome {user.FirstName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin.Visible = false;
                MainController.Instance.ShowFrmMain((User)res.Result);
            }
            else
            {
                if (res.Exception.Message == "Server closed")
                {
                    MessageBox.Show("Server closed", "Login unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainController.Instance.frmMain?.Dispose();
                    LoginController.Instance.frmLogin?.Dispose();
                }
                else
                {
                    MessageBox.Show(res.Exception.Message, "Login unsuccessful.. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void ShowFrmLogin()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin = new FrmLogin();
            LogoutController.Instance.frmLogin = frmLogin;
            Application.Run(frmLogin);
        }
    }
}
