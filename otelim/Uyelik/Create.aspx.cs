using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Uyelik
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        datam baglan = new datam();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into uyelik (UyeAd,Cep,Mail,Kul,Sifre) values (@UyeAd,@Cep,@Mail,@Kul,@Sifre)";
            SqlCommand cmd = new SqlCommand(cumle,baglan.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@UyeAd", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Cep", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Mail", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Kul", TextBox4.Text);

            cmd.Parameters.AddWithValue("@Sifre", TextBox5.Text);
            baglan.On();
            cmd.ExecuteNonQuery();
            baglan.Off();
            Response.Write("<script> alert('Kayıt Yapıldı') </script>");

        }
    }
}