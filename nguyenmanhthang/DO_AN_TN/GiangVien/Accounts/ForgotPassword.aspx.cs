using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN.GiangVien.Accounts
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ForgotPasswordUC1.login_url = Request.Url.Host + "/GiangVien/Accounts/Login.aspx";
        }
    }
}