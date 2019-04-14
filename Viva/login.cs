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
                SqlDataReader dr = db.DataRead("select * from [user] where user_name='" + txt_Uname.Text + "' and user_pwd COLLATE Latin1_General_CS_AS = '" + txt_Pword.Text + "'");
                if (dr.Read())
                {
                    if(dr.GetString(2) == "Manager")
                    {
                        this.Hide();
                        manager_home mngrf_form = new manager_home();
                        mngrf_form.ShowDialog();                        
                        this.Close();
                    }
                    else if(dr.GetString(2) == "Admin")
                    {
                        this.Hide();
                        stock_admin_home admin_form = new stock_admin_home();
                        admin_form.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Please check your Username and Password!", "OOps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
