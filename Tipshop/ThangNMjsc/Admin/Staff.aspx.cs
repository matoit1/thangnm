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
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtAccounts_FullName.Attributes.Add("placeholder", "Tìm kiếm theo tên Nhân viên");
                loadStaff();
            }
        }
        private void loadStaff()
        {
            try
            {
                DataTable dt = AccountsBO.getDataSetAccounts(100).Tables[0];
                grvListStaff.DataSource = dt;
                grvListStaff.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListStaff_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string Accounts_Username = (string)grvListStaff.DataKeys[e.Row.RowIndex].Values["Accounts_Username"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/EditAccounts.aspx?Accounts_Username=" + Accounts_Username + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpEdit");
                URL2.NavigateUrl = "~/Admin/Edit/EditAccounts.aspx?Accounts_Username=" + Accounts_Username;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListStaff.SelectedRows)
                {
                    strID += "," + grvListStaff.DataKeys[row.RowIndex].Values["Accounts_Username"];

                }
                AccountsBO.setdeleteAccountsbyUsername(strID.Substring(1));
                loadStaff();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListStaff_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListStaff.PageIndex = e.NewPageIndex;
            loadStaff();
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
                DataTable dt = AccountsBO.getDataSetSearchAccountsbyFullname(txtAccounts_FullName.Text, txtAccounts_Username.Text, txtAccounts_Email.Text, "1,2,3", txtAccounts_Address.Text).Tables[0];
                grvListStaff.DataSource = dt;
                grvListStaff.DataBind();
            }
            catch (Exception)
            {
            }
        }
    }
}