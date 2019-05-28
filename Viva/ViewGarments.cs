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
    public partial class ViewGarments : MetroFramework.Forms.MetroForm
    {
        public ViewGarments()
        {
            InitializeComponent();
        }

        Database db;
        DataTable d;

        private void ViewGarments_Load(object sender, EventArgs e)
        {
            db = new Database();
            d = new DataTable();
            d = db.GetData("select * from tbl_garment");
            if (d.Rows.Count > 0)
            {
                metroGrid1.DataSource = d;
                metroGrid1.Columns[0].HeaderText = "Model ID";
                metroGrid1.Columns[1].HeaderText = "Type";
                metroGrid1.Columns[2].HeaderText = "Category";
                metroGrid1.Columns[3].HeaderText = "Name";
                metroGrid1.Columns[4].HeaderText = "Qty in Hand";
                metroGrid1.Columns[5].HeaderText = "Price per Unit";
                metroGrid1.AutoResizeColumns();
            }
            else
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Material Name or ID or Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string search = txt_search.Text;
                db = new Database();
                d = new DataTable();
                d = db.GetData("select * from tbl_garment where model_type like '%" + search + "%' or model_name like '%" + search + "%' or model_id like '%" + search + "%' or model_cat like '%" + search + "%'");
                if (d.Rows.Count > 0)
                {
                    metroGrid1.DataSource = d;
                    metroGrid1.Columns[0].HeaderText = "Model ID";
                    metroGrid1.Columns[1].HeaderText = "Type";
                    metroGrid1.Columns[2].HeaderText = "Category";
                    metroGrid1.Columns[3].HeaderText = "Name";
                    metroGrid1.Columns[4].HeaderText = "Qty in Hand";
                    metroGrid1.Columns[5].HeaderText = "Price per Unit";
                    metroGrid1.AutoResizeColumns();
                }
                else
                {
                    MetroMessageBox.Show(this, "There is no Garment(s) accompanied with the given Search Term", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
