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
    public partial class material_search : MetroFramework.Forms.MetroForm
    {
        public material_search()
        {
            InitializeComponent();
        }

        private void material_search_Load(object sender, EventArgs e)
        {

        }

        private void btn_ms__search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ms__search.Text))
            {
                MetroMessageBox.Show(this, "Please Enter Material Name or ID or Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string search = txt_ms__search.Text;
                Database db = new Database();
                DataTable d = new DataTable();
                d = db.GetData("select mat_id, mat_name, mat_type, mat_length, mat_price from materials where mat_type like '" + search + "' or mat_name like '" + search + "' or mat_id like '" + search + "'");
                grd_mat_search.DataSource = d;
                grd_mat_search.Columns[0].Name = "Material ID";
                grd_mat_search.Columns[1].Name = "Name";
                grd_mat_search.Columns[2].Name = "Type";
                grd_mat_search.Columns[3].Name = "Length";
                grd_mat_search.Columns[4].Name = "Price per Unit";
            }
        }
    }
}