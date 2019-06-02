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
using System.Data.SqlClient;

namespace Viva
{
    public partial class form_login : MetroFramework.Forms.MetroForm
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Uname.Text))
            {
                MetroMessageBox.Show(this, "Please enter User Name!", "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Uname.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txt_Pword.Text))
            {
                MetroMessageBox.Show(this, "Please enter Password!", "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pword.Focus();
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.GetData("select * from [user] where user_name='" + txt_Uname.Text + "' and user_pwd COLLATE Latin1_General_CS_AS = '" + txt_Pword.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][2].ToString() == "Manager")
                    {
                        db.save_delete_update("insert into log values('" + dt.Rows[0][0] + "', '" + DateTime.Now + "')");

                        this.Hide();
                        manager_home mngrf_form = new manager_home();
                        mngrf_form.ShowDialog();
                        this.Close();

                    }
                    else if (dt.Rows[0][2].ToString() == "Stock Admin")
                    {
                        db.save_delete_update("insert into log values('" + dt.Rows[0][0] + "', '" + DateTime.Now + "')");

                        this.Hide();
                        stock_admin_home admin_form = new stock_admin_home();
                        admin_form.ShowDialog();
                        this.Close();
                    }
                    else if (dt.Rows[0][2].ToString() == "Sales Clerk")
                    {
                        db.save_delete_update("insert into log values('" + dt.Rows[0][0] + "', '" + DateTime.Now + "')");

                        this.Hide();
                        sales_clerk_home clerk_form = new sales_clerk_home();
                        clerk_form.ShowDialog();
                        this.Close();
                    }
                    else if (dt.Rows[0][2].ToString() == "Cutter")
                    {
                        db.save_delete_update("insert into log values('" + dt.Rows[0][0] + "', '" + DateTime.Now + "')");

                        this.Hide();
                        stock_admin_home cut_form = new stock_admin_home();
                        cut_form.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Please check your Username and Password!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_forgotpwd_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "LogIn as Manager to reset Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
