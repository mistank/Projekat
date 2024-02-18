namespace Client.UserControls
{
    partial class UCTripMenu
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
            this.searchTripBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.addTripBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.searchTripBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addTripBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 279);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // searchTripBtn
            // 
            this.searchTripBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTripBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchTripBtn.HoverState.Image = global::Client.Properties.Resources.search1;
            this.searchTripBtn.HoverState.ImageSize = new System.Drawing.Size(105, 105);
            this.searchTripBtn.Image = global::Client.Properties.Resources.search;
            this.searchTripBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchTripBtn.ImageRotate = 0F;
            this.searchTripBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.searchTripBtn.Location = new System.Drawing.Point(388, 39);
            this.searchTripBtn.Name = "searchTripBtn";
            this.searchTripBtn.PressedState.ImageSize = new System.Drawing.Size(95, 95);
            this.searchTripBtn.Size = new System.Drawing.Size(200, 200);
            this.searchTripBtn.TabIndex = 8;
            this.searchTripBtn.UseTransparentBackground = true;
            this.searchTripBtn.Click += new System.EventHandler(this.subMenuBtnClick);
            // 
            // addTripBtn
            // 
            this.addTripBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTripBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addTripBtn.HoverState.Image = global::Client.Properties.Resources.add1;
            this.addTripBtn.HoverState.ImageSize = new System.Drawing.Size(105, 105);
            this.addTripBtn.Image = global::Client.Properties.Resources.add;
            this.addTripBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addTripBtn.ImageRotate = 0F;
            this.addTripBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.addTripBtn.Location = new System.Drawing.Point(62, 39);
            this.addTripBtn.Name = "addTripBtn";
            this.addTripBtn.PressedState.ImageSize = new System.Drawing.Size(95, 95);
            this.addTripBtn.Size = new System.Drawing.Size(200, 200);
            this.addTripBtn.TabIndex = 7;
            this.addTripBtn.UseTransparentBackground = true;
            this.addTripBtn.Click += new System.EventHandler(this.subMenuBtnClick);
            // 
            // UCTripMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCTripMenu";
            this.Size = new System.Drawing.Size(1286, 968);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton searchTripBtn;
        private Guna.UI2.WinForms.Guna2ImageButton addTripBtn;
    }
}
