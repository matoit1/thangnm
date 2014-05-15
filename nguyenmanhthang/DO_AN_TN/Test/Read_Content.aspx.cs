using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using Shared_Libraries;

namespace DO_AN_TN.Test
{
    public partial class Read_Content : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string data = Common.ReadTextFromUrl("http://account.dev.ehou.edu.vn/auth/checkssotoken/"+ Request.Cookies["LOGINID"].Value);
                JObject o = JObject.Parse(data);
                if (o["username"] != null)
                {
                    lblResuit.Text = "Xin chào " + o["username"];
                    hplLogin.Visible = false;
                }
                else{
                    lblResuit.Text = "Bạn chưa đăng nhập!";
                    hplLogin.Visible = true;
                }
            }
            catch { 
                lblResuit.Text = "Bạn chưa đăng nhập!";
                hplLogin.Visible = true;
            }
        }
    }
}