using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using Newtonsoft.Json.Linq;

namespace DO_AN_TN.EHOU
{
    public partial class HocTap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string data = Common.ReadTextFromUrl("http://account.dev.ehou.edu.vn/auth/checkssotoken/" + Request.Cookies["LOGINID"].Value);
                JObject o = JObject.Parse(data);
                if (o["username"] != null)
                {
                    lblResuit.Text = "Xin chào " + o["username"];
                    //hplLogin.Visible = false;
                }
                else
                {
                    Response.Redirect("https://account.dev.ehou.edu.vn/auth");
                }
            }
            catch
            {
                Response.Redirect("https://account.dev.ehou.edu.vn/auth");
                //lblResuit.Text = "Bạn chưa đăng nhập!";
                //hplLogin.Visible = true;
            }
        }
    }
}