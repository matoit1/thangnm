using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using BusinessObject;
using System.Web.Caching;

namespace ThangNMjsc.Accounts
{
    public partial class Login1 : System.Web.UI.Page
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
                DataSet temp = AccountsBO.setLoginAccounts(Accounts_Username, Accounts_Password);
                if (temp.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(temp.Tables[0].Rows[0]["Accounts_Permission"]) > 0)
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
                        Response.Cookies["client"].Value = Accounts_Username;
                        if (chkRememberMe.Checked == true)
                        {
                            Response.Cookies["client"].Expires = DateTime.Now.AddDays(10);
                        }
                        else
                        {
                            Response.Cookies["client"].Expires = DateTime.Now.AddDays(1);
                        }
                        string url2 = (String)Session["url2"];
                        if (Session["url2"] == null)
                        {
                            Response.Redirect("../Customer/Default.aspx");
                        }
                        else
                        {
                            Response.Redirect(url2);
                        }
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