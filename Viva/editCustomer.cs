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
    public partial class editCustomer : MetroFramework.Forms.MetroForm
    {
        public editCustomer()
        {
            InitializeComponent();
        }
        Database db;

        private void editCustomer_Load(object sender, EventArgs e)
        {

            txt_cusName.ReadOnly = true;
            txt_cus_Id.ReadOnly = true;
            txt_add1.ReadOnly = true;
            txt_add2.ReadOnly = true;
            txt_cus_no.ReadOnly = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(txt_cusName.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Customer Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_add1.Text))
                {
                    MetroMessageBox.Show(this, "Please enter first Address!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_add2.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Second Address!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_cus_no.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Contact Number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else if (txt_cus_no.Text.Any(char.IsLetter)  )
                {
                    MetroMessageBox.Show(this, "Contact Number Should Be Numeric", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_cus_no.Text.Length != 10)
                {
                    MetroMessageBox.Show(this, "Contact Number Should Contain 10 numbers", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Database db = new Database();
                        int row = db.save_delete_update("update customer set cus_name = '" + txt_cusName.Text + "', cus_add1 = '" + txt_add1.Text + "', cus_add2= '" + txt_add2.Text + "', contact_no = '" + txt_cus_no.Text + "' where cus_id = '" + txt_cus_Id.Text + "'");
                        if (row == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_searchCus.Clear();
                            txt_cus_Id.Clear();
                            txt_cusName.Clear();
                            txt_add1.Clear();
                            txt_add2.Clear();
                            txt_cus_no.Clear();
                            txt_cusName.ReadOnly = true;
                            txt_cus_Id.ReadOnly = true;
                            txt_add1.ReadOnly = true;
                            txt_add2.ReadOnly = true;
                            txt_cus_no.ReadOnly = true;
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch
            {
                MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_searchCus.Text))
                {
                    MetroMessageBox.Show(this, "Please enter customer ID  search!", "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db = new Database();
                    DataTable dt = db.GetData("select * from customer where cus_id='" + txt_searchCus.Text + "'");
                    if (dt.Rows.Count > 0)
                    {


                        txt_cusName.ReadOnly = false;
                        txt_cus_Id.ReadOnly = true;
                        txt_add1.ReadOnly = false;
                        txt_add2.ReadOnly = false;
                        txt_cus_no.ReadOnly = false;

                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_cus_Id.Text = dr["cus_id"].ToString();


                            txt_cusName.Text = dr["cus_name"].ToString();
                            txt_add1.Text = dr["cus_add1"].ToString();
                            txt_add2.Text = dr["cus_add2"].ToString();
                            txt_cus_no.Text = dr["contact_no"].ToString();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There is no Customer accompanied with the given Customer ID", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "There is no Customer accompanied with the given Customer ID", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_cus_Id.Text))
                {
                    MetroMessageBox.Show(this, "Please select Customer ID!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        db = new Database();
                        int i = db.save_delete_update("delete from customer where cus_id='" + txt_cus_Id.Text + "'");
                        if (i == 1)
                        {
                            txt_searchCus.Clear();
                            txt_cus_Id.Clear();

                            txt_cusName.Clear();
                            txt_add1.Clear();
                            txt_add2.Clear();
                            txt_cus_no.Clear();

                            MetroFramework.MetroMessageBox.Show(this, " Successfully deleted!", "Delete message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_cus_Id.ReadOnly = true;


                            txt_cusName.ReadOnly = true;
                            txt_add1.ReadOnly = true;
                            txt_add2.ReadOnly = true;
                            txt_cus_no.ReadOnly = true;
                        }
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cus_Id.Text))
            {
                MetroMessageBox.Show(this, "Already Cleared", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_searchCus.Clear();
                txt_cus_Id.Clear();
                txt_cusName.Clear();
                txt_add1.Clear();
                txt_add2.Clear();
                txt_cus_no.Clear();

                txt_cus_Id.ReadOnly = true;

                txt_cusName.ReadOnly = true;
                txt_add1.ReadOnly = true;
                txt_add2.ReadOnly = true;
                txt_cus_no.ReadOnly = true;
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_searchCus_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txt_cusName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    } 
}
