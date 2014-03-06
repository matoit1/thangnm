using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadInfo(Request.QueryString["Accounts_Username"]);
            }
            try {
                if (Request.Cookies["administrator"].Value != Request.QueryString["Accounts_Username"])
                {
                    pnlSecret1.Visible = false;
                    pnlSecret2.Visible = false;
                    pnlSecret3.Visible = false;
                }
            }
            catch { Response.Redirect("~/Accounts/Login.aspx"); }
        }

        public void loadInfo(String Accounts_Username)
        {
            try
            {
                DataSet ds = AccountsBO.GetAccounts_IDbyAccounts_Username(Accounts_Username);
                lblTitle.Text = "Thông tin cá nhân - " + ds.Tables[0].Rows[0]["Accounts_FullName"].ToString();
                lblAccounts_ID.Text = "ID: " + ds.Tables[0].Rows[0]["Accounts_ID"].ToString();
                lblAccounts_Username.Text = "Username: " + ds.Tables[0].Rows[0]["Accounts_Username"].ToString();
                lblAccounts_Password.Text = "Password: ********";
                lblAccounts_Email.Text = "Email: " + ds.Tables[0].Rows[0]["Accounts_Email"].ToString();
                lblAccounts_FullName.Text = "FullName: " + ds.Tables[0].Rows[0]["Accounts_FullName"].ToString();
                lblAccounts_Address.Text = "Address: " + ds.Tables[0].Rows[0]["Accounts_Address"].ToString();
                lblAccounts_DateOfBirth.Text = "DateOfBirth: " + ds.Tables[0].Rows[0]["Accounts_DateOfBirth"].ToString();
                lblAccounts_PhoneNumber.Text = "PhoneNumber: " + ds.Tables[0].Rows[0]["Accounts_PhoneNumber"].ToString();
                lblAccounts_Permission.Text = "Permission: " + ds.Tables[0].Rows[0]["Accounts_Permission"].ToString();
                lblAccounts_LinkAvatar.Text = "LinkAvatar: " + ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                lblAccounts_Signature.Text = "Signature: " + ds.Tables[0].Rows[0]["Accounts_Signature"].ToString();
                lblAccounts_Like.Text = "Like: " + ds.Tables[0].Rows[0]["Accounts_Like"].ToString();
                lblAccounts_Notification.Text = "Notification: " + ds.Tables[0].Rows[0]["Accounts_Notification"].ToString();
                lblAccounts_Status.Text = "Status: " + ds.Tables[0].Rows[0]["Accounts_Status"].ToString();
                lblAccounts_RegisterDate.Text = "RegisterDate: " + ds.Tables[0].Rows[0]["Accounts_RegisterDate"].ToString();
            }
            catch (Exception) { }
        }
    }
}