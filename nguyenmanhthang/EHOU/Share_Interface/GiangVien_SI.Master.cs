using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using Newtonsoft.Json.Linq;
using Shared_Libraries.Constants;

namespace EHOU.Share_Interface
{
    public partial class GiangVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                JObject objAcc = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value);
                if (objAcc["username"] != null &&  Convert.ToInt16(objAcc["type"]) == tblAccount_iType_C.Giang_Vien)
                {
                    //Session["account_gv"] = objAcc["username"];
                }
                else
                {
                    Response.Redirect("https://account.dev.ehou.edu.vn/auth");
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("https://account.dev.ehou.edu.vn/auth");
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["LOGINID"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}