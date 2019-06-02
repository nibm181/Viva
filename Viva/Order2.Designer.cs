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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_place_order = new MetroFramework.Controls.MetroButton();
            this.btn_remove = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_search_id = new MetroFramework.Controls.MetroTextBox();
            this.date_delivery = new MetroFramework.Controls.MetroDateTime();
            this.grid_search_model = new MetroFramework.Controls.MetroGrid();
            this.grid_orders = new MetroFramework.Controls.MetroGrid();
            this.Model_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.txt_order_id = new MetroFramework.Controls.MetroLabel();
            this.txt_cus_id = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_date = new MetroFramework.Controls.MetroLabel();
            this.txt_net_tot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_clear.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_clear.Highlight = true;
            this.btn_clear.Location = new System.Drawing.Point(596, 624);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 50);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_clear.TabIndex = 55;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_back.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_back.Highlight = true;
            this.btn_back.Location = new System.Drawing.Point(47, 624);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 50);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Pink;
            this.btn_back.TabIndex = 54;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_place_order
            // 
            this.btn_place_order.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_place_order.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_place_order.Highlight = true;
            this.btn_place_order.Location = new System.Drawing.Point(474, 624);
            this.btn_place_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.Size = new System.Drawing.Size(95, 50);
            this.btn_place_order.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_place_order.TabIndex = 53;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.UseSelectable = true;
            this.btn_place_order.Click += new System.EventHandler(this.btn_place_order_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Highlight = true;
            this.btn_remove.Location = new System.Drawing.Point(539, 552);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(98, 29);
            this.btn_remove.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_remove.TabIndex = 51;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseSelectable = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Highlight = true;
            this.btn_add.Location = new System.Drawing.Point(441, 363);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 29);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "ADD";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(47, 370);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 25);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Quantity";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(47, 172);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(134, 25);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Model ID/Name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(47, 137);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(113, 25);
            this.metroLabel8.TabIndex = 44;
            this.metroLabel8.Text = "Delivery Date";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(234, 77);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(106, 19);
            this.metroLabel9.TabIndex = 43;
            this.metroLabel9.Text = "Customer Name";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 77);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Order ID";
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_qty.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(188, 363);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(202, 28);
            this.txt_qty.TabIndex = 38;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_search_id
            // 
            // 
            // 
            // 
            this.txt_search_id.CustomButton.Image = null;
            this.txt_search_id.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txt_search_id.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search_id.CustomButton.Name = "";
            this.txt_search_id.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_search_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search_id.CustomButton.TabIndex = 1;
            this.txt_search_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search_id.CustomButton.UseSelectable = true;
            this.txt_search_id.CustomButton.Visible = false;
            this.txt_search_id.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_search_id.Lines = new string[0];
            this.txt_search_id.Location = new System.Drawing.Point(188, 169);
            this.txt_search_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search_id.MaxLength = 32767;
            this.txt_search_id.Name = "txt_search_id";
            this.txt_search_id.PasswordChar = '\0';
            this.txt_search_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search_id.SelectedText = "";
            this.txt_search_id.SelectionLength = 0;
            this.txt_search_id.SelectionStart = 0;
            this.txt_search_id.ShortcutsEnabled = true;
            this.txt_search_id.Size = new System.Drawing.Size(202, 28);
            this.txt_search_id.TabIndex = 35;
            this.txt_search_id.UseSelectable = true;
            this.txt_search_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date_delivery
            // 
            this.date_delivery.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.date_delivery.Location = new System.Drawing.Point(188, 133);
            this.date_delivery.Margin = new System.Windows.Forms.Padding(2);
            this.date_delivery.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Size = new System.Drawing.Size(202, 29);
            this.date_delivery.TabIndex = 57;
            // 
            // grid_search_model
            // 
            this.grid_search_model.AllowUserToAddRows = false;
            this.grid_search_model.AllowUserToResizeRows = false;
            this.grid_search_model.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_search_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_search_model.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_search_model.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search_model.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_search_model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_search_model.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_search_model.EnableHeadersVisualStyles = false;
            this.grid_search_model.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_search_model.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_search_model.Location = new System.Drawing.Point(47, 205);
            this.grid_search_model.Margin = new System.Windows.Forms.Padding(2);
            this.grid_search_model.Name = "grid_search_model";
            this.grid_search_model.ReadOnly = true;
            this.grid_search_model.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search_model.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_search_model.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_search_model.RowTemplate.Height = 24;
            this.grid_search_model.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_search_model.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_search_model.Size = new System.Drawing.Size(647, 150);
            this.grid_search_model.Style = MetroFramework.MetroColorStyle.Silver;
            this.grid_search_model.TabIndex = 58;
            this.grid_search_model.UseCustomForeColor = true;
            // 
            // grid_orders
            // 
            this.grid_orders.AllowUserToResizeRows = false;
            this.grid_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model_ID,
            this.Model_name,
            this.QTY,
            this.tot_price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_orders.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_orders.EnableHeadersVisualStyles = false;
            this.grid_orders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_orders.Location = new System.Drawing.Point(47, 429);
            this.grid_orders.Margin = new System.Windows.Forms.Padding(2);
            this.grid_orders.Name = "grid_orders";
            this.grid_orders.ReadOnly = true;
            this.grid_orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_orders.RowTemplate.Height = 24;
            this.grid_orders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_orders.Size = new System.Drawing.Size(452, 112);
            this.grid_orders.Style = MetroFramework.MetroColorStyle.Green;
            this.grid_orders.TabIndex = 58;
            this.grid_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_orders_CellContentClick);
            // 
            // Model_ID
            // 
            this.Model_ID.DividerWidth = 1;
            this.Model_ID.HeaderText = "Model ID";
            this.Model_ID.Name = "Model_ID";
            this.Model_ID.ReadOnly = true;
            // 
            // Model_name
            // 
            this.Model_name.DividerWidth = 1;
            this.Model_name.HeaderText = "Name";
            this.Model_name.Name = "Model_name";
            this.Model_name.ReadOnly = true;
            this.Model_name.Width = 150;
            // 
            // QTY
            // 
            this.QTY.DividerWidth = 1;
            this.QTY.HeaderText = "Quantity";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 70;
            // 
            // tot_price
            // 
            this.tot_price.DividerWidth = 1;
            this.tot_price.HeaderText = "Total Price";
            this.tot_price.Name = "tot_price";
            this.tot_price.ReadOnly = true;
            // 
            // btn_search
            // 
            this.btn_search.Highlight = true;
            this.btn_search.Location = new System.Drawing.Point(441, 168);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 29);
            this.btn_search.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_search.TabIndex = 50;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_order_id
            // 
            this.txt_order_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_order_id.Enabled = false;
            this.txt_order_id.Location = new System.Drawing.Point(111, 77);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.Size = new System.Drawing.Size(70, 19);
            this.txt_order_id.TabIndex = 59;
            this.txt_order_id.Text = "asd";
            // 
            // txt_cus_id
            // 
            this.txt_cus_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_cus_id.Location = new System.Drawing.Point(346, 77);
            this.txt_cus_id.Name = "txt_cus_id";
            this.txt_cus_id.Size = new System.Drawing.Size(96, 19);
            this.txt_cus_id.TabIndex = 60;
            this.txt_cus_id.Text = "ab";
            this.txt_cus_id.Click += new System.EventHandler(this.txt_cus_id_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(497, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Date";
            // 
            // lbl_date
            // 
            this.lbl_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_date.Enabled = false;
            this.lbl_date.Location = new System.Drawing.Point(539, 77);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(151, 19);
            this.lbl_date.TabIndex = 62;
            this.lbl_date.Text = "123";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // txt_net_tot
            // 
            // 
            // 
            // 
            this.txt_net_tot.CustomButton.Image = null;
            this.txt_net_tot.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txt_net_tot.CustomButton.Name = "";
            this.txt_net_tot.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_net_tot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_net_tot.CustomButton.TabIndex = 1;
            this.txt_net_tot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_net_tot.CustomButton.UseSelectable = true;
            this.txt_net_tot.CustomButton.Visible = false;
            this.txt_net_tot.Enabled = false;
            this.txt_net_tot.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_net_tot.Lines = new string[0];
            this.txt_net_tot.Location = new System.Drawing.Point(407, 552);
            this.txt_net_tot.MaxLength = 32767;
            this.txt_net_tot.Name = "txt_net_tot";
            this.txt_net_tot.PasswordChar = '\0';
            this.txt_net_tot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_net_tot.SelectedText = "";
            this.txt_net_tot.SelectionLength = 0;
            this.txt_net_tot.SelectionStart = 0;
            this.txt_net_tot.ShortcutsEnabled = true;
            this.txt_net_tot.Size = new System.Drawing.Size(92, 28);
            this.txt_net_tot.TabIndex = 63;
            this.txt_net_tot.UseSelectable = true;
            this.txt_net_tot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_net_tot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(303, 555);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 25);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Grand Total";
            // 
            // Order2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 699);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_net_tot);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_cus_id);
            this.Controls.Add(this.txt_order_id);
            this.Controls.Add(this.grid_orders);
            this.Controls.Add(this.grid_search_model);
            this.Controls.Add(this.date_delivery);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_place_order);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_search_id);
            this.Name = "Order2";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_place_order;
        private MetroFramework.Controls.MetroButton btn_remove;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroTextBox txt_search_id;
        private MetroFramework.Controls.MetroDateTime date_delivery;
        private MetroFramework.Controls.MetroGrid grid_search_model;
        private MetroFramework.Controls.MetroGrid grid_orders;
        private MetroFramework.Controls.MetroButton btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_price;
        private MetroFramework.Controls.MetroLabel txt_order_id;
        private MetroFramework.Controls.MetroLabel txt_cus_id;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbl_date;
        private MetroFramework.Controls.MetroTextBox txt_net_tot;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}