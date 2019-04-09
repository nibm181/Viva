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

        private void Materials_Load(object sender, EventArgs e)
        {

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
            this.txt_mat_id.Clear();
            this.txt_mat_length.Clear();
            this.txt_mat_name.Clear();
            this.cmb_mat_type.SelectedItem = null;
            this.cmb_mat_type.SelectedText = "--select--";
        }

        private void btn_mat_add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_mat_length.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Material Length!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            if (string.IsNullOrWhiteSpace(txt_mat_name.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Material Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cmb_mat_type.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Please select Material Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Database db = new Database();
                db.save_delete_update("insert into materials values('" + txt_mat_id.Text + "', '" + txt_mat_name.Text + "', '" + cmb_mat_type.Text + "', '" + txt_mat_length.Text + "')");
            }
            
            
        }
    }
}
