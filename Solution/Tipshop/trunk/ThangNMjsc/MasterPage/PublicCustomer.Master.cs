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
using System.Collections;


namespace ThangNMjsc.MasterPage
{
    public partial class PublicCustomer : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["client"] == null)
                {
                    Session["url2"] = Request.Url.AbsolutePath;
                    Response.Redirect("~/Accounts/Login.aspx");
                }
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["client"].Value);
                imgAvatar.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                lblWelcome.Text = "   Hi, " + ds.Tables[0].Rows[0]["Accounts_Fullname"].ToString();// xuất lời chào.
                hpEditAccount.NavigateUrl = "~/Customer/Profile.aspx";
            }
            catch
            {
                Response.Cookies["client"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("~/Accounts/Login.aspx");
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["client"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}