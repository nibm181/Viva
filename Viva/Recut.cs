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
    public partial class Recut : MetroFramework.Forms.MetroForm
    {
        public Recut()
        {
            InitializeComponent();
        }

        Database db;
        DataTable d;

        private void Recut_Load(object sender, EventArgs e)
        {
           
            
        }

        protected override void OnShown(EventArgs e)
        {
            // Do your work here...
            try
            {
                db = new Database();
                d = new DataTable();
                d = db.GetData("select model_id, model_type, model_cat, model_name, model_qty from tbl_garment where model_qty<0");
                if (d.Rows.Count > 0)
                {

                    foreach (DataRow row in d.Rows)
                    {
                        int y = Math.Abs(int.Parse(row[4].ToString()));
                        row[4] = y;
                    }

                    metroGrid1.DataSource = d;
                    metroGrid1.Columns[0].HeaderText = "Model ID";
                    metroGrid1.Columns[1].HeaderText = "Type";
                    metroGrid1.Columns[2].HeaderText = "Category";
                    metroGrid1.Columns[3].HeaderText = "Name";
                    metroGrid1.Columns[4].HeaderText = "Qty Needed";
                    metroGrid1.AutoResizeColumns();
                }
                metroGrid1.ClearSelection();
            }
            catch
            {
                MetroMessageBox.Show(this, "Please check your internet connection", "Reconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            base.OnShown(e);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            RecutReportForm rrf = new RecutReportForm();
            rrf.ShowDialog();
            //Application.Run(rrf);
        }
    }
}
