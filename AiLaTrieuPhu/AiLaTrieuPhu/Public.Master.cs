using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AiLaTrieuPhu.Library;
using System.Data;

namespace AiLaTrieuPhu
{
    public partial class Public : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["acc"] == null)
                {
                    Session["url1"] = Request.Url.AbsolutePath;
                    Response.Redirect("~/Accounts/Login.aspx");
                }
                DataSet ds = TaikhoanDAO.Search(Request.Cookies["acc"].Value);
            }
            catch
            {
                Response.Cookies["acc"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("~/Accounts/Login.aspx");
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)     // Xu y su kien cho buttom Logout
        {
                Response.Cookies["acc"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}