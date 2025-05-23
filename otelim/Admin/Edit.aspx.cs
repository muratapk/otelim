using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Admin
{
    public partial class Edit : System.Web.UI.Page
    {
        datam baglan = new datam();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
     
                    int id =Convert.ToInt16(Request.QueryString["Id"]);
                    string sql = "Select * from Admin Where AdminId=@Id";
                    SqlCommand cmd = new SqlCommand(sql, baglan.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id", id);
                    baglan.On();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        TextBox1.Text = dr["Kul"].ToString();
                        TextBox2.Text = dr["Sifre"].ToString();
                        TextBox3.Text = dr["Yetki"].ToString();
                    }
                    baglan.Off();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["Id"]);
            string cumle = "update admin set Kul=@Kul,Sifre=@Sifre,Yetki=@Yetki Where AdminId=@Id";
            SqlCommand cmd = new SqlCommand(cumle, baglan.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Kul", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Yetki", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Id", id);
            baglan.On();
            cmd.ExecuteNonQuery();
            baglan.Off();
            Response.Write("Kayıt Güncellendi");
            Response.Redirect("index.aspx");
        }
    }
}