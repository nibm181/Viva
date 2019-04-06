namespace Viva
{
    partial class form_login
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
            this.txt_Uname = new MetroFramework.Controls.MetroTextBox();
            this.txt_Pword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(873, 398);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "User Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(888, 468);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txt_Uname
            // 
            // 
            // 
            // 
            this.txt_Uname.CustomButton.Image = null;
            this.txt_Uname.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.txt_Uname.CustomButton.Name = "";
            this.txt_Uname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Uname.CustomButton.TabIndex = 1;
            this.txt_Uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Uname.CustomButton.UseSelectable = true;
            this.txt_Uname.CustomButton.Visible = false;
            this.txt_Uname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Uname.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_Uname.Lines = new string[0];
            this.txt_Uname.Location = new System.Drawing.Point(991, 391);
            this.txt_Uname.MaxLength = 32767;
            this.txt_Uname.Multiline = true;
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.PasswordChar = '\0';
            this.txt_Uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Uname.SelectedText = "";
            this.txt_Uname.SelectionLength = 0;
            this.txt_Uname.SelectionStart = 0;
            this.txt_Uname.ShortcutsEnabled = true;
            this.txt_Uname.Size = new System.Drawing.Size(184, 32);
            this.txt_Uname.TabIndex = 1;
            this.txt_Uname.UseSelectable = true;
            this.txt_Uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Pword
            // 
            // 
            // 
            // 
            this.txt_Pword.CustomButton.Image = null;
            this.txt_Pword.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.txt_Pword.CustomButton.Name = "";
            this.txt_Pword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Pword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pword.CustomButton.TabIndex = 1;
            this.txt_Pword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pword.CustomButton.UseSelectable = true;
            this.txt_Pword.CustomButton.Visible = false;
            this.txt_Pword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Pword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_Pword.Lines = new string[0];
            this.txt_Pword.Location = new System.Drawing.Point(991, 461);
            this.txt_Pword.MaxLength = 32767;
            this.txt_Pword.Multiline = true;
            this.txt_Pword.Name = "txt_Pword";
            this.txt_Pword.PasswordChar = '\0';
            this.txt_Pword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pword.SelectedText = "";
            this.txt_Pword.SelectionLength = 0;
            this.txt_Pword.SelectionStart = 0;
            this.txt_Pword.ShortcutsEnabled = true;
            this.txt_Pword.Size = new System.Drawing.Size(184, 32);
            this.txt_Pword.TabIndex = 1;
            this.txt_Pword.UseSelectable = true;
            this.txt_Pword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Pword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Viva.Properties.Resources.section_3;
            this.BackImage = global::Viva.Properties.Resources.section_3;
            this.BackMaxSize = 1300;
            this.ClientSize = new System.Drawing.Size(1235, 583);
            this.Controls.Add(this.txt_Pword);
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_login";
            this.Padding = new System.Windows.Forms.Padding(19, 60, 19, 20);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_Uname;
        private MetroFramework.Controls.MetroTextBox txt_Pword;
    }
}

