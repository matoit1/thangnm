using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;
using Shared_Libraries;
using Newtonsoft.Json.Linq;

namespace EHOU.Share_Interface
{
    public partial class SinhVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            Session["account_sv"] = "sv1";
            //try
            //{
            //    string data = Common.ReadTextFromUrl("http://account.dev.ehou.edu.vn/auth/checkssotoken/" + Request.Cookies["LOGINID"].Value);
            //    JObject o = JObject.Parse(data);
            //    if (o["username"] == null)
            //    {
            //        //Success!
            //        Session["account"] = o["username"];
            //    }
            //    else
            //    {
            //        //Fail!
            //        Response.Redirect("https://account.dev.ehou.edu.vn/auth");
            //    }
            //}
            //catch
            //{
            //    //Error!
            //    Response.Redirect("https://account.dev.ehou.edu.vn/auth");
            //}
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["sinhvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}