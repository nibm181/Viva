using System;
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
            txt_sys_date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lord_order_id();
            datagridload();
        }

        private void lord_order_id()
        {   //cus ID auto gen need to finish
            /*
            SqlConnection con;
            con = new SqlConnection("Server=tcp:nibmgarments.database.windows.net,1433;Initial Catalog=Garments;Persist Security Info=False;User ID=doof;Password=warrior@00;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("select top 1 cus_id from customer order by cus_id desc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);*/

            string EmpId = "001";
            /*
            string s = dt.Rows[0]["cus_id"].ToString();
            //retriving empid column last cell data.
            int len = s.Length;
            string splitno = s.Substring(1, len - 1);
            int num = Convert.ToInt32(splitno); //converting splited string in integer
            num++; //increasing splited string by 1
            EmpId = s.Substring(0, 1) + num.ToString("000");*/
            txt_order_id.Text = EmpId.ToString();
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

        }
    }
}
