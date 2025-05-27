using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Ozellik
{
    public partial class Edit : System.Web.UI.Page
    {
        datam baglan = new datam();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                baglan.On();
                int id = Convert.ToInt16(Request.QueryString["Id"]);
                string cumle = "Select * from ozellikler where OzelId=@Id";
                var param = new Dictionary<string, object>
                {
                    {"@Id",id }
                };



                SqlDataReader dr = baglan.TReader(cumle, param);
                if(dr.Read())
                {
                    TextBox1.Text = dr["OzelAd"].ToString();
                    TextBox2.Text = dr["OzelSimge"].ToString();
                }
                baglan.Off();

            }
        }
    }
}