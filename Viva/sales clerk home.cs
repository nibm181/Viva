﻿using MetroFramework;
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
    public partial class sales_clerk_home : MetroFramework.Forms.MetroForm
    {
        public sales_clerk_home()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            // Do your work here...
            try
            {
                Database db = new Database();
                DateTime today = DateTime.Today;
                DateTime ddate = today.AddDays(30);
                DataTable dt = db.GetData("select order_id from [order] where deliver_date >'" + today + "' and deliver_date < '" + ddate + "'");
                int c = dt.Rows.Count;

                if (dt.Rows.Count > 0)
                {
                    DialogResult result = MetroMessageBox.Show(this, "You have '" + c + "' orders to Delivery in less than 30 days. Do you want to display it? ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {

                        deliver_alert d1 = new deliver_alert();
                        d1.Show();


                    }
                }
            }
            catch
            { 
            }

            base.OnShown(e);
        }

        private void sales_clerk_home_Load(object sender, EventArgs e)
        {

        }

        private void tile_place_order_Click(object sender, EventArgs e)
        {
            Order1 o1 = new Order1();
            o1.Show();
        }

        private void tile_generate_Rinvo_Click(object sender, EventArgs e)
        {

        }

        private void tile_place_Rorder_Click(object sender, EventArgs e)
        {
            
        }

        private void tile_reg_customer_Click(object sender, EventArgs e)
        {
            customerReg c1 = new customerReg();
            c1.Show();
        }

        private void tile_edit_cus_Click(object sender, EventArgs e)
        {
            editCustomer e1 = new editCustomer();
            e1.Show();
        }

        private void tile_view_cus_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();
        }

        private void tile_view_garm_Click(object sender, EventArgs e)
        {
            ViewGarments vg = new ViewGarments();
            vg.Show();
        }

        private void tile_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to logout? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //this.Hide();
                try
                {
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        //if (Application.OpenForms[i].Name != "form_login")
                        Application.OpenForms[i].Hide();
                    }
                    form_login lg = new form_login();
                    lg.ShowDialog();
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        //if (Application.OpenForms[i].Name != "form_login")
                        Application.OpenForms[i].Close();

                    }
                }
                catch
                {

                }
            }
        }
    }
}
