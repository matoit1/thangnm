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
using Shared_Libraries.Constants;

namespace EHOU.Share_Interface
{
    public partial class SinhVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    JObject objAcc = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value);
            //    if (objAcc["username"] != null && Convert.ToInt16(objAcc["type"]) == tblAccount_iType_C.Sinh_Vien)
            //    {
            //        //Session["account_sv"] = objAcc["username"];
            //    }
            //    else
            //    {
            //        Response.Redirect("https://account.dev.ehou.edu.vn/auth");
            //    }
            //}
            //catch (Exception ex)
            //{
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