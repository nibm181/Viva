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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_place_order = new MetroFramework.Controls.MetroButton();
            this.btn_remove = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_sys_date = new MetroFramework.Controls.MetroTextBox();
            this.txt_cus_id = new MetroFramework.Controls.MetroTextBox();
            this.txt_search_id = new MetroFramework.Controls.MetroTextBox();
            this.txt_order_id = new MetroFramework.Controls.MetroTextBox();
            this.date_delivery = new MetroFramework.Controls.MetroDateTime();
            this.grid_search_model = new MetroFramework.Controls.MetroGrid();
            this.grid_orders = new MetroFramework.Controls.MetroGrid();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(559, 720);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(107, 50);
            this.btn_exit.TabIndex = 56;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(388, 720);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 50);
            this.btn_clear.TabIndex = 55;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(43, 720);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 50);
            this.btn_back.TabIndex = 54;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_place_order
            // 
            this.btn_place_order.Location = new System.Drawing.Point(217, 720);
            this.btn_place_order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.Size = new System.Drawing.Size(107, 50);
            this.btn_place_order.TabIndex = 53;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.UseSelectable = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(593, 655);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(72, 18);
            this.btn_remove.TabIndex = 51;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseSelectable = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(593, 481);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 18);
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "ADD";
            this.btn_add.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 484);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 20);
            this.metroLabel4.TabIndex = 48;
            this.metroLabel4.Text = "amount";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(49, 446);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 20);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "QTY";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 446);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 20);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "QTY";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(51, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 20);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Model ID/Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(425, 98);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 20);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Date";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(51, 198);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 20);
            this.metroLabel8.TabIndex = 44;
            this.metroLabel8.Text = "Delivery Date";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(53, 143);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(111, 20);
            this.metroLabel9.TabIndex = 43;
            this.metroLabel9.Text = "Customer Name";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 20);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Order ID";
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_amount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(181, 481);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(161, 18);
            this.txt_amount.TabIndex = 39;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_qty.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(181, 444);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(161, 18);
            this.txt_qty.TabIndex = 38;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_sys_date
            // 
            // 
            // 
            // 
            this.txt_sys_date.CustomButton.Image = null;
            this.txt_sys_date.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_sys_date.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sys_date.CustomButton.Name = "";
            this.txt_sys_date.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.txt_sys_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sys_date.CustomButton.TabIndex = 1;
            this.txt_sys_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sys_date.CustomButton.UseSelectable = true;
            this.txt_sys_date.CustomButton.Visible = false;
            this.txt_sys_date.Lines = new string[0];
            this.txt_sys_date.Location = new System.Drawing.Point(507, 98);
            this.txt_sys_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sys_date.MaxLength = 32767;
            this.txt_sys_date.Name = "txt_sys_date";
            this.txt_sys_date.PasswordChar = '\0';
            this.txt_sys_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sys_date.SelectedText = "";
            this.txt_sys_date.SelectionLength = 0;
            this.txt_sys_date.SelectionStart = 0;
            this.txt_sys_date.ShortcutsEnabled = true;
            this.txt_sys_date.Size = new System.Drawing.Size(161, 18);
            this.txt_sys_date.TabIndex = 37;
            this.txt_sys_date.UseSelectable = true;
            this.txt_sys_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sys_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_cus_id
            // 
            // 
            // 
            // 
            this.txt_cus_id.CustomButton.Image = null;
            this.txt_cus_id.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_cus_id.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cus_id.CustomButton.Name = "";
            this.txt_cus_id.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.txt_cus_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cus_id.CustomButton.TabIndex = 1;
            this.txt_cus_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cus_id.CustomButton.UseSelectable = true;
            this.txt_cus_id.CustomButton.Visible = false;
            this.txt_cus_id.Lines = new string[0];
            this.txt_cus_id.Location = new System.Drawing.Point(200, 148);
            this.txt_cus_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cus_id.MaxLength = 32767;
            this.txt_cus_id.Name = "txt_cus_id";
            this.txt_cus_id.PasswordChar = '\0';
            this.txt_cus_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cus_id.SelectedText = "";
            this.txt_cus_id.SelectionLength = 0;
            this.txt_cus_id.SelectionStart = 0;
            this.txt_cus_id.ShortcutsEnabled = true;
            this.txt_cus_id.Size = new System.Drawing.Size(161, 18);
            this.txt_cus_id.TabIndex = 36;
            this.txt_cus_id.UseSelectable = true;
            this.txt_cus_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cus_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_search_id
            // 
            // 
            // 
            // 
            this.txt_search_id.CustomButton.Image = null;
            this.txt_search_id.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_search_id.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search_id.CustomButton.Name = "";
            this.txt_search_id.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.txt_search_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search_id.CustomButton.TabIndex = 1;
            this.txt_search_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search_id.CustomButton.UseSelectable = true;
            this.txt_search_id.CustomButton.Visible = false;
            this.txt_search_id.Lines = new string[0];
            this.txt_search_id.Location = new System.Drawing.Point(199, 256);
            this.txt_search_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search_id.MaxLength = 32767;
            this.txt_search_id.Name = "txt_search_id";
            this.txt_search_id.PasswordChar = '\0';
            this.txt_search_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search_id.SelectedText = "";
            this.txt_search_id.SelectionLength = 0;
            this.txt_search_id.SelectionStart = 0;
            this.txt_search_id.ShortcutsEnabled = true;
            this.txt_search_id.Size = new System.Drawing.Size(161, 18);
            this.txt_search_id.TabIndex = 35;
            this.txt_search_id.UseSelectable = true;
            this.txt_search_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_order_id
            // 
            // 
            // 
            // 
            this.txt_order_id.CustomButton.Image = null;
            this.txt_order_id.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_order_id.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_order_id.CustomButton.Name = "";
            this.txt_order_id.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.txt_order_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order_id.CustomButton.TabIndex = 1;
            this.txt_order_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order_id.CustomButton.UseSelectable = true;
            this.txt_order_id.CustomButton.Visible = false;
            this.txt_order_id.Lines = new string[0];
            this.txt_order_id.Location = new System.Drawing.Point(200, 98);
            this.txt_order_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_order_id.MaxLength = 32767;
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.PasswordChar = '\0';
            this.txt_order_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order_id.SelectedText = "";
            this.txt_order_id.SelectionLength = 0;
            this.txt_order_id.SelectionStart = 0;
            this.txt_order_id.ShortcutsEnabled = true;
            this.txt_order_id.Size = new System.Drawing.Size(161, 18);
            this.txt_order_id.TabIndex = 40;
            this.txt_order_id.UseSelectable = true;
            this.txt_order_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date_delivery
            // 
            this.date_delivery.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.date_delivery.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.date_delivery.Location = new System.Drawing.Point(199, 198);
            this.date_delivery.MinimumSize = new System.Drawing.Size(0, 35);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Size = new System.Drawing.Size(244, 35);
            this.date_delivery.TabIndex = 57;
            // 
            // grid_search_model
            // 
            this.grid_search_model.AllowUserToResizeRows = false;
            this.grid_search_model.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_search_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_search_model.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_search_model.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search_model.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grid_search_model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_search_model.DefaultCellStyle = dataGridViewCellStyle20;
            this.grid_search_model.EnableHeadersVisualStyles = false;
            this.grid_search_model.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_search_model.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid_search_model.Location = new System.Drawing.Point(49, 306);
            this.grid_search_model.Name = "grid_search_model";
            this.grid_search_model.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search_model.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.grid_search_model.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_search_model.RowTemplate.Height = 24;
            this.grid_search_model.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_search_model.Size = new System.Drawing.Size(616, 112);
            this.grid_search_model.TabIndex = 58;
            // 
            // grid_orders
            // 
            this.grid_orders.AllowUserToResizeRows = false;
            this.grid_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_orders.DefaultCellStyle = dataGridViewCellStyle23;
            this.grid_orders.EnableHeadersVisualStyles = false;
            this.grid_orders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid_orders.Location = new System.Drawing.Point(53, 523);
            this.grid_orders.Name = "grid_orders";
            this.grid_orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.grid_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_orders.RowTemplate.Height = 24;
            this.grid_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_orders.Size = new System.Drawing.Size(616, 112);
            this.grid_orders.TabIndex = 58;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(480, 256);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(72, 18);
            this.btn_search.TabIndex = 50;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Order2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 822);
            this.Controls.Add(this.grid_orders);
            this.Controls.Add(this.grid_search_model);
            this.Controls.Add(this.date_delivery);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_place_order);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_sys_date);
            this.Controls.Add(this.txt_cus_id);
            this.Controls.Add(this.txt_search_id);
            this.Controls.Add(this.txt_order_id);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order2";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Order2";
            this.Load += new System.EventHandler(this.Order2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_place_order;
        private MetroFramework.Controls.MetroButton btn_remove;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroTextBox txt_sys_date;
        private MetroFramework.Controls.MetroTextBox txt_cus_id;
        private MetroFramework.Controls.MetroTextBox txt_search_id;
        private MetroFramework.Controls.MetroTextBox txt_order_id;
        private MetroFramework.Controls.MetroDateTime date_delivery;
        private MetroFramework.Controls.MetroGrid grid_search_model;
        private MetroFramework.Controls.MetroGrid grid_orders;
        private MetroFramework.Controls.MetroButton btn_search;
    }
}