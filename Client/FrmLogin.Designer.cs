using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Client
{
    partial class FrmLogin
    {
        //PROPERTIES
        public Guna2TextBox UsernameTb { get { return usernameTb; } set { usernameTb = value; } }
        public Guna2TextBox PasswordTb { get { return passwordTb; } set { passwordTb = value; } }
        public Guna2Button LoginBtn { get { return loginBtn; } }



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
            this.components = new System.ComponentModel.Container();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.showPasswordBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(170, 820);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes1.Size = new System.Drawing.Size(720, 720);
            this.guna2Shapes1.TabIndex = 8;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 80;
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool1.TargetControl = null;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.showPasswordBtn);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.usernameTb);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.passwordTb);
            this.guna2Panel1.Controls.Add(this.loginBtn);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Location = new System.Drawing.Point(27, 89);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(576, 1042);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseUp);
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.showPasswordBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.showPasswordBtn.Image = global::Client.Properties.Resources.show_pass;
            this.showPasswordBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showPasswordBtn.ImageRotate = 0F;
            this.showPasswordBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.showPasswordBtn.Location = new System.Drawing.Point(488, 689);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.PressedState.Image = global::Client.Properties.Resources.hide_pass;
            this.showPasswordBtn.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.showPasswordBtn.Size = new System.Drawing.Size(45, 45);
            this.showPasswordBtn.TabIndex = 24;
            this.showPasswordBtn.UseTransparentBackground = true;
            this.showPasswordBtn.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "USERNAME";
            // 
            // usernameTb
            // 
            this.usernameTb.BorderRadius = 7;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.DefaultText = "";
            this.usernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Location = new System.Drawing.Point(27, 508);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.PlaceholderText = "";
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(524, 78);
            this.usernameTb.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "PASSWORD";
            // 
            // passwordTb
            // 
            this.passwordTb.BorderRadius = 7;
            this.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTb.DefaultText = "";
            this.passwordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTb.Location = new System.Drawing.Point(27, 671);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.PlaceholderText = "";
            this.passwordTb.SelectedText = "";
            this.passwordTb.Size = new System.Drawing.Size(524, 78);
            this.passwordTb.TabIndex = 12;
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 30;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.loginBtn.Font = new System.Drawing.Font("Verdana", 17F);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(27, 874);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(524, 89);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(57, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 124);
            this.label4.TabIndex = 18;
            this.label4.Text = "Login\r\n to Your Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.BorderThickness = 0;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.guna2Shapes2.Location = new System.Drawing.Point(-57, 612);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes2.Size = new System.Drawing.Size(1144, 1011);
            this.guna2Shapes2.TabIndex = 10;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.UseTransparentBackground = true;
            this.guna2Shapes2.Zoom = 80;
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes3.BorderThickness = 0;
            this.guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.guna2Shapes3.Location = new System.Drawing.Point(-240, 362);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes3.Size = new System.Drawing.Size(1402, 1465);
            this.guna2Shapes3.TabIndex = 11;
            this.guna2Shapes3.Text = "guna2Shapes3";
            this.guna2Shapes3.UseTransparentBackground = true;
            this.guna2Shapes3.Zoom = 80;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 10;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::Client.Properties.Resources.close;
            this.exitBtn.Location = new System.Drawing.Point(530, 15);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(70, 70);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.UseTransparentBackground = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(615, 1198);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.guna2Shapes3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTb;
        private Label label1;
        private Label label2;
        private Guna2TextBox usernameTb;
        private Guna2Button exitBtn;
        private Guna2ImageButton showPasswordBtn;
    }
}

