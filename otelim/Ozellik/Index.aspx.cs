using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Ozellik
{
    public partial class Index : System.Web.UI.Page
    {
        datam data=new datam();
        protected void Page_Load(object sender, EventArgs e)
        {
            string cumle = "Select * from ozellikler";
            GridView1.DataSource = data.Tablom(cumle);
            GridView1.DataBind();
        }
    }
}