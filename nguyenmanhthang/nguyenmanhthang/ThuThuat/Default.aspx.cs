using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Threading;

namespace nguyenmanhthang.ThuThuat
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                captchaImage.ImageUrl = new CaptchaProvider().CreateCaptcha();
            }
            
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            CaptchaProvider captchaPro = new CaptchaProvider();
            if (captchaPro.IsValidCode(txtInputString.Text))
            {
                //your code
                Response.Write("Is valid code");
            }
            else
            {
                ////your code
                Response.Write("Invalid code");
            }
        }
        protected void btnRedefine_Click(object sender, EventArgs e)
        {
            Response.Redirect(this.Request.Url.AbsoluteUri);
        }

        protected void TimeDeleteFileImageCaptcha_Tick(object sender, EventArgs e)
        {
            //File.Delete(Server.MapPath(captchaImage.ImageUrl));
        }
    }
}