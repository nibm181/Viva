namespace Viva
{
    partial class Order2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_orderNo = new MetroFramework.Controls.MetroTextBox();
            this.date_current = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.date_delivery = new MetroFramework.Controls.MetroDateTime();
            this.txt_cus_no = new MetroFramework.Controls.MetroTextBox();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.grid_search = new MetroFramework.Controls.MetroGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.txt_add = new MetroFramework.Controls.MetroButton();
            this.grid_order = new MetroFramework.Controls.MetroGrid();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_place = new MetroFramework.Controls.MetroButton();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(52, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Order No";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(52, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Customer No";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(451, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Date";
            // 
            // txt_orderNo
            // 
            // 
            // 
            // 
            this.txt_orderNo.CustomButton.Image = null;
            this.txt_orderNo.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_orderNo.CustomButton.Name = "";
            this.txt_orderNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_orderNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_orderNo.CustomButton.TabIndex = 1;
            this.txt_orderNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_orderNo.CustomButton.UseSelectable = true;
            this.txt_orderNo.CustomButton.Visible = false;
            this.txt_orderNo.Lines = new string[0];
            this.txt_orderNo.Location = new System.Drawing.Point(181, 85);
            this.txt_orderNo.MaxLength = 32767;
            this.txt_orderNo.Name = "txt_orderNo";
            this.txt_orderNo.PasswordChar = '\0';
            this.txt_orderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_orderNo.SelectedText = "";
            this.txt_orderNo.SelectionLength = 0;
            this.txt_orderNo.SelectionStart = 0;
            this.txt_orderNo.ShortcutsEnabled = true;
            this.txt_orderNo.Size = new System.Drawing.Size(202, 28);
            this.txt_orderNo.TabIndex = 1;
            this.txt_orderNo.UseSelectable = true;
            this.txt_orderNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_orderNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date_current
            // 
            this.date_current.Enabled = false;
            this.date_current.Location = new System.Drawing.Point(580, 84);
            this.date_current.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_current.Name = "date_current";
            this.date_current.Size = new System.Drawing.Size(200, 29);
            this.date_current.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(451, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 25);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Delivery Date";
            // 
            // date_delivery
            // 
            this.date_delivery.Location = new System.Drawing.Point(580, 123);
            this.date_delivery.MinDate = new System.DateTime(2019, 4, 18, 0, 0, 0, 0);
            this.date_delivery.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Size = new System.Drawing.Size(200, 29);
            this.date_delivery.TabIndex = 2;
            // 
            // txt_cus_no
            // 
            // 
            // 
            // 
            this.txt_cus_no.CustomButton.Image = null;
            this.txt_cus_no.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_cus_no.CustomButton.Name = "";
            this.txt_cus_no.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_cus_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cus_no.CustomButton.TabIndex = 1;
            this.txt_cus_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cus_no.CustomButton.UseSelectable = true;
            this.txt_cus_no.CustomButton.Visible = false;
            this.txt_cus_no.Lines = new string[0];
            this.txt_cus_no.Location = new System.Drawing.Point(181, 124);
            this.txt_cus_no.MaxLength = 32767;
            this.txt_cus_no.Name = "txt_cus_no";
            this.txt_cus_no.PasswordChar = '\0';
            this.txt_cus_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cus_no.SelectedText = "";
            this.txt_cus_no.SelectionLength = 0;
            this.txt_cus_no.SelectionStart = 0;
            this.txt_cus_no.ShortcutsEnabled = true;
            this.txt_cus_no.Size = new System.Drawing.Size(202, 28);
            this.txt_cus_no.TabIndex = 1;
            this.txt_cus_no.UseSelectable = true;
            this.txt_cus_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cus_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(181, 185);
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(52, 188);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 25);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Model ID";
            // 
            // btn_search
            // 
            this.btn_search.Highlight = true;
            this.btn_search.Location = new System.Drawing.Point(451, 190);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 29);
            this.btn_search.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            // 
            // grid_search
            // 
            this.grid_search.AllowUserToResizeRows = false;
            this.grid_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_search.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_search.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_search.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid_search.EnableHeadersVisualStyles = false;
            this.grid_search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_search.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_search.Location = new System.Drawing.Point(52, 235);
            this.grid_search.Name = "grid_search";
            this.grid_search.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grid_search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_search.Size = new System.Drawing.Size(727, 130);
            this.grid_search.TabIndex = 4;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(52, 397);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 25);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Quantity";
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
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(181, 394);
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(451, 397);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 25);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Amount";
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(580, 394);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(202, 28);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_add
            // 
            this.txt_add.Highlight = true;
            this.txt_add.Location = new System.Drawing.Point(682, 437);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(98, 29);
            this.txt_add.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_add.TabIndex = 3;
            this.txt_add.Text = "Add";
            this.txt_add.UseSelectable = true;
            // 
            // grid_order
            // 
            this.grid_order.AllowUserToResizeRows = false;
            this.grid_order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order.DefaultCellStyle = dataGridViewCellStyle17;
            this.grid_order.EnableHeadersVisualStyles = false;
            this.grid_order.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order.Location = new System.Drawing.Point(52, 484);
            this.grid_order.Name = "grid_order";
            this.grid_order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grid_order.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order.Size = new System.Drawing.Size(727, 154);
            this.grid_order.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_back.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_back.Highlight = true;
            this.btn_back.Location = new System.Drawing.Point(52, 666);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 50);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            // 
            // btn_place
            // 
            this.btn_place.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_place.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_place.Highlight = true;
            this.btn_place.Location = new System.Drawing.Point(546, 666);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(95, 50);
            this.btn_place.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_place.TabIndex = 5;
            this.btn_place.Text = "Place Order";
            this.btn_place.UseSelectable = true;
            // 
            // btn_reset
            // 
            this.btn_reset.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_reset.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_reset.Highlight = true;
            this.btn_reset.Location = new System.Drawing.Point(687, 666);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(95, 50);
            this.btn_reset.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseSelectable = true;
            // 
            // Order2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 737);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_place);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grid_order);
            this.Controls.Add(this.grid_search);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.date_delivery);
            this.Controls.Add(this.date_current);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_cus_no);
            this.Controls.Add(this.txt_orderNo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Order2";
            this.Text = "Order2";
            this.Load += new System.EventHandler(this.Order2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_orderNo;
        private MetroFramework.Controls.MetroDateTime date_current;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime date_delivery;
        private MetroFramework.Controls.MetroTextBox txt_cus_no;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroGrid grid_search;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private MetroFramework.Controls.MetroButton txt_add;
        private MetroFramework.Controls.MetroGrid grid_order;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_place;
        private MetroFramework.Controls.MetroButton btn_reset;
    }
}