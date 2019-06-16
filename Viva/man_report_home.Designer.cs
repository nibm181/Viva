namespace Viva
{
    partial class man_report_home
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tile_saleso_rep = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(227, 114);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(357, 69);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Garment Stock Report";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(227, 194);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(357, 69);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Marterial Stock Report";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tile_saleso_rep
            // 
            this.tile_saleso_rep.ActiveControl = null;
            this.tile_saleso_rep.Location = new System.Drawing.Point(227, 274);
            this.tile_saleso_rep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tile_saleso_rep.Name = "tile_saleso_rep";
            this.tile_saleso_rep.Size = new System.Drawing.Size(357, 69);
            this.tile_saleso_rep.Style = MetroFramework.MetroColorStyle.Red;
            this.tile_saleso_rep.TabIndex = 2;
            this.tile_saleso_rep.Text = "Sales Order Report";
            this.tile_saleso_rep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_saleso_rep.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_saleso_rep.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tile_saleso_rep.UseSelectable = true;
            this.tile_saleso_rep.Click += new System.EventHandler(this.tile_saleso_rep_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(227, 362);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(357, 60);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Material Used Report";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // man_report_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 609);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.tile_saleso_rep);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "man_report_home";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Report Home";
            this.Load += new System.EventHandler(this.man_report_home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile tile_saleso_rep;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}