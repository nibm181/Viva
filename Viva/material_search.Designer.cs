namespace Viva
{
    partial class material_search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_ms__search = new MetroFramework.Controls.MetroTextBox();
            this.btn_ms__search = new MetroFramework.Controls.MetroButton();
            this.grd_mat_search = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mat_search)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ms__search
            // 
            // 
            // 
            // 
            this.txt_ms__search.CustomButton.Image = null;
            this.txt_ms__search.CustomButton.Location = new System.Drawing.Point(316, 2);
            this.txt_ms__search.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ms__search.CustomButton.Name = "";
            this.txt_ms__search.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.txt_ms__search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ms__search.CustomButton.TabIndex = 1;
            this.txt_ms__search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ms__search.CustomButton.UseSelectable = true;
            this.txt_ms__search.CustomButton.Visible = false;
            this.txt_ms__search.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_ms__search.Lines = new string[0];
            this.txt_ms__search.Location = new System.Drawing.Point(239, 124);
            this.txt_ms__search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ms__search.MaxLength = 32767;
            this.txt_ms__search.Multiline = true;
            this.txt_ms__search.Name = "txt_ms__search";
            this.txt_ms__search.PasswordChar = '\0';
            this.txt_ms__search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ms__search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ms__search.SelectedText = "";
            this.txt_ms__search.SelectionLength = 0;
            this.txt_ms__search.SelectionStart = 0;
            this.txt_ms__search.ShortcutsEnabled = true;
            this.txt_ms__search.Size = new System.Drawing.Size(269, 34);
            this.txt_ms__search.TabIndex = 0;
            this.txt_ms__search.UseSelectable = true;
            this.txt_ms__search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ms__search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_ms__search
            // 
            this.btn_ms__search.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_ms__search.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_ms__search.Highlight = true;
            this.btn_ms__search.Location = new System.Drawing.Point(571, 124);
            this.btn_ms__search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ms__search.Name = "btn_ms__search";
            this.btn_ms__search.Size = new System.Drawing.Size(131, 36);
            this.btn_ms__search.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_ms__search.TabIndex = 1;
            this.btn_ms__search.Text = "Search";
            this.btn_ms__search.UseSelectable = true;
            this.btn_ms__search.Click += new System.EventHandler(this.btn_ms__search_Click);
            // 
            // grd_mat_search
            // 
            this.grd_mat_search.AllowUserToAddRows = false;
            this.grd_mat_search.AllowUserToDeleteRows = false;
            this.grd_mat_search.AllowUserToResizeRows = false;
            this.grd_mat_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_mat_search.BackgroundColor = System.Drawing.Color.Silver;
            this.grd_mat_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_mat_search.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_mat_search.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_mat_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_mat_search.ColumnHeadersHeight = 40;
            this.grd_mat_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_mat_search.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_mat_search.EnableHeadersVisualStyles = false;
            this.grd_mat_search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_mat_search.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_mat_search.Location = new System.Drawing.Point(75, 198);
            this.grd_mat_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_mat_search.Name = "grd_mat_search";
            this.grd_mat_search.ReadOnly = true;
            this.grd_mat_search.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_mat_search.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_mat_search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_mat_search.RowTemplate.Height = 24;
            this.grd_mat_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_mat_search.Size = new System.Drawing.Size(971, 448);
            this.grd_mat_search.TabIndex = 2;
            this.grd_mat_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_mat_search_CellContentClick);
            // 
            // material_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 698);
            this.Controls.Add(this.grd_mat_search);
            this.Controls.Add(this.btn_ms__search);
            this.Controls.Add(this.txt_ms__search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "material_search";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Material Search";
            this.Load += new System.EventHandler(this.material_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_mat_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_ms__search;
        private MetroFramework.Controls.MetroButton btn_ms__search;
        private MetroFramework.Controls.MetroGrid grd_mat_search;
    }
}