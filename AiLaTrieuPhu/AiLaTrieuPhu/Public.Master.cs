using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AiLaTrieuPhu
{
    public partial class Public : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnLogout_Click(object sender, EventArgs e)     // Xu y su kien cho buttom Logout
        {
            if (Response.Cookies["administrator"] == null)
            {
                Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect(Request.Url.AbsolutePath);
            }
            else
            {
                Response.Cookies["client"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect(Request.Url.AbsolutePath);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}