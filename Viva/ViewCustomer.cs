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
    public partial class ViewCustomer : MetroFramework.Forms.MetroForm
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        Database db;
        DataTable d;

       

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                db = new Database();
                d = new DataTable();
                d = db.GetData("select * from customer");
                if (d.Rows.Count > 0)
                {
                    metroGrid1.DataSource = d;
                    metroGrid1.Columns[0].HeaderText = "ID";
                    metroGrid1.Columns[1].HeaderText = "Name";
                    metroGrid1.Columns[2].HeaderText = "Address 1";
                    metroGrid1.Columns[3].HeaderText = "Address 2";
                    metroGrid1.Columns[4].HeaderText = "Contact Number";
                    metroGrid1.AutoResizeColumns();
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Please check your internet connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Customer Name or ID or Address 2 or Contact number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string search = txt_search.Text;
                    db = new Database();
                    d = new DataTable();
                    d = db.GetData("select * from customer where cus_id like '%" + search + "%' or cus_name like '%" + search + "%' or cus_add2 like '%" + search + "%' or contact_no like '" + search + "'");
                    if (d.Rows.Count > 0)
                    {
                        metroGrid1.DataSource = d;
                        metroGrid1.Columns[0].HeaderText = "ID";
                        metroGrid1.Columns[1].HeaderText = "Name";
                        metroGrid1.Columns[2].HeaderText = "Address 1";
                        metroGrid1.Columns[3].HeaderText = "Address 2";
                        metroGrid1.Columns[4].HeaderText = "Contact Number";
                        metroGrid1.AutoResizeColumns();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There is no Customer(s) accompanied with the given Search Term", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Please check your internet connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
