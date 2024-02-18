using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCAddPassenger
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passengerFieldsPanel = new System.Windows.Forms.Panel();
            this.jmbgTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addPassengerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.passengerFieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 47);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 47);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 58);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add New Passenger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(193, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Passenger Info";
            // 
            // passengerFieldsPanel
            // 
            this.passengerFieldsPanel.Controls.Add(this.jmbgTb);
            this.passengerFieldsPanel.Controls.Add(this.phoneTb);
            this.passengerFieldsPanel.Controls.Add(this.lastNameTb);
            this.passengerFieldsPanel.Controls.Add(this.firstNameTb);
            this.passengerFieldsPanel.Controls.Add(this.label7);
            this.passengerFieldsPanel.Controls.Add(this.label6);
            this.passengerFieldsPanel.Controls.Add(this.label4);
            this.passengerFieldsPanel.Controls.Add(this.label2);
            this.passengerFieldsPanel.Controls.Add(this.label3);
            this.passengerFieldsPanel.ForeColor = System.Drawing.Color.White;
            this.passengerFieldsPanel.Location = new System.Drawing.Point(364, 273);
            this.passengerFieldsPanel.Name = "passengerFieldsPanel";
            this.passengerFieldsPanel.Size = new System.Drawing.Size(559, 546);
            this.passengerFieldsPanel.TabIndex = 26;
            // 
            // jmbgTb
            // 
            this.jmbgTb.Animated = true;
            this.jmbgTb.BorderRadius = 10;
            this.jmbgTb.BorderThickness = 0;
            this.jmbgTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jmbgTb.DefaultText = "";
            this.jmbgTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.jmbgTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.jmbgTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.jmbgTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.jmbgTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.jmbgTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jmbgTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jmbgTb.ForeColor = System.Drawing.Color.White;
            this.jmbgTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jmbgTb.Location = new System.Drawing.Point(279, 361);
            this.jmbgTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jmbgTb.Name = "jmbgTb";
            this.jmbgTb.PasswordChar = '\0';
            this.jmbgTb.PlaceholderText = "";
            this.jmbgTb.SelectedText = "";
            this.jmbgTb.Size = new System.Drawing.Size(260, 40);
            this.jmbgTb.TabIndex = 30;
            // 
            // phoneTb
            // 
            this.phoneTb.Animated = true;
            this.phoneTb.BorderRadius = 10;
            this.phoneTb.BorderThickness = 0;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.DefaultText = "";
            this.phoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.phoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTb.ForeColor = System.Drawing.Color.White;
            this.phoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTb.Location = new System.Drawing.Point(279, 272);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.PasswordChar = '\0';
            this.phoneTb.PlaceholderText = "";
            this.phoneTb.SelectedText = "";
            this.phoneTb.Size = new System.Drawing.Size(260, 40);
            this.phoneTb.TabIndex = 29;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Animated = true;
            this.lastNameTb.BorderRadius = 10;
            this.lastNameTb.BorderThickness = 0;
            this.lastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTb.DefaultText = "";
            this.lastNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.lastNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTb.ForeColor = System.Drawing.Color.White;
            this.lastNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTb.Location = new System.Drawing.Point(279, 176);
            this.lastNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.PasswordChar = '\0';
            this.lastNameTb.PlaceholderText = "";
            this.lastNameTb.SelectedText = "";
            this.lastNameTb.Size = new System.Drawing.Size(260, 40);
            this.lastNameTb.TabIndex = 28;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Animated = true;
            this.firstNameTb.BorderRadius = 10;
            this.firstNameTb.BorderThickness = 0;
            this.firstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTb.DefaultText = "";
            this.firstNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.firstNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTb.ForeColor = System.Drawing.Color.White;
            this.firstNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTb.Location = new System.Drawing.Point(279, 89);
            this.firstNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.PasswordChar = '\0';
            this.firstNameTb.PlaceholderText = "";
            this.firstNameTb.SelectedText = "";
            this.firstNameTb.Size = new System.Drawing.Size(260, 40);
            this.firstNameTb.TabIndex = 27;
            // 
            // addPassengerBtn
            // 
            this.addPassengerBtn.BorderRadius = 10;
            this.addPassengerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addPassengerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addPassengerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addPassengerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addPassengerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.addPassengerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addPassengerBtn.ForeColor = System.Drawing.Color.Black;
            this.addPassengerBtn.Location = new System.Drawing.Point(483, 900);
            this.addPassengerBtn.Name = "addPassengerBtn";
            this.addPassengerBtn.Size = new System.Drawing.Size(320, 50);
            this.addPassengerBtn.TabIndex = 27;
            this.addPassengerBtn.Text = "Add";
            this.addPassengerBtn.Click += new System.EventHandler(this.addPassengerBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 47);
            this.label7.TabIndex = 25;
            this.label7.Text = "JMBG";
            // 
            // UCAddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.passengerFieldsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPassengerBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCAddPassenger";
            this.Size = new System.Drawing.Size(1286, 968);
            this.passengerFieldsPanel.ResumeLayout(false);
            this.passengerFieldsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna2TextBox FirstNameTb { get { return firstNameTb; } set { firstNameTb = value; } }
        public Guna2TextBox LastNameTb { get { return lastNameTb; } set { lastNameTb = value; } }
        public Guna2TextBox PhoneTb { get { return phoneTb; } set { phoneTb = value; } }

        public Guna2TextBox JMBGTb { get { return jmbgTb; } set{ jmbgTb = value; } }

        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel passengerFieldsPanel;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button addPassengerBtn;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTb;
        private Guna.UI2.WinForms.Guna2TextBox jmbgTb;
        private Guna.UI2.WinForms.Guna2TextBox phoneTb;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTb;
    }
}
