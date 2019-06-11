namespace Viva
{
    partial class sales_clerk_home
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
            this.tile_place_order = new MetroFramework.Controls.MetroTile();
            this.tile_edit_cus = new MetroFramework.Controls.MetroTile();
            this.tile_reg_customer = new MetroFramework.Controls.MetroTile();
            this.tile_view_cus = new MetroFramework.Controls.MetroTile();
            this.tile_view_garm = new MetroFramework.Controls.MetroTile();
            this.tile_logout = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_place_order
            // 
            this.tile_place_order.ActiveControl = null;
            this.tile_place_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_place_order.Location = new System.Drawing.Point(324, 91);
            this.tile_place_order.Margin = new System.Windows.Forms.Padding(2);
            this.tile_place_order.Name = "tile_place_order";
            this.tile_place_order.Size = new System.Drawing.Size(433, 344);
            this.tile_place_order.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_place_order.TabIndex = 1;
            this.tile_place_order.Text = "Place an Order";
            this.tile_place_order.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tile_place_order.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_place_order.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tile_place_order.UseSelectable = true;
            this.tile_place_order.Click += new System.EventHandler(this.tile_place_order_Click);
            // 
            // tile_edit_cus
            // 
            this.tile_edit_cus.ActiveControl = null;
            this.tile_edit_cus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_edit_cus.AutoSize = true;
            this.tile_edit_cus.Location = new System.Drawing.Point(108, 311);
            this.tile_edit_cus.Margin = new System.Windows.Forms.Padding(2);
            this.tile_edit_cus.Name = "tile_edit_cus";
            this.tile_edit_cus.Size = new System.Drawing.Size(212, 244);
            this.tile_edit_cus.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_edit_cus.TabIndex = 2;
            this.tile_edit_cus.Text = "Edit Customer";
            this.tile_edit_cus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_edit_cus.UseSelectable = true;
            this.tile_edit_cus.Click += new System.EventHandler(this.tile_edit_cus_Click);
            // 
            // tile_reg_customer
            // 
            this.tile_reg_customer.ActiveControl = null;
            this.tile_reg_customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_reg_customer.Location = new System.Drawing.Point(108, 91);
            this.tile_reg_customer.Margin = new System.Windows.Forms.Padding(2);
            this.tile_reg_customer.Name = "tile_reg_customer";
            this.tile_reg_customer.Size = new System.Drawing.Size(212, 216);
            this.tile_reg_customer.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_reg_customer.TabIndex = 3;
            this.tile_reg_customer.Text = "Register Customer";
            this.tile_reg_customer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_reg_customer.UseSelectable = true;
            this.tile_reg_customer.Click += new System.EventHandler(this.tile_reg_customer_Click);
            // 
            // tile_view_cus
            // 
            this.tile_view_cus.ActiveControl = null;
            this.tile_view_cus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_view_cus.Location = new System.Drawing.Point(762, 91);
            this.tile_view_cus.Name = "tile_view_cus";
            this.tile_view_cus.Size = new System.Drawing.Size(252, 397);
            this.tile_view_cus.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_view_cus.TabIndex = 4;
            this.tile_view_cus.Text = "View Customer";
            this.tile_view_cus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tile_view_cus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_view_cus.UseSelectable = true;
            this.tile_view_cus.Click += new System.EventHandler(this.tile_view_cus_Click);
            // 
            // tile_view_garm
            // 
            this.tile_view_garm.ActiveControl = null;
            this.tile_view_garm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_view_garm.Location = new System.Drawing.Point(325, 440);
            this.tile_view_garm.Name = "tile_view_garm";
            this.tile_view_garm.Size = new System.Drawing.Size(431, 114);
            this.tile_view_garm.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_view_garm.TabIndex = 5;
            this.tile_view_garm.Text = "View Garment";
            this.tile_view_garm.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_view_garm.UseSelectable = true;
            this.tile_view_garm.Click += new System.EventHandler(this.tile_view_garm_Click);
            // 
            // tile_logout
            // 
            this.tile_logout.ActiveControl = null;
            this.tile_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_logout.Location = new System.Drawing.Point(762, 494);
            this.tile_logout.Name = "tile_logout";
            this.tile_logout.Size = new System.Drawing.Size(252, 60);
            this.tile_logout.Style = MetroFramework.MetroColorStyle.Orange;
            this.tile_logout.TabIndex = 6;
            this.tile_logout.Text = "Logout";
            this.tile_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tile_logout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_logout.UseSelectable = true;
            this.tile_logout.Click += new System.EventHandler(this.tile_logout_Click);
            // 
            // sales_clerk_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackImage = global::Viva.Properties.Resources.helena_hertz_256396_unsplash;
            this.BackMaxSize = 2000;
            this.ClientSize = new System.Drawing.Size(1068, 642);
            this.Controls.Add(this.tile_logout);
            this.Controls.Add(this.tile_view_garm);
            this.Controls.Add(this.tile_view_cus);
            this.Controls.Add(this.tile_reg_customer);
            this.Controls.Add(this.tile_edit_cus);
            this.Controls.Add(this.tile_place_order);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sales_clerk_home";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sales_clerk_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile tile_place_order;
        private MetroFramework.Controls.MetroTile tile_edit_cus;
        private MetroFramework.Controls.MetroTile tile_reg_customer;
        private MetroFramework.Controls.MetroTile tile_view_cus;
        private MetroFramework.Controls.MetroTile tile_view_garm;
        private MetroFramework.Controls.MetroTile tile_logout;
    }
}