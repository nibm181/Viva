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
    public partial class update_material_length : MetroFramework.Forms.MetroForm
    {
        public update_material_length()
        {
            InitializeComponent();
        }

        private void update_material_length_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_umat_search.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Material Name or ID or Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string search = txt_umat_search.Text;
                Database db = new Database();
                DataTable d = new DataTable();
                d = db.GetData("select mat_id, mat_name, mat_type, mat_length from materials where mat_type like '%" + search + "%' or mat_name like '%" + search + "%' or mat_id like '%" + search + "%'");
                grd_update_mat.DataSource = d;
                grd_update_mat.Columns[0].Name = "Material ID";
                grd_update_mat.Columns[0].HeaderText = "Material ID";
                grd_update_mat.Columns[1].HeaderText = "Name";
                grd_update_mat.Columns[2].HeaderText = "Type";
                grd_update_mat.Columns[3].Name = "Length";
                grd_update_mat.Columns[3].HeaderText = "Length";
                
                
                
            }
            int rows = grd_update_mat.Rows.Count;
            if (rows <1)
            {
                MetroMessageBox.Show(this, "No such material available", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void grd_update_mat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grd_update_mat.CurrentRow;
            txt_umat_id.Text = row.Cells["Material ID"].Value.ToString();
            txt_umat_al.Text = row.Cells["Length"].Value.ToString();
        }

        private void btn_umat_update_Click(object sender, EventArgs e)
        {
            if (Double.Parse(txt_umat_ul.Text) <= 0)
            {
                MetroMessageBox.Show(this, "Material used length can't be negative or 0!", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt_umat_id.Text))
            {
                MetroMessageBox.Show(this, "Please select material from the table!", "Material not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt_umat_ul.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Used Material Length!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt_umat_note.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Note!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_umat_ul.Text.Any(c => char.IsLetter(c)))
            {
                MetroMessageBox.Show(this, "Please Enter Valid used length value!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double alen = Convert.ToDouble(txt_umat_al.Text);
                double ulen = Convert.ToDouble(txt_umat_ul.Text);
                double ans = alen - ulen;
                DateTime now = DateTime.Now;


                Database db = new Database();
                db.save_delete_update("update materials set mat_length = '" + ans + "' where mat_id ='" + txt_umat_id.Text + "' ");
                db.save_delete_update("insert into material_used values('" + txt_umat_id.Text + "', '" + now + "', '" + txt_umat_note.Text + "', '" + ulen + "') ");
            }
            

        }
    }
}
