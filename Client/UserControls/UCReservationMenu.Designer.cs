namespace Client.UserControls
{
    partial class UCReservationMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchReservationBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.addReservationBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.searchReservationBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addReservationBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 279);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // searchReservationBtn
            // 
            this.searchReservationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchReservationBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchReservationBtn.HoverState.Image = global::Client.Properties.Resources.search1;
            this.searchReservationBtn.HoverState.ImageSize = new System.Drawing.Size(105, 105);
            this.searchReservationBtn.Image = global::Client.Properties.Resources.search;
            this.searchReservationBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchReservationBtn.ImageRotate = 0F;
            this.searchReservationBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.searchReservationBtn.Location = new System.Drawing.Point(388, 39);
            this.searchReservationBtn.Name = "searchReservationBtn";
            this.searchReservationBtn.PressedState.ImageSize = new System.Drawing.Size(95, 95);
            this.searchReservationBtn.Size = new System.Drawing.Size(200, 200);
            this.searchReservationBtn.TabIndex = 8;
            this.searchReservationBtn.UseTransparentBackground = true;
            this.searchReservationBtn.Click += new System.EventHandler(this.subMenuBtnClick);
            // 
            // addReservationBtn
            // 
            this.addReservationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addReservationBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addReservationBtn.HoverState.Image = global::Client.Properties.Resources.add1;
            this.addReservationBtn.HoverState.ImageSize = new System.Drawing.Size(105, 105);
            this.addReservationBtn.Image = global::Client.Properties.Resources.add;
            this.addReservationBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addReservationBtn.ImageRotate = 0F;
            this.addReservationBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.addReservationBtn.Location = new System.Drawing.Point(62, 39);
            this.addReservationBtn.Name = "addReservationBtn";
            this.addReservationBtn.PressedState.ImageSize = new System.Drawing.Size(95, 95);
            this.addReservationBtn.Size = new System.Drawing.Size(200, 200);
            this.addReservationBtn.TabIndex = 7;
            this.addReservationBtn.UseTransparentBackground = true;
            this.addReservationBtn.Click += new System.EventHandler(this.subMenuBtnClick);
            // 
            // UCReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCReservationMenu";
            this.Size = new System.Drawing.Size(1286, 968);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton searchReservationBtn;
        private Guna.UI2.WinForms.Guna2ImageButton addReservationBtn;
    }
}
