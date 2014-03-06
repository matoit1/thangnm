using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace nguyenmanhthang.Common
{
    public partial class DangNhap : System.Web.UI.Page
    {
        private string continueUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            continueUrl = Request.QueryString["ReturnUrl"];
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SetAuthCookie(txtID.Text,true);
            if (String.IsNullOrEmpty(continueUrl))
            {
                Response.Redirect("~/Common/DangNhap.aspx");
            }
            else
            {
                //Response.Redirect("~/" + Request.QueryString["ReturnUrl"]);
                Response.Redirect("~/Common/TrangChu.aspx");
            }
            FormsAuthentication.Authenticate(txtID.Text, txtPass.Text);
        }
    }
}