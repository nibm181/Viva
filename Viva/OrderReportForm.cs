using MetroFramework;
using Microsoft.Reporting.WinForms;
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
            if (date_from.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                MetroMessageBox.Show(this, "Please Select a valid Date", "Incorrect Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.DataTable1TableAdapter.Fill(this.OrderDataSet.DataTable1, date_from.Value.ToShortDateString(), date_to.Value.ToShortDateString());

                    ReportParameter[] parms = new ReportParameter[2];
                    parms[0] = new ReportParameter("from_d", date_from.Text);
                    parms[1] = new ReportParameter("to_d", date_to.Text);
                    this.reportViewer1.LocalReport.SetParameters(parms);

                    this.reportViewer1.RefreshReport();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Please check your internet connection", "Reconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            date_to.MinDate = date_from.Value;
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            date_from.MaxDate = date_to.Value;
        }
    }
}
