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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Viva
{
    public partial class editGarment : MetroFramework.Forms.MetroForm
    {
        public editGarment()
        {
            InitializeComponent();
            AutoComplete();
        }

        Database db;
        int mdl_qty;

        private void editGarment_Load(object sender, EventArgs e)
        {
            txt_id.ReadOnly = true;
            cmb_type.Enabled = false;
            cmb_cat.Enabled = false;
            txt_name.ReadOnly = true;
            txt_qty.ReadOnly = true;
            txt_price.ReadOnly = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_search.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Model ID to search!", "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string id = txt_search.Text;
                    id = id.Substring(0, 5);
                    db = new Database();
                    DataTable dt = db.GetData("select * from garment where model_id='" + id + "'");
                    if (dt.Rows.Count > 0)
                    {
                        cmb_type.Enabled = false;
                        cmb_cat.Enabled = true;
                        txt_name.ReadOnly = false;
                        txt_qty.ReadOnly = false;
                        txt_price.ReadOnly = false;

                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_id.Text = dr["model_id"].ToString();
                            cmb_type.SelectedItem= dr["model_type"].ToString();
                            cmb_cat.SelectedItem= dr["model_cat"].ToString();
                            txt_name.Text = dr["model_name"].ToString();
                            if (int.Parse(dr["model_qty"].ToString()) < 0)
                                txt_qty.Text = "0";
                            else
                                txt_qty.Text = dr["model_qty"].ToString();
                            txt_price.Text = dr["model_price"].ToString();
                        }                     
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There is no Garment accompanied with the given Model ID", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "There is no Garment accompanied with the given Model ID", "Invalid Model ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                mdl_qty = int.Parse(txt_qty.Text);
                if (cmb_type.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Garment Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_cat.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Garment Category!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_name.Text.Any(c => char.IsPunctuation(c)))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Name!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_qty.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Quantity!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_qty.Text.Any(c => char.IsPunctuation(c)))
                {
                    MetroMessageBox.Show(this, "Please enter a valid Quantity!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_qty.Text.Any(char.IsLetter) || Int32.Parse(txt_qty.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Please enter Quantity in positive numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_price.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_price.Text, @"^((?:[1-9]\d*)|(?:(?=[\d.]+)(?:[1-9]\d*|0)\.\d+))$"))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price in valid Format!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_price.Text.Any(char.IsLetter) || float.Parse(txt_price.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price in positive numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        update_order();
                        Database db = new Database();
                        int row = db.save_delete_update("update garment set model_type = '" + cmb_type.Text + "', model_cat = '" + cmb_cat.Text + "', model_name = '" + txt_name.Text + "', model_qty = '" + mdl_qty + "', model_price = '" + txt_price.Text + "' where model_id = '" + txt_id.Text + "'");
                        if (row == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_search.Clear();
                            txt_id.Clear();
                            cmb_type.SelectedIndex = -1;
                            cmb_cat.SelectedIndex = -1;
                            txt_name.Clear();
                            txt_qty.Clear();
                            txt_price.Clear();

                            txt_id.ReadOnly = true;
                            cmb_type.Enabled = false;
                            cmb_cat.Enabled = false;
                            txt_name.ReadOnly = true;
                            txt_qty.ReadOnly = true;
                            txt_price.ReadOnly = true;

                            
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(FormatException)
            {
                MetroMessageBox.Show(this, "Please enter Quantity in positive numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_order()
        {
            try
            {
                DataTable dt = db.GetData("select * from order_detail where model_id='" + txt_id.Text + "' and qty_pending > 0");
                foreach (DataRow dr in dt.Rows)
                {
                    int qty_p = int.Parse(dr[4].ToString());
                    if (qty_p <= mdl_qty)
                    {
                        db.save_delete_update("update order_detail set qty_pending = 0 where order_id = '" + dr[0].ToString() + "' and model_id = '" + dr[1].ToString() + "'");
                        mdl_qty = mdl_qty - qty_p;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "'"+ex.GetBaseException()+"'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txt_id.Text))
                {
                    MetroMessageBox.Show(this, "Please select Model ID!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        db = new Database();
                        int i = db.save_delete_update("delete from garment where model_id='" + txt_id.Text + "'");
                        if (i == 1)
                        {
                            txt_search.Clear();
                            txt_id.Clear();
                            cmb_type.SelectedIndex = -1;
                            cmb_cat.SelectedIndex = -1;
                            txt_name.Clear();
                            txt_qty.Clear();
                            txt_price.Clear();

                            MetroFramework.MetroMessageBox.Show(this, " Successfully deleted!", "Delete message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_id.ReadOnly = true;
                            cmb_type.Enabled = false;
                            cmb_cat.Enabled = false;
                            txt_name.ReadOnly = true;
                            txt_qty.ReadOnly = true;
                            txt_price.ReadOnly = true;

                            AutoComplete();
                        }
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_id.Clear();
            cmb_type.SelectedIndex = -1;
            cmb_cat.SelectedIndex = -1;
            txt_name.Clear();
            txt_qty.Clear();
            txt_price.Clear();

            txt_id.ReadOnly = true;
            cmb_type.Enabled = false;
            cmb_cat.Enabled = false;
            txt_name.ReadOnly = true;
            txt_qty.ReadOnly = true;
            txt_price.ReadOnly = true;
        }

        private void AutoComplete()
        {
            try
            {
                txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

                db = new Database();
                SqlDataReader dr = db.DataRead("select * from garment");
                while (dr.Read())
                {
                    string name = dr.GetString(0) + " - " + dr.GetString(3);
                    coll.Add(name);
                }

                txt_search.AutoCompleteCustomSource = coll;
            }
            catch
            {

            }

        }
    }
}
