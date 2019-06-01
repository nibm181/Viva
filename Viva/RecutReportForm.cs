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
    public partial class RecutReportForm : MetroFramework.Forms.MetroForm
    {
        public RecutReportForm()
        {
            InitializeComponent();
        }

        private void RecutReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReCutDataSet.tbl_garment' table. You can move, or remove it, as needed.
            try
            {
                this.tbl_garmentTableAdapter.Fill(this.ReCutDataSet.tbl_garment);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MetroMessageBox.Show(this, "Please check your internet connection", "Reconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
