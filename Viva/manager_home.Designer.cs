namespace Viva
{
    partial class manager_home
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
            this.tile_edit_user = new MetroFramework.Controls.MetroTile();
            this.tile_cus = new MetroFramework.Controls.MetroTile();
            this.tile_recut = new MetroFramework.Controls.MetroTile();
            this.tile_reports = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_edit_user
            // 
            this.tile_edit_user.ActiveControl = null;
            this.tile_edit_user.Location = new System.Drawing.Point(418, 216);
            this.tile_edit_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_edit_user.Name = "tile_edit_user";
            this.tile_edit_user.Size = new System.Drawing.Size(130, 224);
            this.tile_edit_user.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_edit_user.TabIndex = 0;
            this.tile_edit_user.Text = "Edit User \r\nDetails";
            this.tile_edit_user.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_edit_user.UseSelectable = true;
            this.tile_edit_user.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tile_cus
            // 
            this.tile_cus.ActiveControl = null;
            this.tile_cus.Location = new System.Drawing.Point(418, 102);
            this.tile_cus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_cus.Name = "tile_cus";
            this.tile_cus.Size = new System.Drawing.Size(285, 110);
            this.tile_cus.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_cus.TabIndex = 0;
            this.tile_cus.Text = "Register User";
            this.tile_cus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_cus.UseSelectable = true;
            this.tile_cus.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tile_recut
            // 
            this.tile_recut.ActiveControl = null;
            this.tile_recut.Location = new System.Drawing.Point(285, 102);
            this.tile_recut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_recut.Name = "tile_recut";
            this.tile_recut.Size = new System.Drawing.Size(128, 224);
            this.tile_recut.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_recut.TabIndex = 0;
            this.tile_recut.Text = "Re-cut";
            this.tile_recut.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_recut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_recut.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tile_recut.UseSelectable = true;
            this.tile_recut.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tile_reports
            // 
            this.tile_reports.ActiveControl = null;
            this.tile_reports.Location = new System.Drawing.Point(149, 216);
            this.tile_reports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_reports.Name = "tile_reports";
            this.tile_reports.Size = new System.Drawing.Size(131, 110);
            this.tile_reports.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_reports.TabIndex = 0;
            this.tile_reports.Text = "Generate \r\nReports";
            this.tile_reports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_reports.UseSelectable = true;
            this.tile_reports.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 474);
            this.Controls.Add(this.tile_recut);
            this.Controls.Add(this.tile_cus);
            this.Controls.Add(this.tile_edit_user);
            this.Controls.Add(this.tile_reports);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "manager_home";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.manager_home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tile_edit_user;
        private MetroFramework.Controls.MetroTile tile_cus;
        private MetroFramework.Controls.MetroTile tile_recut;
        private MetroFramework.Controls.MetroTile tile_reports;
    }
}