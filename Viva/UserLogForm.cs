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
    public partial class UserLogForm : MetroFramework.Forms.MetroForm
    {
        public UserLogForm()
        {
            InitializeComponent();
        }
        Database db;
        DataTable d;

        private void UserLogForm_Load(object sender, EventArgs e)
        {
            try
            {
                db = new Database();
                d = new DataTable();
                d = db.GetData("select l.user_id, u.name, u.user_type, l.date from [log] l inner join [user] u on l.user_id=u.user_id order by l.date desc");
                if (d.Rows.Count > 0)
                {
                    metroGrid1.DataSource = d;
                    metroGrid1.Columns[0].HeaderText = "User ID";
                    metroGrid1.Columns[1].HeaderText = "Name";
                    metroGrid1.Columns[2].HeaderText = "Type";
                    metroGrid1.Columns[3].HeaderText = "Date/Time";
                    metroGrid1.AutoResizeColumns();
                    metroGrid1.Columns[0].Width = 100;
                    metroGrid1.Columns[1].Width = 100;
                    metroGrid1.Columns[2].Width = 120;
                    metroGrid1.Columns[3].Width = 150;
                }
                metroGrid1.ClearSelection();
            }
            catch
            {
                MetroMessageBox.Show(this, "Please check your internet connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
