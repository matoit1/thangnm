using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongKy.ShareInterface
{
    public partial class GiangVienSI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Request.Cookies["CongKy_client"] == null)
            //    {
            //        Response.Redirect("~/Client/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString));
            //    }
            //}
            //catch
            //{
            //    Response.Cookies["CongKy_client"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Redirect("~/Client/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString));
            //}
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["CongKy_client"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}