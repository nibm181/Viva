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
    public partial class AddGarment : MetroFramework.Forms.MetroForm
    {
        public AddGarment()
        {
            InitializeComponent();
        }

        private void AddGarment_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.save_delete_update("insert into tbl_garment values('1006', 'skirt','shabee', 1000, 1000)");
        }
    }
}
