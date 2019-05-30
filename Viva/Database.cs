using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace Viva
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public Database()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=tcp:nibmgarments.database.windows.net,1433;Initial Catalog=Garments;Persist Security Info=False;User ID=doof;Password=warrior@00;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public void openCon()
        {
            con.Open();
        }
        public void closeCon()
        {
            con.Close();
        }
        public int save_delete_update(string query)
        {
            int row;
            try
            {
                openCon();
            }
            catch
            {
                MessageBox.Show("Please check your database connection");
            }
            cmd = new SqlCommand(query, con);
            row = cmd.ExecuteNonQuery();
            cmd.Dispose();
            closeCon();
            return row;
        }
        public DataTable GetData(string query)
        {
            try
            {
                openCon();
            }
            catch
            {
                MessageBox.Show("Check your database connection");
            }
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeCon();
            return dt;
        }
        public SqlDataReader DataRead(string query)
        {
            try
            {
                openCon();
            }
            catch
            {
                MessageBox.Show("Check your database connection");
            }
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
    }
}
