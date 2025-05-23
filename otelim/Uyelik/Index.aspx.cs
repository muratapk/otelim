using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Uyelik
{
    public partial class Index : System.Web.UI.Page
    {
        datam baglan=new datam();
        protected void Page_Load(object sender, EventArgs e)
        {
            string cumle = "Select * from uyelik";
            SqlCommand cmd=new SqlCommand(cumle,baglan.conn);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}