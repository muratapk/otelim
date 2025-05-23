using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Ozellik
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        datam data = new datam();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into ozellikler(OzelAd,OzelSimge) values (@OzelAd,@OzelSimge)";
            Dictionary<string,object> dic= new Dictionary<string,object>();
            dic.Add("@OzelAd", TextBox1.Text);
            dic.Add("OzelSimge", TextBox2.Text);
            data.Sorgu(cumle, dic);
        }
    }
}