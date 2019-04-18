using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Viva
{
    public partial class Order1 : MetroFramework.Forms.MetroForm
    {
        public Order1()
        {
            InitializeComponent();
            txt_cus_name.ReadOnly = true;
            txt_cus_Id.ReadOnly = true;
            txt_cus_add1.ReadOnly = true;
            txt_cus_add2.ReadOnly = true;
            txt_cus_no.ReadOnly = true;
        }
        Database db;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_search_iD.Text))
                {
                    MetroMessageBox.Show(this, "Please enter customer ID  search!", "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db = new Database();
                    DataTable dt = db.GetData("select * from customer where cus_id='" + txt_search_iD.Text + "'");
                    if (dt.Rows.Count > 0)
                    {


                        txt_cus_name.ReadOnly = false;
                        txt_cus_Id.ReadOnly = false;
                        txt_cus_add1.ReadOnly = false;
                        txt_cus_add2.ReadOnly = false;
                        txt_cus_no.ReadOnly = false;

                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_cus_Id.Text = dr["cus_id"].ToString();
                            txt_cus_name.Text = dr["cus_name"].ToString();
                            txt_cus_add1.Text = dr["cus_add1"].ToString();
                            txt_cus_add2.Text = dr["cus_add2"].ToString();
                            txt_cus_no.Text = dr["contact_no"].ToString();
                        }

                        txt_cus_name.ReadOnly = true;
                        txt_cus_Id.ReadOnly = true;
                        txt_cus_add1.ReadOnly = true;
                        txt_cus_add2.ReadOnly = true;
                        txt_cus_no.ReadOnly = true;

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There is no Garment accompanied with the given Model ID", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "There is no Garment accompanied with the given Model ID", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cus_name.Clear();
            txt_cus_Id.Clear();
            txt_cus_add1.Clear();
            txt_cus_add2.Clear();
            txt_cus_no.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
