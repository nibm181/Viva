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
    public partial class BillReportForm : MetroFramework.Forms.MetroForm
    {
        public BillReportForm()
        {
            InitializeComponent();
        }

        private void BillReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Bill.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Bill.DataTable1, "O0001");

            this.reportViewer1.RefreshReport();
        }
    }
}
