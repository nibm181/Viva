using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace Viva
{
    public partial class Order2 : MetroFramework.Forms.MetroForm
    {

        public Order2(String cusno)
        {
            InitializeComponent();
            txt_cus_id.Text = cusno;
        }
        
        private void Order2_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lord_order_id();
            datagridload();
            date_delivery.MinDate = DateTime.Now;
        }
        Database db = new Database();

        private void OrderId_auto()
        {
            try
            {
                DataTable dt = db.GetData("select top 1 order_id from [order] order by order_id desc");
                string no = dt.Rows[0]["order_id"].ToString();
                //retriving empid column last cell data.
                int len = no.Length;
                string splitno = no.Substring(1, len - 1);
                int num = Convert.ToInt32(splitno); //converting splited string in integer
                num++; //increasing splited string by 1
                no = no.Substring(0, 1) + num.ToString("0000");
                txt_order_id.Text = no.ToString();
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lord_order_id()
        {
            OrderId_auto();
        }

        DataTable dt;
        private void datagridload()
        {
            try
            {
                dt = db.GetData("select * from garment");
                grid_search_model.DataSource = dt;
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_search_id.Text))
            {
                datagridload();
            }
            else
            {
                try
                {
                    string search = txt_search_id.Text;
                    DataView dv = new DataView(dt);
                    dv.RowFilter = "model_id like '%" + txt_search_id.Text + "%' or model_name like '%" + txt_search_id.Text + "%' ";
                    grid_search_model.DataSource = dv;

                    grid_search_model.ClearSelection();
                }
                catch (EvaluateException)
                {
                    MetroMessageBox.Show(this, "Please enter correct search term", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Please check Internet Connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void search_add_grid()
        {
            try
            {
                DataTable dt = db.GetData("select * from garment where model_id like '%" + txt_search_id.Text + "%' or model_name like '%" + txt_search_id.Text + "%' ");
                grid_search_model.DataSource = dt;
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order1 or1 = new Order1();
            or1.ShowDialog();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_qty.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Qty!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_qty.Text.Any(c => char.IsLetter(c)))
                {
                    MetroMessageBox.Show(this, "Qty can not contain Letters!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txt_qty.Text.Any(c => char.IsDigit(c)))
                {
                    MetroMessageBox.Show(this, "Qty can not contain Letters or Symbols!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_qty.Text.Any(c => char.IsPunctuation(c)))
                {
                    MetroMessageBox.Show(this, "Qty can contain Full Numbers only!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (grid_search_model.SelectedRows.Count < 0)
                {
                    MetroMessageBox.Show(this, "Please select Material model!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mod_id = grid_search_model.SelectedRows[0].Cells[0].Value + string.Empty;
                    int y = 0;
                    for (int i = 0; i  < grid_orders.Rows.Count; i++)
                    {
                        string mod_id_order = grid_orders.Rows[i].Cells[0].Value + string.Empty;
                        if (mod_id == mod_id_order)
                        {
                            y = 1;
                        }
                    }
                    if (y == 1)
                    {
                        MetroMessageBox.Show(this, "This model already enterd!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string mod_price = grid_search_model.SelectedRows[0].Cells[5].Value + string.Empty;
                        string mod_name = grid_search_model.SelectedRows[0].Cells[3].Value + string.Empty;

                        double mat_price_d = Convert.ToDouble(mod_price);
                        double qty = Convert.ToDouble(txt_qty.Text);
                        double tot_price = mat_price_d * qty;

                        grid_orders.Rows.Add(mod_id, mod_name, qty, tot_price);
                        txt_qty.Clear();
                    }
                    net_tot = 0;
                    for (int i = 0; i  < grid_orders.Rows.Count; i++)
                    {
                        net_tot = net_tot + int.Parse(grid_orders.Rows[i].Cells[3].Value.ToString());
                    }
                    txt_net_tot.Text = "Rs." + net_tot.ToString();

                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_orders.Rows.Count < 1)
                {
                    MetroMessageBox.Show(this, "no records to reomve!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (grid_orders.SelectedRows.Count < 0)
                {
                    MetroMessageBox.Show(this, "Please select to reomve!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Int32 selectedRowCount = grid_orders.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        grid_orders.Rows.RemoveAt(grid_orders.SelectedRows[0].Index);
                    }
                    net_tot = 0;
                    for (int i = 0; (i + 1) < grid_orders.Rows.Count; i++)
                    {
                        net_tot = net_tot + int.Parse(grid_orders.Rows[i].Cells[3].Value.ToString());
                    }
                    txt_net_tot.Text = "Rs." + net_tot.ToString();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_place_order_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_orders.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "no selected orders!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string delivery_date = DateTime.Now.ToShortDateString();
                    string order_date = date_delivery.Value.ToShortDateString();
                    string st = "done";
                    int ret = db.save_delete_update("insert into [order] values('" + txt_order_id.Text + "', '" + delivery_date + "', '" + txt_cus_id.Text + "', '" + order_date + "', '" + st + "')");

                    if (ret == 1)
                    {
                        string order_id = txt_order_id.Text;
                        for (int i = 0; i  < grid_orders.Rows.Count; i++)
                        {
                            string mod_id = grid_orders.Rows[i].Cells[0].Value + string.Empty;
                            string qty = grid_orders.Rows[i].Cells[2].Value + string.Empty;
                            string amount = grid_orders.Rows[i].Cells[3].Value + string.Empty;
                            string store_qty = "0";
                            string pending_qty = "0";
                            int x = 0;
                            DataTable dt = db.GetData("select * from garment where model_id='" + mod_id + "'");
                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow dr in dt.Rows)
                                {
                                    store_qty = dr["model_qty"].ToString();
                                }
                            }

                            int new_store_qty = Int32.Parse(store_qty) - Int32.Parse(qty);
                            if (Int32.Parse(store_qty) <= 0)
                            {
                                pending_qty = qty;
                            }
                            else
                            {
                                x = Int32.Parse(store_qty) - Int32.Parse(qty);
                                if (x > 0)
                                {
                                    pending_qty = "0";
                                }
                                else
                                {
                                    pending_qty = (-1 * x).ToString();
                                }
                            }
                            db.save_delete_update("insert into [order_detail] values('" + txt_order_id.Text + "', '" + mod_id + "', '" + qty + "', '" + amount + "', '" + pending_qty + "')");
                            db.save_delete_update("UPDATE garment SET model_qty = '" + new_store_qty + "' WHERE model_id = '" + mod_id + "' ");

                        }
                        //MetroMessageBox.Show(this, "Successfully New Customer Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BillReportForm br = new BillReportForm(txt_order_id.Text);
                        br.ShowDialog();
                        OrderId_auto();
                        grid_orders.Rows.Clear();
                        txt_net_tot.Clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            grid_orders.Rows.Clear();
            txt_net_tot.Clear();
            //grid_search_model.DataSource = null;
        }

        private void txt_cus_id_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void grid_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        float net_tot=0;
        private void grid_orders_RowsAdded(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
