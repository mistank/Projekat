namespace Client.UserControls
{
    partial class UCAddTrip
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addTripBtn = new Guna.UI2.WinForms.Guna2Button();
            this.destinationSearchPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.searchDestinationTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.destinationsDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.priceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.destinationTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.arrivalDataDp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.departureDateDp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.destinationSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addTripBtn);
            this.panel2.Controls.Add(this.priceTb);
            this.panel2.Controls.Add(this.destinationTb);
            this.panel2.Controls.Add(this.arrivalDataDp);
            this.panel2.Controls.Add(this.departureDateDp);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(30, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 776);
            this.panel2.TabIndex = 29;
            // 
            // addTripBtn
            // 
            this.addTripBtn.BorderRadius = 10;
            this.addTripBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addTripBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addTripBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addTripBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addTripBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.addTripBtn.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Bold);
            this.addTripBtn.ForeColor = System.Drawing.Color.Black;
            this.addTripBtn.Location = new System.Drawing.Point(114, 704);
            this.addTripBtn.Name = "addTripBtn";
            this.addTripBtn.Size = new System.Drawing.Size(380, 60);
            this.addTripBtn.TabIndex = 40;
            this.addTripBtn.Text = "Add";
            this.addTripBtn.Click += new System.EventHandler(this.addTripBtn_Click);
            // 
            // destinationSearchPanel
            // 
            this.destinationSearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.destinationSearchPanel.BorderRadius = 20;
            this.destinationSearchPanel.Controls.Add(this.searchDestinationTb);
            this.destinationSearchPanel.Controls.Add(this.destinationsDgv);
            this.destinationSearchPanel.FillColor = System.Drawing.Color.Transparent;
            this.destinationSearchPanel.Location = new System.Drawing.Point(671, 193);
            this.destinationSearchPanel.Name = "destinationSearchPanel";
            this.destinationSearchPanel.Size = new System.Drawing.Size(592, 371);
            this.destinationSearchPanel.TabIndex = 39;
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
            this.searchDestinationTb.Location = new System.Drawing.Point(17, 12);
            this.searchDestinationTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDestinationTb.Name = "searchDestinationTb";
            this.searchDestinationTb.PasswordChar = '\0';
            this.searchDestinationTb.PlaceholderText = "Enter Name..\r\n";
            this.searchDestinationTb.SelectedText = "";
            this.searchDestinationTb.Size = new System.Drawing.Size(194, 50);
            this.searchDestinationTb.TabIndex = 36;
            this.searchDestinationTb.TextChanged += new System.EventHandler(this.searchDestinationTb_TextChanged);
            // 
            // destinationsDgv
            // 
            this.destinationsDgv.AllowUserToAddRows = false;
            this.destinationsDgv.AllowUserToDeleteRows = false;
            this.destinationsDgv.AllowUserToResizeColumns = false;
            this.destinationsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.destinationsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.destinationsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.destinationsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.destinationsDgv.ColumnHeadersHeight = 20;
            this.destinationsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.destinationsDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.destinationsDgv.EnableHeadersVisualStyles = true;
            this.destinationsDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.destinationsDgv.Location = new System.Drawing.Point(17, 68);
            this.destinationsDgv.MultiSelect = false;
            this.destinationsDgv.Name = "destinationsDgv";
            this.destinationsDgv.ReadOnly = true;
            this.destinationsDgv.RowHeadersVisible = false;
            this.destinationsDgv.RowHeadersWidth = 62;
            this.destinationsDgv.RowTemplate.Height = 28;
            this.destinationsDgv.Size = new System.Drawing.Size(572, 281);
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
            // priceTb
            // 
            this.priceTb.BorderRadius = 10;
            this.priceTb.BorderThickness = 0;
            this.priceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTb.DefaultText = "";
            this.priceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.priceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTb.ForeColor = System.Drawing.Color.White;
            this.priceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTb.Location = new System.Drawing.Point(282, 275);
            this.priceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTb.Name = "priceTb";
            this.priceTb.PasswordChar = '\0';
            this.priceTb.PlaceholderText = "";
            this.priceTb.SelectedText = "";
            this.priceTb.Size = new System.Drawing.Size(320, 50);
            this.priceTb.TabIndex = 30;
            // 
            // destinationTb
            // 
            this.destinationTb.BorderRadius = 10;
            this.destinationTb.BorderThickness = 0;
            this.destinationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationTb.DefaultText = "";
            this.destinationTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.destinationTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.destinationTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.destinationTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destinationTb.ForeColor = System.Drawing.Color.White;
            this.destinationTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationTb.Location = new System.Drawing.Point(282, 369);
            this.destinationTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinationTb.Name = "destinationTb";
            this.destinationTb.PasswordChar = '\0';
            this.destinationTb.PlaceholderText = "";
            this.destinationTb.SelectedText = "";
            this.destinationTb.Size = new System.Drawing.Size(320, 50);
            this.destinationTb.TabIndex = 29;
            // 
            // arrivalDataDp
            // 
            this.arrivalDataDp.BorderRadius = 10;
            this.arrivalDataDp.Checked = true;
            this.arrivalDataDp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.arrivalDataDp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.arrivalDataDp.ForeColor = System.Drawing.Color.White;
            this.arrivalDataDp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.arrivalDataDp.Location = new System.Drawing.Point(282, 182);
            this.arrivalDataDp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.arrivalDataDp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.arrivalDataDp.Name = "arrivalDataDp";
            this.arrivalDataDp.Size = new System.Drawing.Size(320, 50);
            this.arrivalDataDp.TabIndex = 28;
            this.arrivalDataDp.Value = new System.DateTime(2024, 2, 13, 20, 46, 0, 644);
            // 
            // departureDateDp
            // 
            this.departureDateDp.BorderRadius = 10;
            this.departureDateDp.Checked = true;
            this.departureDateDp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.departureDateDp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.departureDateDp.ForeColor = System.Drawing.Color.White;
            this.departureDateDp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.departureDateDp.Location = new System.Drawing.Point(282, 82);
            this.departureDateDp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.departureDateDp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.departureDateDp.Name = "departureDateDp";
            this.departureDateDp.Size = new System.Drawing.Size(320, 50);
            this.departureDateDp.TabIndex = 27;
            this.departureDateDp.Value = new System.DateTime(2024, 2, 13, 20, 45, 59, 316);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 47);
            this.label7.TabIndex = 25;
            this.label7.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(193, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Trip Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "Departure date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 47);
            this.label2.TabIndex = 16;
            this.label2.Text = "Arrival date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 47);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 58);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add New Trip";
            // 
            // UCAddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.destinationSearchPanel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCAddTrip";
            this.Size = new System.Drawing.Size(1286, 968);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.destinationSearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox priceTb;
        private Guna.UI2.WinForms.Guna2TextBox destinationTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker arrivalDataDp;
        private Guna.UI2.WinForms.Guna2DateTimePicker departureDateDp;
        private Guna.UI2.WinForms.Guna2Panel destinationSearchPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchDestinationTb;
        private Guna.UI2.WinForms.Guna2DataGridView destinationsDgv;
        private Guna.UI2.WinForms.Guna2Button addTripBtn;
    }
}
