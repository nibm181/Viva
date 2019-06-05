namespace Viva
{
    partial class editGarment
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
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmb_cat = new MetroFramework.Controls.MetroComboBox();
            this.cmb_type = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_price = new MetroFramework.Controls.MetroTextBox();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_dlt = new MetroFramework.Controls.MetroButton();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(107, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Model ID";
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(204, 94);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(202, 28);
            this.txt_search.TabIndex = 1;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search.Highlight = true;
            this.btn_search.Location = new System.Drawing.Point(459, 94);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 29);
            this.btn_search.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.cmb_cat);
            this.metroPanel1.Controls.Add(this.cmb_type);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txt_price);
            this.metroPanel1.Controls.Add(this.txt_qty);
            this.metroPanel1.Controls.Add(this.txt_name);
            this.metroPanel1.Controls.Add(this.txt_id);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.ForeColor = System.Drawing.Color.Black;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(37, 153);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(728, 296);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmb_cat
            // 
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.ItemHeight = 23;
            this.cmb_cat.Items.AddRange(new object[] {
            "ZARA Basic",
            "Women\'s Sty.",
            "S n G Fashion",
            "S n G Secret"});
            this.cmb_cat.Location = new System.Drawing.Point(165, 116);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(202, 29);
            this.cmb_cat.TabIndex = 10;
            this.cmb_cat.UseSelectable = true;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.ItemHeight = 23;
            this.cmb_type.Items.AddRange(new object[] {
            "Skirt",
            "Blouse",
            "TShirt"});
            this.cmb_type.Location = new System.Drawing.Point(165, 69);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(202, 29);
            this.cmb_type.TabIndex = 10;
            this.cmb_type.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(35, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 25);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Category";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(35, 251);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Price";
            // 
            // txt_price
            // 
            // 
            // 
            // 
            this.txt_price.CustomButton.Image = null;
            this.txt_price.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_price.CustomButton.Name = "";
            this.txt_price.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price.CustomButton.TabIndex = 1;
            this.txt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price.CustomButton.UseSelectable = true;
            this.txt_price.CustomButton.Visible = false;
            this.txt_price.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(165, 248);
            this.txt_price.MaxLength = 32767;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.ShortcutsEnabled = true;
            this.txt_price.Size = new System.Drawing.Size(202, 28);
            this.txt_price.TabIndex = 1;
            this.txt_price.UseSelectable = true;
            this.txt_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(165, 203);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(202, 28);
            this.txt_qty.TabIndex = 1;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(165, 160);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(202, 28);
            this.txt_name.TabIndex = 1;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.CustomButton.Image = null;
            this.txt_id.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_id.CustomButton.Name = "";
            this.txt_id.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id.CustomButton.TabIndex = 1;
            this.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id.CustomButton.UseSelectable = true;
            this.txt_id.CustomButton.Visible = false;
            this.txt_id.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(165, 27);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(202, 28);
            this.txt_id.TabIndex = 1;
            this.txt_id.UseSelectable = true;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(35, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Model ID";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(35, 206);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 25);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Quantity";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(35, 73);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 25);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Type";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(35, 163);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 25);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Name";
            // 
            // btn_update
            // 
            this.btn_update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_update.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_update.Highlight = true;
            this.btn_update.Location = new System.Drawing.Point(392, 481);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(95, 50);
            this.btn_update.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_dlt.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_dlt.Highlight = true;
            this.btn_dlt.Location = new System.Drawing.Point(521, 481);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(95, 50);
            this.btn_dlt.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_dlt.TabIndex = 4;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseSelectable = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_reset.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_reset.Highlight = true;
            this.btn_reset.Location = new System.Drawing.Point(648, 481);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(95, 50);
            this.btn_reset.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseSelectable = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // editGarment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.metroLabel1);
            this.Name = "editGarment";
            this.Text = "Edit Garment";
            this.Load += new System.EventHandler(this.editGarment_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_price;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_dlt;
        private MetroFramework.Controls.MetroButton btn_reset;
        private MetroFramework.Controls.MetroComboBox cmb_cat;
        private MetroFramework.Controls.MetroComboBox cmb_type;
    }
}