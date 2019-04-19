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
    public partial class Order2 : MetroFramework.Forms.MetroForm
    {
        public Order2(String cusno)
        {
            InitializeComponent();
            txt_cus_id.Text = cusno;
        }

        private void Order2_Load(object sender, EventArgs e)
        {
            
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
