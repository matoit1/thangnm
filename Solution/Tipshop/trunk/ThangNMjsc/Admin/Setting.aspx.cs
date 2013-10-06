using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Admin
{
    public partial class Setting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadSetting();
            }
        }

        private void loadSetting()
        {
            try
            {
                DataTable dt = WebsiteBO.getDataSetWebsite().Tables[0];
                grvListSetting.DataSource = dt;
                grvListSetting.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListSetting_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int Website_ID = (int)grvListSetting.DataKeys[e.Row.RowIndex].Values["Website_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                //URL1.NavigateUrl = "~/Topic.aspx?Website_ID=" + Website_ID;
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpEdit");
                URL2.NavigateUrl = "~/Admin/Edit/EditSetting.aspx?Website_ID=" + Website_ID;
                try
                {
                    DataTable dt = WebsiteBO.getDataSetWebsitebyWebsite_ID(Website_ID).Tables[0];
                    URL1.NavigateUrl = "~/Topic/" + Website_ID + "/" + RewriteUrl.ConvertToUnSign(Convert.ToString(dt.Rows[0]["Website_Title"])) + ".html";
                    URL1.Target = "_blank";
                }
                catch{}
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListSetting.SelectedRows)
                {
                    strID += "," + grvListSetting.DataKeys[row.RowIndex].Values["Accounts_Username"];

                }
                AccountsBO.setdeleteAccountsbyUsername(strID.Substring(1));
                loadSetting();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListSetting_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSetting.PageIndex = e.NewPageIndex;
            loadSetting();
        }

        protected void btnShowSearchAdvanced_Click(object sender, EventArgs e)
        {
            if (PanelSearchAdvanced.Visible == true)
            {
                PanelSearchAdvanced.Visible = false;
            }
            else
            {
                PanelSearchAdvanced.Visible = true;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = AccountsBO.getDataSetSearchAccountsbyFullname(txtAccounts_FullName.Text, txtAccounts_Username.Text, txtAccounts_Email.Text, "0", txtAccounts_Address.Text).Tables[0];
                grvListSetting.DataSource = dt;
                grvListSetting.DataBind();
            }
            catch (Exception)
            {
            }
        }
    }
}