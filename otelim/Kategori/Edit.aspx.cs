using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Kategori
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = Convert.ToInt16(Request.QueryString["Id"]);
                string sql = "Select * from kategori Where KategoriId=@Id";
                SqlCommand cmd = new SqlCommand(sql, baglan.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", id);
                baglan.On();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox1.Text = dr["KategoriAdi"].ToString();
                   

                }
                baglan.Off();
            }
        }
        datam baglan=new datam();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["Id"]);
            string cumle = "update kategori set KategoriAdi=@KategoriAdi Where kategoriId=@Id";
            SqlCommand cmd = new SqlCommand(cumle, baglan.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@KategoriAdi", TextBox1.Text);
            
            cmd.Parameters.AddWithValue("@Id", id);
            baglan.On();
            cmd.ExecuteNonQuery();
            baglan.Off();
            Response.Write("Kayıt Güncellendi");
            Response.Redirect("index.aspx");
        }
    }
}