using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { }
        }

        protected void lbtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Accounts_Username = txtAccounts_Username.Text;
                string Accounts_Password = Encrypt.Crypt(txtAccounts_Password.Text);
                DataSet temp = AccountsBO.Accounts_Login(Accounts_Username, Accounts_Password);
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
                        Response.Redirect("../Admin/Default.aspx");
                    }
                    else
                    {
                        Response.Redirect(url1);
                    }
                }
                else
                {
                    lblMsg.Text = "Sai tên tài khoản hoặc mật khẩu.";
                    lblMsg.CssClass = "error";
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}