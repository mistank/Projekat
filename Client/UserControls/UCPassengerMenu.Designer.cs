namespace Client.UserControls
{
    partial class UCPassengerMenu
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.addPassengerBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searchPassengerBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.searchPassengerBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addPassengerBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 279);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool1.TargetControl = null;
            // 
            // addPassengerBtn
            // 
            this.addPassengerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPassengerBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addPassengerBtn.HoverState.Image = global::Client.Properties.Resources.add1;
            this.addPassengerBtn.HoverState.ImageSize = new System.Drawing.Size(105, 105);
            this.addPassengerBtn.Image = global::Client.Properties.Resources.add;
            this.addPassengerBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addPassengerBtn.ImageRotate = 0F;
            this.addPassengerBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.addPassengerBtn.Location = new System.Drawing.Point(62, 39);
            this.addPassengerBtn.Name = "addPassengerBtn";
            this.addPassengerBtn.PressedState.ImageSize = new System.Drawing.Size(95, 95);
            this.addPassengerBtn.Size = new System.Drawing.Size(200, 200);
            this.addPassengerBtn.TabIndex = 7;
            this.addPassengerBtn.UseTransparentBackground = true;
            this.addPassengerBtn.Click += new System.EventHandler(this.subMenuBtnClick);
            // 
            // searchPassengerBtn
            // 
            this.searchPassengerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchPassengerBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchPassengerBtn.HoverState.Image = global::Client.Properties.Resources.search1;
            this.searchPassengerBtn.HoverState.ImageSize = new System.Drawing.Size(105, 105);
            this.searchPassengerBtn.Image = global::Client.Properties.Resources.search;
            this.searchPassengerBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchPassengerBtn.ImageRotate = 0F;
            this.searchPassengerBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.searchPassengerBtn.Location = new System.Drawing.Point(388, 39);
            this.searchPassengerBtn.Name = "searchPassengerBtn";
            this.searchPassengerBtn.PressedState.ImageSize = new System.Drawing.Size(95, 95);
            this.searchPassengerBtn.Size = new System.Drawing.Size(200, 200);
            this.searchPassengerBtn.TabIndex = 8;
            this.searchPassengerBtn.UseTransparentBackground = true;
            this.searchPassengerBtn.Click += new System.EventHandler(this.subMenuBtnClick);
            // 
            // UCPassengerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCPassengerMenu";
            this.Size = new System.Drawing.Size(1286, 968);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private Guna.UI2.WinForms.Guna2ImageButton addPassengerBtn;
        private Guna.UI2.WinForms.Guna2ImageButton searchPassengerBtn;
    }
}
