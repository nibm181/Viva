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
            editCustomer e1 = new editCustomer();
            e1.Show();
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
    }
}
