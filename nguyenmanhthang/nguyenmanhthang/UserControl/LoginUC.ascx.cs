using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang.UserControl
{
    public partial class LoginUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Accounts_Username = txtAccounts_Username.Text;
                string Accounts_Password = Encrypt.Crypt(txtAccounts_Password.Text);
                DataSet temp = AccountsBO.Login(Accounts_Username, Accounts_Password);
                if (temp.Tables[0].Rows.Count > 0)
                {
                    Response.Cookies["administrator"].Value = Accounts_Username;
                    if (chkRememberMe.Checked == true)
                    {
                        Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(10);
                    }
                    else
                    {
                        Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(1);
                    }
                    string url1 = (String)Session["url1"];
                    if (Session["url1"] == null)
                    {
                        Response.Redirect("~/Admin/Default.aspx");
                    }
                    else
                    {
                        Response.Redirect(url1);
                    }
                }
                else
                {
                    lblMsg.Text = "Sai tài khoản / mật khẩu";
                    lblMsg.CssClass = "notificationError";
                }
            }
            catch (Exception ex) { lblMsg.Text = ex.ToString(); }
        }
    }
}