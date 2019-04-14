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
    public partial class AddUser : MetroFramework.Forms.MetroForm
    {
        public AddUser()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void AddUser_Load(object sender, EventArgs e)
        {
            IdIncrement();
        }

        private void IdIncrement()
        {
            txt_uname.Focus();
            DataTable dt = db.GetData("select top 1 user_id from [user] order by user_id desc");
            int no = Int32.Parse(dt.Rows[0][0].ToString());
            no++;
            txt_user_id.Text = no.ToString();
        }

        private void ClearText()
        {
            txt_uname.Focus();
            txt_uname.Clear();
            txt_tele.Clear();
            txt_pwd.Clear();
            txt_cpwd.Clear();
            txt_mngr_uname.Clear();
            txt_mngr_pwd.Clear();
            cmb_type.SelectedIndex = -1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            try
            {
                if (string.IsNullOrWhiteSpace(txt_uname.Text))
                {
                    MetroMessageBox.Show(this, "Please enter User Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_type.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select User Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_tele.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Conatct Number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_tele.Text.Any(char.IsWhiteSpace) || txt_tele.Text.Length != 10 || !txt_tele.Text.Any(char.IsNumber) || txt_tele.Text.Any(char.IsLetter))
                {
                    MetroMessageBox.Show(this, "Please Enter Contact Number in Numeric!\nContact Number should contain 10 Numbers!!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tele.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txt_pwd.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Password!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    DataTable dt = db.GetData("select * from [user] where user_name='" + txt_mngr_uname.Text + "' and user_pwd COLLATE Latin1_General_CS_AS = '" + txt_mngr_pwd.Text + "' and user_type='Manager'");
                    if (dt.Rows.Count == 1)
                    {
                        int ret = db.save_delete_update("insert into [user] values('" + txt_user_id.Text + "', '" + txt_uname.Text + "', '" + cmb_type.Text + "', '" + txt_tele.Text + "', '" + txt_cpwd.Text + "')");
                        if (ret == 1)
                        {
                            MetroMessageBox.Show(this, "Successfully New User Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            IdIncrement();

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
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "'" + ex.GetBaseException() + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
