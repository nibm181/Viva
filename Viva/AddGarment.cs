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
    public partial class AddGarment : MetroFramework.Forms.MetroForm
    {
        Database db;

        public AddGarment()
        {
            InitializeComponent();
        }

        private void AddGarment_Load(object sender, EventArgs e)
        {
           db  = new Database();
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_gtype.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Garment Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_gcat.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Garment Category!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_gname.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_gqty.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Quantity!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_gqty.Text.Any(char.IsLetter) || Int32.Parse(txt_gqty.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Please enter Quantity in positive numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
                else if (string.IsNullOrWhiteSpace(txt_gprice.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_gprice.Text.Any(char.IsLetter) || float.Parse(txt_gprice.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price in positive numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Database db = new Database();
                    int row = db.save_delete_update("insert into garment values('" + txt_gno.Text + "', '" + cmb_gtype.Text + "','" + cmb_gcat.Text + "', '" + txt_gname.Text + "', " + txt_gqty.Text + ", '" + txt_gprice.Text + "')");
                    if (row == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_gno.Clear();
                        cmb_gtype.SelectedIndex = -1;
                        cmb_gcat.SelectedIndex = -1;
                        txt_gname.Clear();
                        txt_gqty.Clear();
                        txt_gprice.Clear();


                    }
                }
            }
            catch(FormatException)
            {
                MetroMessageBox.Show(this, "Please enter valid Quantity!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_gqty_Click(object sender, EventArgs e)
        {

        }

        private void cmb_gtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_gtype.SelectedIndex != -1)
                {
                    DataTable dt = db.GetData("select top 1 model_id from garment where model_type = '" + cmb_gtype.Text + "' order by model_id desc");
                    string no = dt.Rows[0]["model_id"].ToString();
                    //retriving empid column last cell data.
                    int len = no.Length;
                    string splitno = no.Substring(1, len - 1);
                    int num = Convert.ToInt32(splitno); //converting splited string in integer
                    num++; //increasing splited string by 1
                    no = no.Substring(0, 1) + num.ToString("0000");
                    txt_gno.Text = no.ToString();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_gno.Clear();
            cmb_gtype.SelectedIndex = -1;
            cmb_gcat.SelectedIndex = -1;
            txt_gname.Clear();
            txt_gqty.Clear();
            txt_gprice.Clear();
        }
    }
}
