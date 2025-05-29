using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Login
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        datam baglan = new datam();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string cumle = "Select * from admin where kul=@kul and sifre=@sifre";
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("@kul", TextBox1.Text);
            dic.Add("@sifre", TextBox2.Text);
            SqlDataReader dr = baglan.TReader(cumle, dic);
            if(dr.HasRows)
            {
                Session["Kullanici"] = TextBox1.Text;
                Session["Sifre"] = TextBox2.Text;
                Response.Redirect("/Admin/Index.aspx");
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}