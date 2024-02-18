using System.Drawing;
using System.Security.Policy;
using System;
using System.Windows.Forms;


namespace Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainPnl = new System.Windows.Forms.Panel();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tripMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passengerMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reservationMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPnl.Location = new System.Drawing.Point(404, 0);
            this.mainPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(1286, 968);
            this.mainPnl.TabIndex = 0;
            // 
            // menuPnl
            // 
            this.menuPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.menuPnl.Controls.Add(this.logoutBtn);
            this.menuPnl.Controls.Add(this.homeMenuBtn);
            this.menuPnl.Controls.Add(this.tripMenuBtn);
            this.menuPnl.Controls.Add(this.passengerMenuBtn);
            this.menuPnl.Controls.Add(this.reservationMenuBtn);
            this.menuPnl.Controls.Add(this.panel1);
            this.menuPnl.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuPnl.Location = new System.Drawing.Point(0, 0);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(405, 968);
            this.menuPnl.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Animated = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.HoverState.Image = global::Client.Properties.Resources.logout_black;
            this.logoutBtn.Image = global::Client.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.logoutBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.logoutBtn.Location = new System.Drawing.Point(0, 878);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(405, 90);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.logoutBtn.UseTransparentBackground = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            this.logoutBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuBtn_MouseClick);
            // 
            // homeMenuBtn
            // 
            this.homeMenuBtn.Animated = true;
            this.homeMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeMenuBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeMenuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeMenuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeMenuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeMenuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.homeMenuBtn.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.homeMenuBtn.ForeColor = System.Drawing.Color.White;
            this.homeMenuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.homeMenuBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.homeMenuBtn.HoverState.Image = global::Client.Properties.Resources.home_black;
            this.homeMenuBtn.Image = global::Client.Properties.Resources.home;
            this.homeMenuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homeMenuBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.homeMenuBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.homeMenuBtn.IndicateFocus = true;
            this.homeMenuBtn.Location = new System.Drawing.Point(-4, 307);
            this.homeMenuBtn.Name = "homeMenuBtn";
            this.homeMenuBtn.Size = new System.Drawing.Size(409, 90);
            this.homeMenuBtn.TabIndex = 17;
            this.homeMenuBtn.Text = "Home";
            this.homeMenuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeMenuBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.homeMenuBtn.UseTransparentBackground = true;
            this.homeMenuBtn.Click += new System.EventHandler(this.menuBtnClick);
            this.homeMenuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuBtn_MouseClick);
            // 
            // tripMenuBtn
            // 
            this.tripMenuBtn.Animated = true;
            this.tripMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.tripMenuBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tripMenuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tripMenuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tripMenuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tripMenuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tripMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.tripMenuBtn.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.tripMenuBtn.ForeColor = System.Drawing.Color.White;
            this.tripMenuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.tripMenuBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.tripMenuBtn.HoverState.Image = global::Client.Properties.Resources.trip_black;
            this.tripMenuBtn.Image = global::Client.Properties.Resources.trip;
            this.tripMenuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tripMenuBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.tripMenuBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.tripMenuBtn.IndicateFocus = true;
            this.tripMenuBtn.Location = new System.Drawing.Point(-4, 396);
            this.tripMenuBtn.Name = "tripMenuBtn";
            this.tripMenuBtn.Size = new System.Drawing.Size(409, 90);
            this.tripMenuBtn.TabIndex = 16;
            this.tripMenuBtn.Text = "Trips";
            this.tripMenuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tripMenuBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.tripMenuBtn.UseTransparentBackground = true;
            this.tripMenuBtn.Click += new System.EventHandler(this.menuBtnClick);
            this.tripMenuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuBtn_MouseClick);
            // 
            // passengerMenuBtn
            // 
            this.passengerMenuBtn.Animated = true;
            this.passengerMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.passengerMenuBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.passengerMenuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passengerMenuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passengerMenuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passengerMenuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passengerMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.passengerMenuBtn.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.passengerMenuBtn.ForeColor = System.Drawing.Color.White;
            this.passengerMenuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.passengerMenuBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.passengerMenuBtn.HoverState.Image = global::Client.Properties.Resources.tourist_black;
            this.passengerMenuBtn.Image = global::Client.Properties.Resources.toruist;
            this.passengerMenuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passengerMenuBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.passengerMenuBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.passengerMenuBtn.IndicateFocus = true;
            this.passengerMenuBtn.Location = new System.Drawing.Point(-4, 484);
            this.passengerMenuBtn.Name = "passengerMenuBtn";
            this.passengerMenuBtn.Size = new System.Drawing.Size(409, 90);
            this.passengerMenuBtn.TabIndex = 15;
            this.passengerMenuBtn.Text = "Passengers";
            this.passengerMenuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passengerMenuBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.passengerMenuBtn.UseTransparentBackground = true;
            this.passengerMenuBtn.Click += new System.EventHandler(this.menuBtnClick);
            this.passengerMenuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuBtn_MouseClick);
            // 
            // reservationMenuBtn
            // 
            this.reservationMenuBtn.Animated = true;
            this.reservationMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.reservationMenuBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.reservationMenuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservationMenuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservationMenuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservationMenuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservationMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.reservationMenuBtn.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.reservationMenuBtn.ForeColor = System.Drawing.Color.White;
            this.reservationMenuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.reservationMenuBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.reservationMenuBtn.HoverState.Image = global::Client.Properties.Resources.reservation_black;
            this.reservationMenuBtn.Image = global::Client.Properties.Resources.reservation;
            this.reservationMenuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.reservationMenuBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.reservationMenuBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.reservationMenuBtn.IndicateFocus = true;
            this.reservationMenuBtn.Location = new System.Drawing.Point(-4, 572);
            this.reservationMenuBtn.Name = "reservationMenuBtn";
            this.reservationMenuBtn.Size = new System.Drawing.Size(409, 90);
            this.reservationMenuBtn.TabIndex = 14;
            this.reservationMenuBtn.Text = "Reservations";
            this.reservationMenuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reservationMenuBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.reservationMenuBtn.UseTransparentBackground = true;
            this.reservationMenuBtn.Click += new System.EventHandler(this.menuBtnClick);
            this.reservationMenuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuBtn_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userLbl);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 100);
            this.panel1.TabIndex = 13;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.userLbl.ForeColor = System.Drawing.Color.White;
            this.userLbl.Location = new System.Drawing.Point(93, 24);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(120, 47);
            this.userLbl.TabIndex = 13;
            this.userLbl.Text = "label1";
            this.userLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 968);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.mainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel MainPnl { get { return mainPnl; } set { mainPnl = value; } }
        

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userLbl;
        private Guna.UI2.WinForms.Guna2Button reservationMenuBtn;
        private Guna.UI2.WinForms.Guna2Button passengerMenuBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button homeMenuBtn;
        private Guna.UI2.WinForms.Guna2Button tripMenuBtn;
    }
}