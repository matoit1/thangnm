using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharedLibraries;
using System.Data;

namespace tydyShop.Admin.Accounts
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginUC1.hplLost.NavigateUrl = "~/Admin/Accounts/ForgotPassword.aspx";
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsInput = null;
                dsInput = LoginUC1.Check(3);
                if (dsInput.Tables[0].Rows.Count > 0)
                {
                    Response.Cookies["tydyshop_secret"].Value = LoginUC1.txtsTendangnhap.Text;
                    if (LoginUC1.chkRememberMe.Checked == true)
                    {
                        Response.Cookies["tydyshop_secret"].Expires = DateTime.Now.AddDays(10);
                    }
                    else
                    {
                        Response.Cookies["tydyshop_secret"].Expires = DateTime.Now.AddDays(1);
                    }
                    if (Request.QueryString["Return_Url"] == null)
                    {
                        Response.Redirect("~/Admin/Default.aspx");
                    }
                    else
                    {
                        Response.Redirect(Request.QueryString["Return_Url"].ToString());
                    }
                }
                else
                {
                    LoginUC1.lblMsg.Text = Messages.Dang_Nhap_That_Bai;
                }
            }
            catch (Exception ex)
            {
                LoginUC1.lblMsg.Text = ex.Message;
            }
        }
    }
}