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
    public partial class editGarment : MetroFramework.Forms.MetroForm
    {
        public editGarment()
        {
            InitializeComponent();
        }

        private void autoComplete()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        Database db;

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
                if (string.IsNullOrEmpty(txt_search.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Model ID to search!", "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db = new Database();
                    DataTable dt = db.GetData("select * from tbl_garment where model_id='" + txt_search.Text + "'");
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
                MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_type.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Garment Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_cat.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Please select Garment Meterial!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_name.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_qty.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Quantity!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_qty.Text.Any(char.IsLetter))
                {
                    MetroMessageBox.Show(this, "Please enter Quantity in numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_price.Text))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_price.Text.Any(char.IsLetter))
                {
                    MetroMessageBox.Show(this, "Please enter Garment Price in numbers!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Database db = new Database();
                        int row = db.save_delete_update("update tbl_garment set model_type = '" + cmb_type.Text + "', model_cat = '" + cmb_cat.Text + "', model_name = '" + txt_name.Text + "', model_qty = '" + txt_qty.Text + "', model_price = '" + txt_price.Text + "' where model_id = '" + txt_id.Text + "'");
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
            catch
            {
                MetroMessageBox.Show(this, "Connection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_id.Text))
                {
                    MetroMessageBox.Show(this, "Please select Model ID!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        db = new Database();
                        int i = db.save_delete_update("delete from tbl_garment where model_id='" + txt_id.Text + "'");
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
    }
}
