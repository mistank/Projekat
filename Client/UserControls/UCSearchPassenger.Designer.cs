namespace Client.UserControls
{
    partial class UCSearchPassenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.firstNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.passengersDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.discardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveDiscardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.fieldsPanel = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDgv)).BeginInit();
            this.saveDiscardPanel.SuspendLayout();
            this.fieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.Image = global::Client.Properties.Resources.search;
            this.homeIcon.Location = new System.Drawing.Point(25, 56);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(66, 50);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeIcon.TabIndex = 6;
            this.homeIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone";
            // 
            // searchByCb
            // 
            this.searchByCb.BackColor = System.Drawing.Color.Transparent;
            this.searchByCb.BorderRadius = 10;
            this.searchByCb.BorderThickness = 0;
            this.searchByCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchByCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByCb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.searchByCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByCb.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.searchByCb.ForeColor = System.Drawing.Color.White;
            this.searchByCb.ItemHeight = 30;
            this.searchByCb.Location = new System.Drawing.Point(953, 56);
            this.searchByCb.Name = "searchByCb";
            this.searchByCb.Size = new System.Drawing.Size(245, 36);
            this.searchByCb.TabIndex = 14;
            this.searchByCb.SelectedIndexChanged += new System.EventHandler(this.searchByCb_SelectedIndexChanged);
            // 
            // firstNameTb
            // 
            this.firstNameTb.BorderRadius = 10;
            this.firstNameTb.BorderThickness = 0;
            this.firstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTb.DefaultText = "";
            this.firstNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.firstNameTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.firstNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.firstNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTb.Location = new System.Drawing.Point(236, 24);
            this.firstNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.PasswordChar = '\0';
            this.firstNameTb.PlaceholderText = "";
            this.firstNameTb.SelectedText = "";
            this.firstNameTb.Size = new System.Drawing.Size(300, 50);
            this.firstNameTb.TabIndex = 16;
            // 
            // lastNameTb
            // 
            this.lastNameTb.BorderRadius = 10;
            this.lastNameTb.BorderThickness = 0;
            this.lastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTb.DefaultText = "";
            this.lastNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.lastNameTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lastNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.lastNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTb.Location = new System.Drawing.Point(236, 114);
            this.lastNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.PasswordChar = '\0';
            this.lastNameTb.PlaceholderText = "";
            this.lastNameTb.SelectedText = "";
            this.lastNameTb.Size = new System.Drawing.Size(300, 50);
            this.lastNameTb.TabIndex = 17;
            // 
            // phoneTb
            // 
            this.phoneTb.BorderRadius = 10;
            this.phoneTb.BorderThickness = 0;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.DefaultText = "";
            this.phoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.phoneTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.phoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.phoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTb.Location = new System.Drawing.Point(236, 207);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.PasswordChar = '\0';
            this.phoneTb.PlaceholderText = "";
            this.phoneTb.SelectedText = "";
            this.phoneTb.Size = new System.Drawing.Size(300, 50);
            this.phoneTb.TabIndex = 18;
            // 
            // searchTb
            // 
            this.searchTb.BorderRadius = 10;
            this.searchTb.BorderThickness = 0;
            this.searchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTb.DefaultText = "";
            this.searchTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTb.Enabled = false;
            this.searchTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.searchTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTb.Location = new System.Drawing.Point(115, 56);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "Search..";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(800, 50);
            this.searchTb.TabIndex = 19;
            this.searchTb.TextChanged += new System.EventHandler(this.searchBarTb_TextChanged);
            // 
            // passengersDgv
            // 
            this.passengersDgv.AllowUserToAddRows = false;
            this.passengersDgv.AllowUserToDeleteRows = false;
            this.passengersDgv.AllowUserToResizeColumns = false;
            this.passengersDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.passengersDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.passengersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.passengersDgv.ColumnHeadersHeight = 20;
            this.passengersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengersDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.passengersDgv.EnableHeadersVisualStyles = true;
            this.passengersDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.passengersDgv.Location = new System.Drawing.Point(115, 114);
            this.passengersDgv.MultiSelect = false;
            this.passengersDgv.Name = "passengersDgv";
            this.passengersDgv.ReadOnly = true;
            this.passengersDgv.RowHeadersVisible = false;
            this.passengersDgv.RowHeadersWidth = 62;
            this.passengersDgv.RowTemplate.Height = 28;
            this.passengersDgv.Size = new System.Drawing.Size(800, 367);
            this.passengersDgv.TabIndex = 0;
            this.passengersDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.passengersDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.passengersDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.passengersDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.passengersDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.passengersDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.passengersDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.passengersDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.passengersDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.passengersDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.passengersDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengersDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.passengersDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.passengersDgv.ThemeStyle.HeaderStyle.Height = 20;
            this.passengersDgv.ThemeStyle.ReadOnly = true;
            this.passengersDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.passengersDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.passengersDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengersDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.passengersDgv.ThemeStyle.RowsStyle.Height = 28;
            this.passengersDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.passengersDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.passengersDgv.DoubleClick += new System.EventHandler(this.passengersDgv_DoubleClick);
            // 
            // editBtn
            // 
            this.editBtn.BorderRadius = 10;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Location = new System.Drawing.Point(25, 877);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(230, 70);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(12, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(230, 70);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // discardBtn
            // 
            this.discardBtn.BorderRadius = 10;
            this.discardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.discardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.discardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.discardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.discardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.discardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discardBtn.ForeColor = System.Drawing.Color.Black;
            this.discardBtn.Location = new System.Drawing.Point(248, 21);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(230, 70);
            this.discardBtn.TabIndex = 23;
            this.discardBtn.Text = "Discard";
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // saveDiscardPanel
            // 
            this.saveDiscardPanel.Controls.Add(this.deleteBtn);
            this.saveDiscardPanel.Controls.Add(this.discardBtn);
            this.saveDiscardPanel.Controls.Add(this.saveBtn);
            this.saveDiscardPanel.Location = new System.Drawing.Point(559, 856);
            this.saveDiscardPanel.Name = "saveDiscardPanel";
            this.saveDiscardPanel.Size = new System.Drawing.Size(724, 112);
            this.saveDiscardPanel.TabIndex = 24;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderRadius = 10;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(484, 21);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(230, 70);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.Controls.Add(this.firstNameTb);
            this.fieldsPanel.Controls.Add(this.label1);
            this.fieldsPanel.Controls.Add(this.label2);
            this.fieldsPanel.Controls.Add(this.label3);
            this.fieldsPanel.Controls.Add(this.phoneTb);
            this.fieldsPanel.Controls.Add(this.lastNameTb);
            this.fieldsPanel.ForeColor = System.Drawing.Color.White;
            this.fieldsPanel.Location = new System.Drawing.Point(115, 542);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Size = new System.Drawing.Size(550, 300);
            this.fieldsPanel.TabIndex = 25;
            // 
            // UCSearchPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.passengersDgv);
            this.Controls.Add(this.fieldsPanel);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchByCb);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.saveDiscardPanel);
            this.Name = "UCSearchPassenger";
            this.Size = new System.Drawing.Size(1286, 968);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDgv)).EndInit();
            this.saveDiscardPanel.ResumeLayout(false);
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox searchByCb;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTb;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTb;
        private Guna.UI2.WinForms.Guna2TextBox phoneTb;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private Guna.UI2.WinForms.Guna2DataGridView passengersDgv;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button discardBtn;
        private Guna.UI2.WinForms.Guna2Panel saveDiscardPanel;
        private Guna.UI2.WinForms.Guna2Panel fieldsPanel;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
    }
}
