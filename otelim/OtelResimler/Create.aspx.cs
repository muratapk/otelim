using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.WebSockets;

namespace otelim.OtelResimler
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cumle = "select OtelId,OtelAdi from otel";
            DropDownList1.DataSource = baglan.Tablom(cumle);
            DropDownList1.DataTextField = "OtelAdi";
            DropDownList1.DataValueField = "OtelId";
            DropDownList1.DataBind();
            


        }
        datam baglan = new datam();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                string fileName =Path.GetFileName(FileUpload1.FileName);
                //dosya adı
                int fileSize=FileUpload1.PostedFile.ContentLength;
                //dosya boyutu
                string fileType=FileUpload1.PostedFile.ContentType;
                //dosya tipi
                string extension = Path.GetExtension(FileUpload1.FileName).ToLower();
                //uzantısı jpg gif png excel vb.
                string[] allowType = { ".jpg", ".png", ".jpeg", ".gif" };
                if(Array.IndexOf(allowType,extension)==-1 ) 
                {
                    Label1.Text = "Dosya jpg png gif olmalıdır";
                    Label1.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                string newName=Guid.NewGuid().ToString()+extension;
                string uploadPath = Server.MapPath("~/Images/");
                if(!Directory.Exists(uploadPath)) {
                    Directory.CreateDirectory(uploadPath);
                  }
                //boyle bir klasör yoksa oluştur
                string filePath=Path.Combine(uploadPath,fileName);
                //dosya full klasör/dosya/
                FileUpload1.SaveAs(filePath);
                string cumle = "insert into otelresimler (OtelId,ResimAdi,ResimYolu) values (@OtelId,@ResimAdi,@ResimYolu) ";
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("@ResimAdi", TextBox1.Text);
                dic.Add("@ResimYolu", newName);
                dic.Add("@OtelId", DropDownList1.SelectedValue);
                baglan.Sorgu(cumle, dic);
                Label1.Text = "Kayıt Yapıldı";
            }
            else
            {
                Label1.Text = "Resim Seçmediniz";
            }
        }
    }
}