namespace Viva
{
    partial class stock_admin_home
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
            this.tile_add_mtrl = new MetroFramework.Controls.MetroTile();
            this.tile_update_mtrl_length = new MetroFramework.Controls.MetroTile();
            this.tile_chk_mat = new MetroFramework.Controls.MetroTile();
            this.tile_add_gar = new MetroFramework.Controls.MetroTile();
            this.tile_edit_gar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_add_mtrl
            // 
            this.tile_add_mtrl.ActiveControl = null;
            this.tile_add_mtrl.Location = new System.Drawing.Point(266, 72);
            this.tile_add_mtrl.Name = "tile_add_mtrl";
            this.tile_add_mtrl.Size = new System.Drawing.Size(190, 384);
            this.tile_add_mtrl.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_add_mtrl.TabIndex = 0;
            this.tile_add_mtrl.Text = "Add Material Stock";
            this.tile_add_mtrl.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tile_add_mtrl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tile_add_mtrl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_add_mtrl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tile_add_mtrl.UseSelectable = true;
            this.tile_add_mtrl.Click += new System.EventHandler(this.tile_add_mtrl_Click);
            // 
            // tile_update_mtrl_length
            // 
            this.tile_update_mtrl_length.ActiveControl = null;
            this.tile_update_mtrl_length.Location = new System.Drawing.Point(686, 212);
            this.tile_update_mtrl_length.Name = "tile_update_mtrl_length";
            this.tile_update_mtrl_length.Size = new System.Drawing.Size(429, 103);
            this.tile_update_mtrl_length.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_update_mtrl_length.TabIndex = 0;
            this.tile_update_mtrl_length.Text = "Update Material";
            this.tile_update_mtrl_length.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tile_update_mtrl_length.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tile_update_mtrl_length.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_update_mtrl_length.UseSelectable = true;
            this.tile_update_mtrl_length.Click += new System.EventHandler(this.tile_update_mtrl_length_Click);
            // 
            // tile_chk_mat
            // 
            this.tile_chk_mat.ActiveControl = null;
            this.tile_chk_mat.Location = new System.Drawing.Point(686, 72);
            this.tile_chk_mat.Name = "tile_chk_mat";
            this.tile_chk_mat.Size = new System.Drawing.Size(265, 134);
            this.tile_chk_mat.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_chk_mat.TabIndex = 0;
            this.tile_chk_mat.Text = "Check/Search Material";
            this.tile_chk_mat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tile_chk_mat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tile_chk_mat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_chk_mat.UseSelectable = true;
            this.tile_chk_mat.Click += new System.EventHandler(this.tile_chk_mat_Click);
            // 
            // tile_add_gar
            // 
            this.tile_add_gar.ActiveControl = null;
            this.tile_add_gar.Location = new System.Drawing.Point(462, 72);
            this.tile_add_gar.Name = "tile_add_gar";
            this.tile_add_gar.Size = new System.Drawing.Size(218, 384);
            this.tile_add_gar.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_add_gar.TabIndex = 0;
            this.tile_add_gar.Text = "Add Garment Stock";
            this.tile_add_gar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tile_add_gar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tile_add_gar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_add_gar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tile_add_gar.UseSelectable = true;
            this.tile_add_gar.Click += new System.EventHandler(this.tile_add_gar_Click);
            // 
            // tile_edit_gar
            // 
            this.tile_edit_gar.ActiveControl = null;
            this.tile_edit_gar.Location = new System.Drawing.Point(686, 321);
            this.tile_edit_gar.Name = "tile_edit_gar";
            this.tile_edit_gar.Size = new System.Drawing.Size(361, 135);
            this.tile_edit_gar.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_edit_gar.TabIndex = 1;
            this.tile_edit_gar.Text = "Edit Garment";
            this.tile_edit_gar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tile_edit_gar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_edit_gar.UseSelectable = true;
            this.tile_edit_gar.Click += new System.EventHandler(this.tile_edit_gar_Click);
            // 
            // stock_admin_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 547);
            this.Controls.Add(this.tile_edit_gar);
            this.Controls.Add(this.tile_add_gar);
            this.Controls.Add(this.tile_chk_mat);
            this.Controls.Add(this.tile_update_mtrl_length);
            this.Controls.Add(this.tile_add_mtrl);
            this.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "stock_admin_home";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.stock_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_add_mtrl;
        private MetroFramework.Controls.MetroTile tile_update_mtrl_length;
        private MetroFramework.Controls.MetroTile tile_chk_mat;
        private MetroFramework.Controls.MetroTile tile_add_gar;
        private MetroFramework.Controls.MetroTile tile_edit_gar;
    }
}