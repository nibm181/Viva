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
    public partial class material_search : MetroFramework.Forms.MetroForm
    {
        public material_search()
        {
            InitializeComponent();
        }

        Database db;
        DataTable d;

        private void material_search_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnShown(EventArgs e)
        {
            // Do your work here...
            loadGrid();

            base.OnShown(e);
        }

        private void btn_ms__search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ms__search.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Material Name or ID or Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {               
                if (grd_mat_search.Rows.Count == 0)
                {
                    loadGrid();
                }
                if (grd_mat_search.Rows.Count > 0)
                {
                    try
                    {
                        string search = txt_ms__search.Text;
                        DataView dv = new DataView(d);
                        dv.RowFilter = "mat_type like '%" + search + "%' or mat_name like '%" + search + "%' or mat_id like '%" + search + "%'";
                        grd_mat_search.DataSource = dv;
                        grd_mat_search.ClearSelection();
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "Please check your internet connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void grd_mat_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadGrid()
        {
            try
            {
                db = new Database();
                d = new DataTable();
                d = db.GetData("select mat_id, mat_name, mat_type, mat_length, mat_price from materials");
                if (d.Rows.Count > 0)
                {
                    grd_mat_search.DataSource = d;
                    grd_mat_search.Columns[0].HeaderText = "Material ID";
                    grd_mat_search.Columns[1].HeaderText = "Name";
                    grd_mat_search.Columns[2].HeaderText = "Type";
                    grd_mat_search.Columns[3].HeaderText = "Length";
                    grd_mat_search.Columns[4].HeaderText = "Price per Unit";
                    grd_mat_search.AutoResizeColumns();
                }
                grd_mat_search.ClearSelection();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Please check your internet connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
