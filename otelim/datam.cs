using System;
using System.Collections.Generic;
using System.Data;
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
        public void Sorgu(string cumle,Dictionary<string,object> data)
        {
            SqlCommand cmd = new SqlCommand(cumle, this.conn);
            cmd.Parameters.Clear();
            foreach(var item in data)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);  
            }
            this.On();
            cmd.ExecuteNonQuery();
            this.Off();
        }
        public DataTable Tablom(string cumle)
        {
            SqlCommand cmd = new SqlCommand(cumle, this.conn);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TTablom(string cumle,Dictionary<string,object>data)
        {
            SqlCommand cmd = new SqlCommand(cumle, this.conn);
            cmd.Parameters.Clear();
            foreach(var item in data)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader TReader(string cumle,Dictionary<string,object>data)
        {
            this.On();
            SqlCommand cmd=new SqlCommand(cumle,this.conn);
            cmd.Parameters.Clear();
            foreach(var item in data)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            return cmd.ExecuteReader();
            this.Off();

        }
    }
}