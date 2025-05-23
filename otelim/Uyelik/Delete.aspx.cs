using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Uyelik
{
    public partial class Delete : System.Web.UI.Page
    {
        datam baglan=new datam();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);
            string cumle = "Delete from uyelik where UyeId=@Id";
            SqlCommand cmd = new SqlCommand(cumle, baglan.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", Id);
            baglan.On();
            cmd.ExecuteNonQuery();
            baglan.Off();
            Response.Write("<script>alert('Kayıt Silindi')</script>");
        }
    }
}