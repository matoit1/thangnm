using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHOU.Share_Interface
{
    public partial class QuanTri_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["quantri"] == null)
                {
                    Response.Redirect("~/QuanTri/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
                }
                //lblInfo.Text = "   Hi, " + Request.Cookies["quantri"].Value;
            }
            catch
            {
                Response.Cookies["quantri"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("~/QuanTri/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["quantri"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}