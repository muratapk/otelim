using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Admin
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        datam baglan = new datam();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into admin (Kul,Sifre,Yetki) values (@Kul,@Sifre,@Yetki)";
            SqlCommand cmd = new SqlCommand(cumle, baglan.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Kul", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Yetki", TextBox3.Text);
            baglan.On();
            cmd.ExecuteNonQuery();
            baglan.Off();
            Response.Write("Kayıt Yapıldı");


        }
    }
}