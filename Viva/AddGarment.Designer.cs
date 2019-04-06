namespace Viva
{
    partial class AddGarment
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_gno = new MetroFramework.Controls.MetroTextBox();
            this.txt_gname = new MetroFramework.Controls.MetroTextBox();
            this.txt_gqty = new MetroFramework.Controls.MetroTextBox();
            this.txt_gprice = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Garment No";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(65, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(65, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Type";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(65, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Quantity";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(65, 244);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Price";
            // 
            // txt_gno
            // 
            // 
            // 
            // 
            this.txt_gno.CustomButton.Image = null;
            this.txt_gno.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_gno.CustomButton.Name = "";
            this.txt_gno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gno.CustomButton.TabIndex = 1;
            this.txt_gno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gno.CustomButton.UseSelectable = true;
            this.txt_gno.CustomButton.Visible = false;
            this.txt_gno.Lines = new string[0];
            this.txt_gno.Location = new System.Drawing.Point(186, 91);
            this.txt_gno.MaxLength = 32767;
            this.txt_gno.Name = "txt_gno";
            this.txt_gno.PasswordChar = '\0';
            this.txt_gno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gno.SelectedText = "";
            this.txt_gno.SelectionLength = 0;
            this.txt_gno.SelectionStart = 0;
            this.txt_gno.ShortcutsEnabled = true;
            this.txt_gno.Size = new System.Drawing.Size(153, 23);
            this.txt_gno.TabIndex = 1;
            this.txt_gno.UseSelectable = true;
            this.txt_gno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_gname
            // 
            // 
            // 
            // 
            this.txt_gname.CustomButton.Image = null;
            this.txt_gname.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_gname.CustomButton.Name = "";
            this.txt_gname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gname.CustomButton.TabIndex = 1;
            this.txt_gname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gname.CustomButton.UseSelectable = true;
            this.txt_gname.CustomButton.Visible = false;
            this.txt_gname.Lines = new string[0];
            this.txt_gname.Location = new System.Drawing.Point(186, 128);
            this.txt_gname.MaxLength = 32767;
            this.txt_gname.Name = "txt_gname";
            this.txt_gname.PasswordChar = '\0';
            this.txt_gname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gname.SelectedText = "";
            this.txt_gname.SelectionLength = 0;
            this.txt_gname.SelectionStart = 0;
            this.txt_gname.ShortcutsEnabled = true;
            this.txt_gname.Size = new System.Drawing.Size(153, 23);
            this.txt_gname.TabIndex = 1;
            this.txt_gname.UseSelectable = true;
            this.txt_gname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_gqty
            // 
            // 
            // 
            // 
            this.txt_gqty.CustomButton.Image = null;
            this.txt_gqty.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_gqty.CustomButton.Name = "";
            this.txt_gqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gqty.CustomButton.TabIndex = 1;
            this.txt_gqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gqty.CustomButton.UseSelectable = true;
            this.txt_gqty.CustomButton.Visible = false;
            this.txt_gqty.Lines = new string[0];
            this.txt_gqty.Location = new System.Drawing.Point(186, 203);
            this.txt_gqty.MaxLength = 32767;
            this.txt_gqty.Name = "txt_gqty";
            this.txt_gqty.PasswordChar = '\0';
            this.txt_gqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gqty.SelectedText = "";
            this.txt_gqty.SelectionLength = 0;
            this.txt_gqty.SelectionStart = 0;
            this.txt_gqty.ShortcutsEnabled = true;
            this.txt_gqty.Size = new System.Drawing.Size(153, 23);
            this.txt_gqty.TabIndex = 1;
            this.txt_gqty.UseSelectable = true;
            this.txt_gqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_gprice
            // 
            // 
            // 
            // 
            this.txt_gprice.CustomButton.Image = null;
            this.txt_gprice.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_gprice.CustomButton.Name = "";
            this.txt_gprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gprice.CustomButton.TabIndex = 1;
            this.txt_gprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gprice.CustomButton.UseSelectable = true;
            this.txt_gprice.CustomButton.Visible = false;
            this.txt_gprice.Lines = new string[0];
            this.txt_gprice.Location = new System.Drawing.Point(186, 240);
            this.txt_gprice.MaxLength = 32767;
            this.txt_gprice.Name = "txt_gprice";
            this.txt_gprice.PasswordChar = '\0';
            this.txt_gprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gprice.SelectedText = "";
            this.txt_gprice.SelectionLength = 0;
            this.txt_gprice.SelectionStart = 0;
            this.txt_gprice.ShortcutsEnabled = true;
            this.txt_gprice.Size = new System.Drawing.Size(153, 23);
            this.txt_gprice.TabIndex = 1;
            this.txt_gprice.UseSelectable = true;
            this.txt_gprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(186, 160);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(153, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // AddGarment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.txt_gprice);
            this.Controls.Add(this.txt_gqty);
            this.Controls.Add(this.txt_gname);
            this.Controls.Add(this.txt_gno);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddGarment";
            this.Text = "Add Garment";
            this.Load += new System.EventHandler(this.AddGarment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_gno;
        private MetroFramework.Controls.MetroTextBox txt_gname;
        private MetroFramework.Controls.MetroTextBox txt_gqty;
        private MetroFramework.Controls.MetroTextBox txt_gprice;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}