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
    }
}
