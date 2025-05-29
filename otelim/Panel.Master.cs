using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim
{
    public partial class Panel : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"]==null && Session["Sifre"]==null)
            {
                Response.Redirect("../Login/Index.aspx");
            }
        }
    }
}