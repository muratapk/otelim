using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace otelim
{
    public class datam
    {
        private string cumle = "Data Source=DESKTOP-GRV4CB6\\SQLEXPRESS;Initial Catalog=traveldb;Integrated Security=True;TrustServerCertificate=True";
        public SqlConnection conn;

        public datam()
        {
            conn = new SqlConnection(cumle);
        }
        public void On()
        {
            if(conn.State==System.Data.ConnectionState.Closed) {
                conn.Open();
               }
        }
        public void Off()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}