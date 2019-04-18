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
    public partial class Order2 : MetroFramework.Forms.MetroForm
    {
        public Order2()
        {
            InitializeComponent();
        }
        Database db;
        private void Order2_Load(object sender, EventArgs e)
        {
            db = new Database();
            DataTable dt = db.GetData("select model_id, model_name, model_type, model_cat from tbl_garment");
            grid_search.DataSource = dt;
            grid_search.Columns[0].HeaderText = "Garment ID";
            grid_search.Columns[1].HeaderText = "Nmae";
            grid_search.Columns[2].HeaderText = "Type";
            grid_search.Columns[3].HeaderText = "Category";
            grid_search.AutoResizeColumns();

            date_current.Value = DateTime.Now;
            date_delivery.MinDate = DateTime.Now;
        }

        
    }
}
