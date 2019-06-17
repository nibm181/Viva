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
using System.Text.RegularExpressions;

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

            txt_cus_name.ReadOnly = true;
            txt_cus_Id.ReadOnly = true;
            txt_add1.ReadOnly = true;
            txt_add2.ReadOnly = true;
            txt_cno.ReadOnly = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(txt_cus_name.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cus_name.Text.Any(char.IsNumber))
                {
                    MetroMessageBox.Show(this, "Please enter valid Name!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cus_name.Text.Any(char.IsSymbol) || txt_cus_name.Text.Any(char.IsDigit) || Regex.Matches(txt_cus_name.Text, @"\.").Count >= 2)
                {
                    MetroMessageBox.Show(this, "Please enter a valid Name!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                else if (Regex.IsMatch(txt_cus_name.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Name can not contain apostrophe!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch( txt_cus_name.Text, @"^[a-zA-Z ]*$"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Name!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_add1.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter First Address !", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_add1.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Address!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_add2.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Second Address!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_add2.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Address 2!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_cno.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Conatct Number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cno.Text.Any(char.IsWhiteSpace) || txt_cno.Text.Length != 10 || !txt_cno.Text.Any(char.IsNumber) || txt_cno.Text.Any(char.IsLetter) || txt_cno.Text.Any(char.IsPunctuation))
                {
                    MetroMessageBox.Show(this, "Please Enter Contact Number in Numeric!\nContact Number should contain 10 Numbers!!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cno.Focus();
                }
                else if (!Regex.IsMatch(txt_cno.Text, @"\d+$"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Contact Number!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Database db = new Database();
                        int row = db.save_delete_update("update customer set cus_name = '" + txt_cus_name.Text + "', cus_add1 = '" + txt_add1.Text + "', cus_add2= '" + txt_add2.Text + "', contact_no = '" + txt_cno.Text + "' where cus_id = '" + txt_cus_Id.Text + "'");
                        if (row == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_searchCus.Clear();
                            txt_cus_Id.Clear();
                            txt_cus_name.Clear();
                            txt_add1.Clear();
                            txt_add2.Clear();
                            txt_cno.Clear();
                            txt_cus_name.ReadOnly = true;
                            txt_cus_Id.ReadOnly = true;
                            txt_add1.ReadOnly = true;
                            txt_add2.ReadOnly = true;
                            txt_cno.ReadOnly = true;
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


                        txt_cus_name.ReadOnly = false;
                        txt_cus_Id.ReadOnly = true;
                        txt_add1.ReadOnly = false;
                        txt_add2.ReadOnly = false;
                        txt_cno.ReadOnly = false;

                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_cus_Id.Text = dr["cus_id"].ToString();


                            txt_cus_name.Text = dr["cus_name"].ToString();
                            txt_add1.Text = dr["cus_add1"].ToString();
                            txt_add2.Text = dr["cus_add2"].ToString();
                            txt_cno.Text = dr["contact_no"].ToString();
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

                            txt_cus_name.Clear();
                            txt_add1.Clear();
                            txt_add2.Clear();
                            txt_cno.Clear();

                            MetroFramework.MetroMessageBox.Show(this, " Successfully deleted!", "Delete message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_cus_Id.ReadOnly = true;


                            txt_cus_name.ReadOnly = true;
                            txt_add1.ReadOnly = true;
                            txt_add2.ReadOnly = true;
                            txt_cno.ReadOnly = true;
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
                txt_cus_name.Clear();
                txt_add1.Clear();
                txt_add2.Clear();
                txt_cno.Clear();

                txt_cus_Id.ReadOnly = true;

                txt_cus_name.ReadOnly = true;
                txt_add1.ReadOnly = true;
                txt_add2.ReadOnly = true;
                txt_cno.ReadOnly = true;
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
