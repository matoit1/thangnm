using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;

namespace EHOU.Share_Interface
{
    public partial class SinhVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["sinhvien"] == null)
                {
                    Response.Redirect("~/SinhVien/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
                }
                //lblInfo.Text = "   Hi, " + Request.Cookies["sinhvien"].Value;
            }
            catch
            {
                Response.Cookies["sinhvien"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("~/SinhVien/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["sinhvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}