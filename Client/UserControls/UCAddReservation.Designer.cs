namespace Client.UserControls
{
    partial class UCAddReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passengersDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tripsDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Trip = new System.Windows.Forms.Label();
            this.addReservationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchPassengerTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.tripFieldsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.arrivalDateDp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.departureDateDp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.destinationTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.priceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passengerFielsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.firstNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.destinationSearchPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.searchDestinationTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.destinationsDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsDgv)).BeginInit();
            this.tripFieldsPanel.SuspendLayout();
            this.passengerFielsPanel.SuspendLayout();
            this.destinationSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(455, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 58);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 870);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 47);
            this.label2.TabIndex = 32;
            this.label2.Text = "Status";
            // 
            // statusCb
            // 
            this.statusCb.BackColor = System.Drawing.Color.Transparent;
            this.statusCb.BorderRadius = 10;
            this.statusCb.BorderThickness = 0;
            this.statusCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.statusCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusCb.ForeColor = System.Drawing.Color.White;
            this.statusCb.ItemHeight = 30;
            this.statusCb.Location = new System.Drawing.Point(280, 877);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(320, 36);
            this.statusCb.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(32, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "Choose a passenger";
            // 
            // passengersDgv
            // 
            this.passengersDgv.AllowUserToAddRows = false;
            this.passengersDgv.AllowUserToDeleteRows = false;
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
            this.passengersDgv.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengersDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.passengersDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.passengersDgv.Location = new System.Drawing.Point(38, 481);
            this.passengersDgv.MultiSelect = false;
            this.passengersDgv.Name = "passengersDgv";
            this.passengersDgv.ReadOnly = true;
            this.passengersDgv.RowHeadersVisible = false;
            this.passengersDgv.RowHeadersWidth = 62;
            this.passengersDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.passengersDgv.RowTemplate.Height = 28;
            this.passengersDgv.Size = new System.Drawing.Size(562, 152);
            this.passengersDgv.TabIndex = 35;
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
            this.passengersDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.passengersDgv.ThemeStyle.HeaderStyle.Height = 4;
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
            // tripsDgv
            // 
            this.tripsDgv.AllowUserToAddRows = false;
            this.tripsDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.tripsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tripsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tripsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tripsDgv.ColumnHeadersHeight = 4;
            this.tripsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tripsDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.tripsDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.tripsDgv.Location = new System.Drawing.Point(669, 201);
            this.tripsDgv.Name = "tripsDgv";
            this.tripsDgv.ReadOnly = true;
            this.tripsDgv.RowHeadersVisible = false;
            this.tripsDgv.RowHeadersWidth = 62;
            this.tripsDgv.RowTemplate.Height = 28;
            this.tripsDgv.Size = new System.Drawing.Size(562, 177);
            this.tripsDgv.TabIndex = 37;
            this.tripsDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.tripsDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.tripsDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tripsDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tripsDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tripsDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tripsDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.tripsDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.tripsDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tripsDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tripsDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripsDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tripsDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tripsDgv.ThemeStyle.HeaderStyle.Height = 4;
            this.tripsDgv.ThemeStyle.ReadOnly = true;
            this.tripsDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tripsDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tripsDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripsDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.tripsDgv.ThemeStyle.RowsStyle.Height = 28;
            this.tripsDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.tripsDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tripsDgv.DoubleClick += new System.EventHandler(this.tripsDgv_DoubleClick);
            // 
            // Trip
            // 
            this.Trip.AutoSize = true;
            this.Trip.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.Trip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Trip.Location = new System.Drawing.Point(663, 158);
            this.Trip.Name = "Trip";
            this.Trip.Size = new System.Drawing.Size(182, 35);
            this.Trip.TabIndex = 36;
            this.Trip.Text = "Choose a trip";
            // 
            // addReservationBtn
            // 
            this.addReservationBtn.BorderRadius = 10;
            this.addReservationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addReservationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addReservationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addReservationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addReservationBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.addReservationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addReservationBtn.ForeColor = System.Drawing.Color.Black;
            this.addReservationBtn.Location = new System.Drawing.Point(878, 877);
            this.addReservationBtn.Name = "addReservationBtn";
            this.addReservationBtn.Size = new System.Drawing.Size(353, 59);
            this.addReservationBtn.TabIndex = 38;
            this.addReservationBtn.Text = "Add";
            this.addReservationBtn.Click += new System.EventHandler(this.addReservationBtn_Click);
            // 
            // searchPassengerTb
            // 
            this.searchPassengerTb.BorderRadius = 10;
            this.searchPassengerTb.BorderThickness = 0;
            this.searchPassengerTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchPassengerTb.DefaultText = "";
            this.searchPassengerTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchPassengerTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchPassengerTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchPassengerTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchPassengerTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.searchPassengerTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchPassengerTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchPassengerTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchPassengerTb.Location = new System.Drawing.Point(346, 414);
            this.searchPassengerTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPassengerTb.Name = "searchPassengerTb";
            this.searchPassengerTb.PasswordChar = '\0';
            this.searchPassengerTb.PlaceholderText = "Enter Name..";
            this.searchPassengerTb.SelectedText = "";
            this.searchPassengerTb.Size = new System.Drawing.Size(254, 50);
            this.searchPassengerTb.TabIndex = 43;
            this.searchPassengerTb.TextChanged += new System.EventHandler(this.searchPassengerTb_TextChanged);
            // 
            // tripFieldsPanel
            // 
            this.tripFieldsPanel.Controls.Add(this.arrivalDateDp);
            this.tripFieldsPanel.Controls.Add(this.departureDateDp);
            this.tripFieldsPanel.Controls.Add(this.label7);
            this.tripFieldsPanel.Controls.Add(this.label8);
            this.tripFieldsPanel.Controls.Add(this.destinationTb);
            this.tripFieldsPanel.Controls.Add(this.label9);
            this.tripFieldsPanel.Controls.Add(this.priceTb);
            this.tripFieldsPanel.Controls.Add(this.label10);
            this.tripFieldsPanel.Enabled = false;
            this.tripFieldsPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tripFieldsPanel.Location = new System.Drawing.Point(38, 656);
            this.tripFieldsPanel.Name = "tripFieldsPanel";
            this.tripFieldsPanel.Size = new System.Drawing.Size(1214, 194);
            this.tripFieldsPanel.TabIndex = 45;
            // 
            // arrivalDateDp
            // 
            this.arrivalDateDp.BorderRadius = 10;
            this.arrivalDateDp.Checked = true;
            this.arrivalDateDp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.arrivalDateDp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.arrivalDateDp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.arrivalDateDp.Location = new System.Drawing.Point(862, 23);
            this.arrivalDateDp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.arrivalDateDp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.arrivalDateDp.Name = "arrivalDateDp";
            this.arrivalDateDp.Size = new System.Drawing.Size(331, 50);
            this.arrivalDateDp.TabIndex = 37;
            this.arrivalDateDp.Value = new System.DateTime(2024, 2, 13, 12, 29, 6, 974);
            this.arrivalDateDp.DropDown += new System.EventHandler(this.Dp_DropDown);
            this.arrivalDateDp.Leave += new System.EventHandler(this.Dp_Leave);
            // 
            // departureDateDp
            // 
            this.departureDateDp.BorderColor = System.Drawing.Color.Transparent;
            this.departureDateDp.BorderRadius = 10;
            this.departureDateDp.Checked = true;
            this.departureDateDp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.departureDateDp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.departureDateDp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.departureDateDp.IndicateFocus = true;
            this.departureDateDp.Location = new System.Drawing.Point(242, 23);
            this.departureDateDp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.departureDateDp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.departureDateDp.Name = "departureDateDp";
            this.departureDateDp.Size = new System.Drawing.Size(320, 50);
            this.departureDateDp.TabIndex = 36;
            this.departureDateDp.Value = new System.DateTime(2024, 2, 13, 12, 29, 6, 974);
            this.departureDateDp.DropDown += new System.EventHandler(this.Dp_DropDown);
            this.departureDateDp.Leave += new System.EventHandler(this.Dp_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 47);
            this.label7.TabIndex = 22;
            this.label7.Text = "Departure";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(623, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 47);
            this.label8.TabIndex = 23;
            this.label8.Text = "Arrival";
            // 
            // destinationTb
            // 
            this.destinationTb.BorderRadius = 10;
            this.destinationTb.BorderThickness = 0;
            this.destinationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationTb.DefaultText = "";
            this.destinationTb.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.destinationTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.destinationTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.destinationTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.destinationTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destinationTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationTb.Location = new System.Drawing.Point(242, 97);
            this.destinationTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinationTb.Name = "destinationTb";
            this.destinationTb.PasswordChar = '\0';
            this.destinationTb.PlaceholderText = "";
            this.destinationTb.SelectedText = "";
            this.destinationTb.Size = new System.Drawing.Size(320, 50);
            this.destinationTb.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(623, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 47);
            this.label9.TabIndex = 24;
            this.label9.Text = "Price";
            // 
            // priceTb
            // 
            this.priceTb.BorderRadius = 10;
            this.priceTb.BorderThickness = 0;
            this.priceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTb.DefaultText = "";
            this.priceTb.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.priceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.priceTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.priceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.priceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTb.Location = new System.Drawing.Point(862, 97);
            this.priceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTb.Name = "priceTb";
            this.priceTb.PasswordChar = '\0';
            this.priceTb.PlaceholderText = "";
            this.priceTb.SelectedText = "";
            this.priceTb.Size = new System.Drawing.Size(331, 50);
            this.priceTb.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 47);
            this.label10.TabIndex = 31;
            this.label10.Text = "Destination";
            // 
            // passengerFielsPanel
            // 
            this.passengerFielsPanel.Controls.Add(this.firstNameTb);
            this.passengerFielsPanel.Controls.Add(this.label4);
            this.passengerFielsPanel.Controls.Add(this.label6);
            this.passengerFielsPanel.Controls.Add(this.label11);
            this.passengerFielsPanel.Controls.Add(this.phoneTb);
            this.passengerFielsPanel.Controls.Add(this.lastNameTb);
            this.passengerFielsPanel.FillColor = System.Drawing.Color.Transparent;
            this.passengerFielsPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passengerFielsPanel.Location = new System.Drawing.Point(32, 147);
            this.passengerFielsPanel.Name = "passengerFielsPanel";
            this.passengerFielsPanel.Size = new System.Drawing.Size(568, 259);
            this.passengerFielsPanel.TabIndex = 46;
            // 
            // firstNameTb
            // 
            this.firstNameTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstNameTb.BorderRadius = 10;
            this.firstNameTb.BorderThickness = 0;
            this.firstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTb.DefaultText = "";
            this.firstNameTb.DisabledState.BorderColor = System.Drawing.Color.Red;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 47);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(20, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 47);
            this.label11.TabIndex = 12;
            this.label11.Text = "Phone";
            // 
            // phoneTb
            // 
            this.phoneTb.BorderRadius = 10;
            this.phoneTb.BorderThickness = 0;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.DefaultText = "";
            this.phoneTb.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.phoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.phoneTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.phoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.phoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTb.Location = new System.Drawing.Point(236, 97);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.PasswordChar = '\0';
            this.phoneTb.PlaceholderText = "";
            this.phoneTb.SelectedText = "";
            this.phoneTb.Size = new System.Drawing.Size(300, 50);
            this.phoneTb.TabIndex = 18;
            // 
            // lastNameTb
            // 
            this.lastNameTb.BorderRadius = 10;
            this.lastNameTb.BorderThickness = 0;
            this.lastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTb.DefaultText = "";
            this.lastNameTb.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.lastNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.lastNameTb.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lastNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.lastNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTb.Location = new System.Drawing.Point(236, 181);
            this.lastNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.PasswordChar = '\0';
            this.lastNameTb.PlaceholderText = "";
            this.lastNameTb.SelectedText = "";
            this.lastNameTb.Size = new System.Drawing.Size(300, 50);
            this.lastNameTb.TabIndex = 17;
            // 
            // destinationSearchPanel
            // 
            this.destinationSearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.destinationSearchPanel.BorderRadius = 20;
            this.destinationSearchPanel.Controls.Add(this.label5);
            this.destinationSearchPanel.Controls.Add(this.searchDestinationTb);
            this.destinationSearchPanel.Controls.Add(this.destinationsDgv);
            this.destinationSearchPanel.FillColor = System.Drawing.Color.Transparent;
            this.destinationSearchPanel.Location = new System.Drawing.Point(671, 414);
            this.destinationSearchPanel.Name = "destinationSearchPanel";
            this.destinationSearchPanel.Size = new System.Drawing.Size(581, 236);
            this.destinationSearchPanel.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(11, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 35);
            this.label5.TabIndex = 48;
            this.label5.Text = "Choose a destination";
            // 
            // searchDestinationTb
            // 
            this.searchDestinationTb.BorderRadius = 10;
            this.searchDestinationTb.BorderThickness = 0;
            this.searchDestinationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchDestinationTb.DefaultText = "";
            this.searchDestinationTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchDestinationTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchDestinationTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchDestinationTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchDestinationTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.searchDestinationTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchDestinationTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchDestinationTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchDestinationTb.Location = new System.Drawing.Point(306, 5);
            this.searchDestinationTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDestinationTb.Name = "searchDestinationTb";
            this.searchDestinationTb.PasswordChar = '\0';
            this.searchDestinationTb.PlaceholderText = "Enter Name..\r\n";
            this.searchDestinationTb.SelectedText = "";
            this.searchDestinationTb.Size = new System.Drawing.Size(254, 50);
            this.searchDestinationTb.TabIndex = 36;
            this.searchDestinationTb.TextChanged += new System.EventHandler(this.searchDestinationTb_TextChanged);
            // 
            // destinationsDgv
            // 
            this.destinationsDgv.AllowUserToAddRows = false;
            this.destinationsDgv.AllowUserToDeleteRows = false;
            this.destinationsDgv.AllowUserToResizeColumns = false;
            this.destinationsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.destinationsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.destinationsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.destinationsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.destinationsDgv.ColumnHeadersHeight = 20;
            this.destinationsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.destinationsDgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.destinationsDgv.EnableHeadersVisualStyles = true;
            this.destinationsDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.destinationsDgv.Location = new System.Drawing.Point(17, 67);
            this.destinationsDgv.MultiSelect = false;
            this.destinationsDgv.Name = "destinationsDgv";
            this.destinationsDgv.ReadOnly = true;
            this.destinationsDgv.RowHeadersVisible = false;
            this.destinationsDgv.RowHeadersWidth = 62;
            this.destinationsDgv.RowTemplate.Height = 28;
            this.destinationsDgv.Size = new System.Drawing.Size(543, 152);
            this.destinationsDgv.TabIndex = 0;
            this.destinationsDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.destinationsDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.destinationsDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.destinationsDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.destinationsDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.destinationsDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationsDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.destinationsDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.destinationsDgv.ThemeStyle.HeaderStyle.Height = 20;
            this.destinationsDgv.ThemeStyle.ReadOnly = true;
            this.destinationsDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.destinationsDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.destinationsDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationsDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.destinationsDgv.ThemeStyle.RowsStyle.Height = 28;
            this.destinationsDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.destinationsDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.destinationsDgv.DoubleClick += new System.EventHandler(this.destinationsDgv_DoubleClick);
            // 
            // UCAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.destinationSearchPanel);
            this.Controls.Add(this.passengerFielsPanel);
            this.Controls.Add(this.tripFieldsPanel);
            this.Controls.Add(this.searchPassengerTb);
            this.Controls.Add(this.addReservationBtn);
            this.Controls.Add(this.tripsDgv);
            this.Controls.Add(this.Trip);
            this.Controls.Add(this.passengersDgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddReservation";
            this.Size = new System.Drawing.Size(1286, 968);
            ((System.ComponentModel.ISupportInitialize)(this.passengersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsDgv)).EndInit();
            this.tripFieldsPanel.ResumeLayout(false);
            this.tripFieldsPanel.PerformLayout();
            this.passengerFielsPanel.ResumeLayout(false);
            this.passengerFielsPanel.PerformLayout();
            this.destinationSearchPanel.ResumeLayout(false);
            this.destinationSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox statusCb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView passengersDgv;
        private Guna.UI2.WinForms.Guna2DataGridView tripsDgv;
        private System.Windows.Forms.Label Trip;
        private Guna.UI2.WinForms.Guna2Button addReservationBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchPassengerTb;
        private Guna.UI2.WinForms.Guna2Panel tripFieldsPanel;
        private Guna.UI2.WinForms.Guna2DateTimePicker arrivalDateDp;
        private Guna.UI2.WinForms.Guna2DateTimePicker departureDateDp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox destinationTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox priceTb;
        private Guna.UI2.WinForms.Guna2Panel passengerFielsPanel;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox phoneTb;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTb;
        private Guna.UI2.WinForms.Guna2Panel destinationSearchPanel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox searchDestinationTb;
        private Guna.UI2.WinForms.Guna2DataGridView destinationsDgv;
    }
}
