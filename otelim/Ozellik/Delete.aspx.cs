using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otelim.Ozellik
{
    public partial class Delete : System.Web.UI.Page
    {
        datam data=new datam();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);
            string cumle = "Delete from ozellik where UyeId=@UyeId";
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@id", Id);
            data.Sorgu(cumle, dic);
        }
    }
}