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
    public partial class OrderReportForm : MetroFramework.Forms.MetroForm
    {
        public OrderReportForm()
        {
            InitializeComponent();
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OrderDataSet.DataTable1' table. You can move, or remove it, as needed.
            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.OrderDataSet.DataTable1, date_from.Value.ToShortDateString(), date_to.Value.ToShortDateString());

            this.reportViewer1.RefreshReport();
        }
    }
}
