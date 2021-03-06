﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Text.RegularExpressions;

namespace Viva
{
    
    public partial class customerReg : MetroFramework.Forms.MetroForm
    {
        
        public customerReg()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void customerReg_Load(object sender, EventArgs e)
        {
            IdIncrement();
        }
        private void IdIncrement()
        {
            try
            {
                /*DataTable dt = db.GetData("select top 1 cus_id from [customer] order by cus_id desc");
                int no = Int32.Parse(dt.Rows[0][0].ToString());
                no++;
                txt_cus_id.Text = no.ToString();*/
                DataTable dt = db.GetData("select top 1 cus_id from customer order by cus_id desc");
                string no = dt.Rows[0]["cus_id"].ToString();
                //retriving empid column last cell data.
                int len = no.Length;
                string splitno = no.Substring(1, len - 1);
                int num = Convert.ToInt32(splitno); //converting splited string in integer
                num++; //increasing splited string by 1
                no = no.Substring(0, 1) + num.ToString("0000");
                txt_cus_id.Text = no.ToString();
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            try
            {
              

                if (string.IsNullOrWhiteSpace(txt_cus_name.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cus_name.Text.Any(char.IsNumber)  )
                {
                    MetroMessageBox.Show(this, "Please enter valid Name!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cus_name.Text.Any(char.IsSymbol) || txt_cus_name.Text.Any(char.IsDigit) || Regex.Matches(txt_cus_name.Text, @"\.").Count >= 2)
                {
                    MetroMessageBox.Show(this, "Please enter a valid Name!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_cus_name.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Name can not contain apostrophe!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_cus_name.Text, @"^[a-zA-Z ]*$"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Name1!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (string.IsNullOrWhiteSpace(txt_add1.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter First Address !", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_add1.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Address!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_add2.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Second Address!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Regex.IsMatch(txt_add2.Text, @"'"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Address 2!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_cno.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Conatct Number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cno.Text.Any(char.IsWhiteSpace) || txt_cno.Text.Length != 10 || !txt_cno.Text.Any(char.IsNumber) || txt_cno.Text.Any(char.IsLetter) || txt_cno.Text.Any(char.IsPunctuation))
                {
                    MetroMessageBox.Show(this, "Please Enter Contact Number in Numeric!\nContact Number should contain 10 Numbers!!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cno.Focus();
                }
                else if (!Regex.IsMatch(txt_cno.Text, @"\d+$"))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Contact Number!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Int32.Parse(txt_cno.Text) < 0)
                {
                    MetroMessageBox.Show(this, "Please enter Contact Number in valid format!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cno.Focus();
                }
              
                
               
                else
                {
                   
                        int ret = db.save_delete_update("insert into customer values('" + txt_cus_id.Text + "', '" + txt_cus_name.Text + "', '" + txt_add1.Text + "', '" + txt_add2.Text + "', '" + txt_cno.Text + "')");
                        if (ret == 1)
                        {
                            MetroMessageBox.Show(this, "Successfully New Customer Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            IdIncrement();

                        txt_cus_name.Clear();
                        txt_add1.Clear();
                        txt_add2.Clear();
                        txt_cno.Clear();

                    }
                        else
                        {
                            MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "'" + ex.GetBaseException() + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
            txt_cus_name.Clear();
            txt_add1.Clear();
            txt_add2.Clear();
            txt_cno.Clear();
        }
    }
}
