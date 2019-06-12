using MetroFramework;
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
    public partial class Materials : MetroFramework.Forms.MetroForm
    {
        public Materials()
        {
            InitializeComponent();
           
        }
        String first_id;
        private void Materials_Load(object sender, EventArgs e)
        {
            

            Database db = new Database();
            DataTable dt = db.GetData("select top 1 mat_id from materials order by mat_id desc");
            string no = dt.Rows[0]["mat_id"].ToString();
            //retriving empid column last cell data.
            int len = no.Length;
            string splitno = no.Substring(1, len - 1);
            int num = Convert.ToInt32(splitno); //converting splited string in integer
            num++; //increasing splited string by 1
            no = no.Substring(0, 1) + num.ToString("0000");
            first_id = no.ToString();
            txt_mat_id.Text = no.ToString();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btn_mat_reset_Click(object sender, EventArgs e)
        {
            
            this.txt_mat_length.Clear();
            this.txt_mat_name.Clear();
            this.cmb_mat_type.SelectedItem = null;
            this.cmb_mat_type.SelectedText = "--select--";
            txt_mat_billno.Clear();
            txt_mat_price.Clear();
        }

        private void btn_mat_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_mat_billno.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Bill No.!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrWhiteSpace(txt_mat_name.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Material Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_mat_type.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Material Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrWhiteSpace(txt_mat_length.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Material Length!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txt_mat_length.Text.Any(char.IsLetter))
                {
                    MetroMessageBox.Show(this, "Please enter Material Length in Numbers only!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Double.Parse(txt_mat_length.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Material length can't be negative or 0!", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_mat_length.Text.Any(c => char.IsLetter(c)))
                {
                    MetroMessageBox.Show(this, "Length can not contain Letters!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txt_mat_price.Text.Any(c => char.IsLetter(c)))
                {
                    MetroMessageBox.Show(this, "Price can not contain Letters!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_mat_price.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Material Price!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (Double.Parse(txt_mat_price.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Material price can't be negative or 0!", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /* else if (txt_mat_price.Text.Any(char.IsLetter) || float.Parse(txt_mat_price.Text) <= 0)
                 {
                     MetroMessageBox.Show(this, "Please enter Garment Price in positive numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
                
                else
                {
                    txt_mat_billno.Enabled = false;
                    grd_mat.Rows.Add(txt_mat_billno.Text,txt_mat_id.Text, txt_mat_name.Text, cmb_mat_type.Text, txt_mat_length.Text, txt_mat_price.Text);

                    string no = txt_mat_id.Text;
                    this.txt_mat_length.Clear();
                    this.txt_mat_name.Clear();
                    this.cmb_mat_type.SelectedItem = null;
                    this.cmb_mat_type.SelectedText = "--select--";
                    txt_mat_price.Clear();

                    
                    int len = no.Length;
                    string splitno = no.Substring(1, len - 1);
                    int num = Convert.ToInt32(splitno); //converting splited string in integer
                    num++; //increasing splited string by 1
                    no = no.Substring(0, 1) + num.ToString("0000");
                    txt_mat_id.Text = no.ToString();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_mat_rem_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =grd_mat.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedRowCount; i++)
            {
                grd_mat.Rows.RemoveAt(grd_mat.SelectedRows[0].Index);
            }
        }

        private void btn_mat_clear_Click(object sender, EventArgs e)
        {
            grd_mat.Rows.Clear();
            txt_mat_billno.Enabled = true;
            txt_mat_id.Text = first_id;

        }

        private void btn_mat_con_Click(object sender, EventArgs e)
        {
            int ret=0;
            Database db = new Database();
            for (int i = 0; i < grd_mat.Rows.Count; i++)
            {
              ret=db.save_delete_update("insert into materials values('" + grd_mat.Rows[i].Cells["Col_bill"].Value + "', '" + grd_mat.Rows[i].Cells["col_id"].Value + "', '"+ grd_mat.Rows[i].Cells["col_name"].Value +"', '"+ grd_mat.Rows[i].Cells["Col_type"].Value +"', '"+ grd_mat.Rows[i].Cells["Col_len"].Value + "', '"+ grd_mat.Rows[i].Cells["Col_price"].Value + "')");
            }
            if (ret == 1)
            {
                MetroMessageBox.Show(this, "Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_mat_length.Clear();
                this.txt_mat_name.Clear();
                this.cmb_mat_type.SelectedItem = null;
                this.cmb_mat_type.SelectedText = "--select--";
                txt_mat_billno.Clear();
                txt_mat_price.Clear();
                grd_mat.Rows.Clear();

                DataTable dt = db.GetData("select top 1 mat_id from materials order by mat_id desc");
                string no = dt.Rows[0]["mat_id"].ToString();
                //retriving empid column last cell data.
                int len = no.Length;
                string splitno = no.Substring(1, len - 1);
                int num = Convert.ToInt32(splitno); //converting splited string in integer
                num++; //increasing splited string by 1
                no = no.Substring(0, 1) + num.ToString("0000");
                txt_mat_id.Text = no.ToString();
            }
            
        }

        private void Txt_mat_billno_Click(object sender, EventArgs e)
        {

        }

        private void cmb_mat_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
