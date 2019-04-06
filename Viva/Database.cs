using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Viva
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public Database()
        {
            con = new SqlConnection();
            con.ConnectionString= "DESKTOP-3HUH0OS (DESKTOP-3HUH0OS\\Mhd Fazil)";
        }

    }
}
