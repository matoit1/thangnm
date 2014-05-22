using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HaBa.ShareInterface
{
    public partial class AdminSI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["HaBa_admin"] == null)
                {
                    Response.Redirect("~/Admin/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString));
                }
                //lblInfo.Text = "   Hi, " + Request.Cookies["quantri"].Value;
            }
            catch
            {
                Response.Cookies["HaBa_admin"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("~/Admin/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString));
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["HaBa_admin"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}