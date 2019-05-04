﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace Viva
{
    public partial class Order2 : MetroFramework.Forms.MetroForm
    {

        public Order2(String cusno)
        {
            InitializeComponent();
            txt_cus_id.Text = cusno;
        }
        
        private void Order2_Load(object sender, EventArgs e)
        {
            //txt_sys_date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lord_order_id();
            datagridload();
            date_delivery.MinDate = DateTime.Now;
        }
        Database db = new Database();

        private void lord_order_id()
        {
            DataTable dt = db.GetData("select top 1 order_id from [order] order by order_id desc");
            string no = dt.Rows[0]["order_id"].ToString();
            //retriving empid column last cell data.
            int len = no.Length;
            string splitno = no.Substring(1, len - 1);
            int num = Convert.ToInt32(splitno); //converting splited string in integer
            num++; //increasing splited string by 1
            no = no.Substring(0, 1) + num.ToString("0000");
            txt_order_id.Text = no.ToString();
        }


        private void datagridload()
        {
            SqlConnection con;
            con = new SqlConnection("Server=tcp:nibmgarments.database.windows.net,1433;Initial Catalog=Garments;Persist Security Info=False;User ID=doof;Password=warrior@00;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_garment", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid_search_model.DataSource = dt;
        }
        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search_add_grid();
        }
        private void search_add_grid()
        {
            SqlConnection con;
            con = new SqlConnection("Server=tcp:nibmgarments.database.windows.net,1433;Initial Catalog=Garments;Persist Security Info=False;User ID=doof;Password=warrior@00;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_garment", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid_search_model.DataSource = dt;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Order1 or1 = new Order1();
            or1.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_qty.Text))
            {
                MetroMessageBox.Show(this, "Please Enter QTY!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_qty.Text.Any(c => char.IsLetter(c)))
            {
                MetroMessageBox.Show(this, "QTY can not contain Letters!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (grid_search_model.SelectedRows.Count < 0)
            {
                MetroMessageBox.Show(this, "Please select Material model!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mod_id = grid_search_model.SelectedRows[0].Cells[0].Value + string.Empty;
                string mod_price = grid_search_model.SelectedRows[0].Cells[5].Value + string.Empty;
                string mod_name = grid_search_model.SelectedRows[0].Cells[3].Value + string.Empty;

                double mat_price_d = Convert.ToDouble(mod_price);
                double qty = Convert.ToDouble(txt_qty.Text);
                double tot_price = mat_price_d * qty;

                grid_orders.Rows.Add(mod_id, mod_name, qty, tot_price);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (grid_orders.SelectedRows.Count < 0)
            {
                MetroMessageBox.Show(this, "Please select to reomve!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Int32 selectedRowCount = grid_orders.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < selectedRowCount; i++)
                {
                    grid_orders.Rows.RemoveAt(grid_orders.SelectedRows[0].Index);
                }
            }
        }

        private void btn_place_order_Click(object sender, EventArgs e)
        {

            string delivery_date = date_delivery.Value.ToString("yyyy-mm-dd");
            string order_date = DateTime.Now.ToString("yyyy-mm-dd");
            string st = "done";
            int ret = db.save_delete_update("insert into [order] values('" + txt_order_id.Text + "', '" + delivery_date + "', '" + txt_cus_id.Text + "', '" + order_date + "', '" + st + "')");
            
            if (ret == 1)
            {

                MetroMessageBox.Show(this, "Successfully New Customer Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IdIncrement();

                txt_cus_name.Clear();
                txt_add1.Clear();
                txt_add2.Clear();
                txt_cno.Clear();


            }
            else
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string order_id = txt_order_id.Text;
            string a = "A";
            for (int i = 0; (i+1) < grid_orders.Rows.Count; i++)
            {

                string mod_id = grid_orders.Rows[i].Cells[0].Value + string.Empty;
                string qty = grid_orders.Rows[i].Cells[2].Value + string.Empty;
                string amount = grid_orders.Rows[i].Cells[3].Value + string.Empty;
                
                int ret = db.save_delete_update("insert into [order_detail] values('" + txt_order_id.Text + "', '" + mod_id + "', '" + qty + "', '" + amount + "', '" + a + "')");
            }
        }
    }
}
