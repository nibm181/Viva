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
    public partial class MaterialStockReportForm : MetroFramework.Forms.MetroForm
    {
        public MaterialStockReportForm()
        {
            InitializeComponent();
        }

        private void MaterialStockReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MaterialDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.MaterialDataSet.materials);

            this.reportViewer1.RefreshReport();
        }
    }
}
