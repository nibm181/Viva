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
    public partial class stock_admin_home : MetroFramework.Forms.MetroForm
    {
        public stock_admin_home()
        {
            InitializeComponent();
        }

        private void stock_admin_Load(object sender, EventArgs e)
        {

        }

        private void tile_add_mtrl_Click(object sender, EventArgs e)
        {
            Materials m1 = new Materials();
            m1.Show();
        }

        private void tile_add_gar_Click(object sender, EventArgs e)
        {
            AddGarment a1 = new AddGarment();
            a1.Show();
        }

        private void tile_chk_mat_Click(object sender, EventArgs e)
        {
            material_search m1 = new material_search();
            m1.Show();
        }

        private void tile_update_mtrl_length_Click(object sender, EventArgs e)
        {
            update_material_length u1 = new update_material_length();
            u1.Show();
        }

        private void tile_edit_gar_Click(object sender, EventArgs e)
        {
            editGarment e1 = new editGarment();
            e1.Show();
        }

        private void tile_view_gar_Click(object sender, EventArgs e)
        {
            ViewGarments vg = new ViewGarments();
            vg.Show();
        }

        private void tile_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to logout? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                form_login lg = new form_login();
                lg.ShowDialog();
                this.Close();
            }
        }
    }
}
