using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viva
{
    public partial class ResetPwd : MetroFramework.Forms.MetroForm
    {
        public ResetPwd()
        {
            InitializeComponent();
        }

        private void ResetPwd_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        Database db = new Database();

        private void ClearText()
        {
            txt_user_id.Clear();
            txt_search.Focus();
            txt_search.Clear();
            txt_uname.Clear();
            txt_tele.Clear();
            txt_pwd.Clear();
            txt_cpwd.Clear();
            txt_mngr_uname.Clear();
            txt_mngr_pwd.Clear();
            txt_name.Clear();
            cmb_type.SelectedIndex = -1;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txt_search.Text))
                {
                    MetroMessageBox.Show(this, "Please enter User Name or ID!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = db.GetData("select * from [user] where user_name='" + txt_search.Text + "' or user_id='" + txt_search.Text + "'");
                    if (dt.Rows.Count < 1)
                    {
                        MetroMessageBox.Show(this, "There is no User accompanied with the given User Name or ID", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txt_user_id.Text = dt.Rows[0][0].ToString();
                        txt_uname.Text = dt.Rows[0][1].ToString();
                        cmb_type.SelectedItem = dt.Rows[0][2].ToString();
                        txt_tele.Text = dt.Rows[0][3].ToString();
                        txt_name.Text = dt.Rows[0][5].ToString();
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_pwd.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Password!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_pwd.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Password can not contain apostrophe!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_pwd.Text.Length < 8)
                {
                    MetroMessageBox.Show(this, "Password should contain more than 8 Letters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_cpwd.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Confirm Password!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cpwd.Text != txt_pwd.Text)
                {
                    MetroMessageBox.Show(this, "Please enter same Password to Confirm!", "Password not same", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_mngr_uname.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Manager User Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_mngr_pwd.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Manager Password!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_mngr_uname.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Please check Manager Username and Password!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_mngr_pwd.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Please check Manager Username and Password!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = db.GetData("select * from [user] where user_name='" + txt_mngr_uname.Text + "' and user_pwd COLLATE Latin1_General_CS_AS = '" + txt_mngr_pwd.Text + "' and user_type='Manager'");
                    if (dt.Rows.Count == 1)
                    {
                        int ret = db.save_delete_update("update [user] set user_pwd='"+txt_cpwd.Text+"' where user_id='"+txt_user_id.Text+"'");
                        if (ret == 1)
                        {
                            MetroMessageBox.Show(this, "Successfully Password Resetted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearText();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Please check Manager Username and Password!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
