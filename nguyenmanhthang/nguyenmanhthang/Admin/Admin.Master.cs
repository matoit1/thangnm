using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Data;

namespace nguyenmanhthang.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Request.Cookies["administrator"] == null)
            //    {
            //        Session["url1"] = Request.Url.AbsolutePath;
            //        Response.Redirect("~/Accounts/Login.aspx");
            //    }
            //    DataSet ds = AccountsBO.getAccountsbyUsername(Request.Cookies["administrator"].Value);
            //    imgAvatar.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString(); ;
            //    lblWelcome.Text = "   Hi, " + ds.Tables[0].Rows[0]["Accounts_Fullname"].ToString(); ;// xuất lời chào.
            //    hpEditAccount.NavigateUrl = "~/Admin/Edit/EditAccounts.aspx?Accounts_Username=" + Request.Cookies["administrator"].Value;
            //}
            //catch
            //{
            //    Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Redirect("~/Accounts/Login.aspx");
            //}
        }

        //protected void lbtnLogout_Click(object sender, EventArgs e)
        //{
        //    Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(-1);
        //    Response.Redirect(Request.Url.AbsolutePath);
        //}
    }
}