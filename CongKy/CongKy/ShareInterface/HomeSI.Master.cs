using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongKy.ShareInterface
{
    public partial class HomeSI : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Request.Cookies["CongKy_client"] == null)
            //    {
            //        lbtnLogout.Visible = false;
            //        lbtnLogin.Text = "Đăng nhập";
            //        lbtnLogin.PostBackUrl = "~/Client/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString);
            //    }
            //    else
            //    {
            //        lbtnLogout.Visible = true;
            //        lbtnLogin.Text = "Xin chào " + Request.Cookies["CongKy_client"].Value;
            //        lbtnLogin.PostBackUrl = "~/Client/ThongTinCaNhan.aspx";
            //    }
            //}
            //catch { }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["CongKy_client"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}