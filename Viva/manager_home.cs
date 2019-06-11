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
    public partial class manager_home : MetroFramework.Forms.MetroForm
    {
        public manager_home()
        {
            InitializeComponent();
        }

        

        protected override void OnShown(EventArgs e)
        {
            // Do your work here...
            Database db = new Database();
            DateTime today = DateTime.Today;
            DateTime ddate = today.AddDays(30);
            DataTable dt = db.GetData("select order_id from [order] where deliver_date >'" + today + "' and deliver_date < '" + ddate + "'");
            int c = dt.Rows.Count;

            if (dt.Rows.Count > 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "You have '" + c + "' orders to Delivery in less than 30 days. Do you want to display it? ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {

                    deliver_alert d1 = new deliver_alert();
                    d1.Show();


                }
            }

            base.OnShown(e);
        }

        private void manager_home_Load(object sender, EventArgs e)
        {
            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void tile_edit_user_Click(object sender, EventArgs e)
        {
            ResetPwd r1 = new ResetPwd();
            r1.Show();
        }

        private void tile_reg_user_Click(object sender, EventArgs e)
        {
            AddUser a1 = new AddUser();
            a1.Show();
        }

        private void tile_recut_Click(object sender, EventArgs e)
        {
            Recut r1 = new Recut();
            r1.Show();
        }

        private void tile_gen_report_Click(object sender, EventArgs e)
        {
            man_report_home m1 = new man_report_home();
            m1.Show();
        }

        private void tile_user_log_Click(object sender, EventArgs e)
        {
            UserLogForm ul = new UserLogForm();
            ul.Show();
        }

        private void tile_view_cus_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();
        }

        private void tile_view_garm_Click(object sender, EventArgs e)
        {
            ViewGarments vg = new ViewGarments();
            vg.Show();
        }

        private void tile_view_mat_Click(object sender, EventArgs e)
        {
            material_search vm = new material_search();
            vm.Show();
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

        private void tile_add_cus_Click(object sender, EventArgs e)
        {
            customerReg ac = new customerReg();
            ac.Show();
        }

        private void tile_add_gar_Click(object sender, EventArgs e)
        {
            AddGarment ag = new AddGarment();
            ag.Show();
        }

        private void tile_add_mat_Click(object sender, EventArgs e)
        {
            Materials am=new Materials();
            am.Show();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
