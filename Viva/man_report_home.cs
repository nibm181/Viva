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
    public partial class man_report_home : MetroFramework.Forms.MetroForm
    {
        public man_report_home()
        {
            InitializeComponent();
        }

        private void man_report_home_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            GarmentStockReportForm g1 = new GarmentStockReportForm();
            g1.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MaterialStockReportForm m1 = new MaterialStockReportForm();
            m1.Show();
        }

        private void tile_saleso_rep_Click(object sender, EventArgs e)
        {
            OrderReportForm orf = new OrderReportForm();
            orf.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            used_mat_report_form umrf = new used_mat_report_form();
            umrf.Show();
        }
    }
}
