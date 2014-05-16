using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using Newtonsoft.Json.Linq;

namespace EHOU.Share_Interface
{
    public partial class GiangVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //Session["account_gv"] = "gv1";
            try
            {
                string data = Common.ReadTextFromUrl("http://account.dev.ehou.edu.vn/auth/checkssotoken/" + Request.Cookies["LOGINID"].Value);
                JObject o = JObject.Parse(data);
                if (o["username"] != null && o["type"].ToString() == "2")
                {
                    //Success!
                    Session["account_gv"] = o["username"];
                }
                else
                {
                    //Fail!
                    //Response.Write("<script>alert('Error 1: " + o["username"] + "')</script>");
                    Response.Redirect("https://account.dev.ehou.edu.vn/auth");
                }
            }
            catch (Exception ex)
            {
                //Error!
                Response.Redirect("https://account.dev.ehou.edu.vn/auth");
            }


            //try
            //{
            //    if (Request.Cookies["giangvien"] == null)
            //    {
            //        Response.Redirect("~/GiangVien/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
            //    }
            //    //lblInfo.Text = "   Hi, " + Request.Cookies["giangvien"].Value;
            //}
            //catch
            //{
            //    Response.Cookies["giangvien"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Redirect("~/GiangVien/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
            //}
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["giangvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}