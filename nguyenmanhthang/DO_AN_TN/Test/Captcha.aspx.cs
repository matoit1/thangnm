using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;

namespace DO_AN_TN.Test
{
    public partial class Captcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgCaptcha1.ImageUrl = new CaptchaProvider().CreateCaptcha();
            }
        }

        protected void ChangeCaptcha_Click(object sender, EventArgs e)
        {
            imgCaptcha1.ImageUrl = new CaptchaProvider().CreateCaptcha();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = Common.DocTienBangChu(Convert.ToInt64(txtInput.Text), " đồng");
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}