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
    public partial class deliver_alert : MetroFramework.Forms.MetroForm
    {
        public deliver_alert()
        {
            InitializeComponent();
        }

        private void deliver_alert_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                DateTime today = DateTime.Today;
                DateTime ddate = today.AddDays(30);
                DataTable dt = db.GetData("select * from [order] where deliver_date > '" + today + "' and deliver_date < '" + ddate + "'");

                delivery_grid.DataSource = dt;
                delivery_grid.Columns[0].HeaderText = "Order ID";
                delivery_grid.Columns[1].HeaderText = "Order Date";
                delivery_grid.Columns[2].HeaderText = "Customer ID";
                delivery_grid.Columns[3].HeaderText = "Deliver Date";
                delivery_grid.Columns[4].HeaderText = "Status";
                delivery_grid.AutoResizeColumns();
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delivery_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
