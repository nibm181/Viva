using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viva
{
    public partial class order_1 : MetroFramework.Forms.MetroForm
    {
        public order_1()
        {
            InitializeComponent();
        }
        Database db;
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_search_id.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, " Please enter Customer Name or ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    DataTable dt = db.GetData("select * from Customer where cus_Id='" + txt_search_id.Text + "' or cus_name = '" + txt_search_id.Text + "'");

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_cus_id.Text = dr["cus_Id"].ToString();
                            txt_cus_name.Text = dr["cus_name"].ToString();
                            txt_cus_add1.Text = dr["cus_add1"].ToString();
                            txt_cus_add2.Text = dr["cus_add2"].ToString();
                            txt_cus_no.Text = dr["contact_no"].ToString();

                            txt_cus_id.ReadOnly = true;
                            txt_cus_name.ReadOnly = true;
                            txt_cus_add1.ReadOnly = true;
                            txt_cus_add2.ReadOnly = true;
                            txt_cus_no.ReadOnly = true;
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, " Invalid vehicle number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void order_1_Load(object sender, EventArgs e)
        {
            db = new Database();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cus_id.Clear();
            txt_cus_name.Clear();
            txt_cus_add1.Clear();
            txt_cus_add2.Clear();
            txt_cus_no.Clear();
            txt_search_id.Clear();
            txt_cus_add1.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
