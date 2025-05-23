using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Uyelik
{
    public partial class Edit : System.Web.UI.Page
    {
        datam baglan=new datam();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int Id = Convert.ToInt16(Request.QueryString["Id"]);
                string cumle = "Select * from uyelik where UyeId=@Id";
                SqlCommand cmd = new SqlCommand(cumle, baglan.conn);
                cmd.Parameters.Clear();
                SqlDataReader dr;
                baglan.On();
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    TextBox1.Text = dr["UyeAd"].ToString();
                    TextBox2.Text = dr["Cep"].ToString();
                    TextBox3.Text = dr["Mail"].ToString();
                    TextBox4.Text = dr["Kul"].ToString();
                    TextBox5.Text = dr["Sifre"].ToString();

                }
                baglan.Off();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(Request.QueryString["Id"]);
            string cumle = "update uyelik set UyeAd=@UyeAd,Cep=@Cep,Mail=@Mail,Kul=@Kul,Sifre=@Sifre where UyeId=@Id";
            SqlCommand cmd = new SqlCommand(cumle, baglan.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@UyeAd", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Cep", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Mail", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Kul", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Sifre", TextBox5.Text);
            baglan.On();
            cmd.ExecuteNonQuery();
            baglan.Off();
            Response.Write("<script>alert('Kayıt Güncellendi')</script>");
        }
    }
}