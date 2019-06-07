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
            this.tile_recut = new MetroFramework.Controls.MetroTile();
            this.tile_reg_user = new MetroFramework.Controls.MetroTile();
            this.tile_gen_report = new MetroFramework.Controls.MetroTile();
            this.tile_edit_user = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_recut
            // 
            this.tile_recut.ActiveControl = null;
            this.tile_recut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_recut.AutoSize = true;
            this.tile_recut.Location = new System.Drawing.Point(416, 106);
            this.tile_recut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_recut.Name = "tile_recut";
            this.tile_recut.Size = new System.Drawing.Size(170, 404);
            this.tile_recut.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_recut.TabIndex = 0;
            this.tile_recut.Text = "Re-cut";
            this.tile_recut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tile_recut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_recut.UseSelectable = true;
            this.tile_recut.Click += new System.EventHandler(this.tile_recut_Click);
            // 
            // tile_reg_user
            // 
            this.tile_reg_user.ActiveControl = null;
            this.tile_reg_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_reg_user.AutoSize = true;
            this.tile_reg_user.Location = new System.Drawing.Point(212, 106);
            this.tile_reg_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_reg_user.Name = "tile_reg_user";
            this.tile_reg_user.Size = new System.Drawing.Size(200, 200);
            this.tile_reg_user.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_reg_user.TabIndex = 1;
            this.tile_reg_user.Text = "Register User";
            this.tile_reg_user.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tile_reg_user.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_reg_user.UseSelectable = true;
            this.tile_reg_user.Click += new System.EventHandler(this.tile_reg_user_Click);
            // 
            // tile_gen_report
            // 
            this.tile_gen_report.ActiveControl = null;
            this.tile_gen_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_gen_report.AutoSize = true;
            this.tile_gen_report.Location = new System.Drawing.Point(590, 106);
            this.tile_gen_report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_gen_report.Name = "tile_gen_report";
            this.tile_gen_report.Size = new System.Drawing.Size(200, 200);
            this.tile_gen_report.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_gen_report.TabIndex = 2;
            this.tile_gen_report.Text = "Generate Report";
            this.tile_gen_report.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tile_gen_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_gen_report.UseSelectable = true;
            this.tile_gen_report.Click += new System.EventHandler(this.tile_gen_report_Click);
            // 
            // tile_edit_user
            // 
            this.tile_edit_user.ActiveControl = null;
            this.tile_edit_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tile_edit_user.AutoSize = true;
            this.tile_edit_user.Location = new System.Drawing.Point(212, 310);
            this.tile_edit_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tile_edit_user.Name = "tile_edit_user";
            this.tile_edit_user.Size = new System.Drawing.Size(200, 200);
            this.tile_edit_user.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_edit_user.TabIndex = 3;
            this.tile_edit_user.Text = "Reset User Password";
            this.tile_edit_user.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tile_edit_user.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_edit_user.UseSelectable = true;
            this.tile_edit_user.Click += new System.EventHandler(this.tile_edit_user_Click);
            // 
            // manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tile_edit_user);
            this.Controls.Add(this.tile_gen_report);
            this.Controls.Add(this.tile_reg_user);
            this.Controls.Add(this.tile_recut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "manager_home";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.manager_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_recut;
        private MetroFramework.Controls.MetroTile tile_reg_user;
        private MetroFramework.Controls.MetroTile tile_gen_report;
        private MetroFramework.Controls.MetroTile tile_edit_user;
    }
}