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
    public partial class Support : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSupports_Type.Attributes.Add("placeholder", "Tìm kiếm theo tiêu đề hỗ trợ");
                loadSupport();
            }
        }

        private void loadSupport()
        {
            try
            {
                DataTable dt = AnswersBO.getDataSetNewSupports(true).Tables[0];
                grvListSupport.DataSource = dt;
                grvListSupport.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListSupport_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Supports_ID = (Int64)grvListSupport.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/ReplyNewSupport.aspx?Supports_ID=" + Supports_ID + "&ViewMode=true";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListSupport.SelectedRows)
                {
                    strID += "," + (Int64)grvListSupport.DataKeys[row.RowIndex].Values["Supports_ID"];

                }
                AnswersBO.setdeleteAnswersbyAnswers_ID(strID.Substring(1));
                loadSupport();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListSupport_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSupport.PageIndex = e.NewPageIndex;
            loadSupport();
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
                if (txtAnswers_DateTimeA1.Text == "")
                {
                    txtAnswers_DateTimeA1.Text = "09/09/1990";
                }
                if (txtAnswers_DateTimeA2.Text == "")
                {
                    txtAnswers_DateTimeA2.Text = "09/09/2050";
                }
                DataTable dt = AnswersBO.getDataSetSearchAccountsbySupports_Type(true, txtSupports_Type.Text, txtAccounts_FullName.Text, txtProducts_Name.Text, Convert.ToDateTime(txtAnswers_DateTimeA1.Text).Date, Convert.ToDateTime(txtAnswers_DateTimeA2.Text).Date.AddDays(1)).Tables[0];
                grvListSupport.DataSource = dt;
                grvListSupport.DataBind();
                txtAnswers_DateTimeA1.Text = "";
                txtAnswers_DateTimeA2.Text = "";
            }
            catch (Exception)
            {
            }
        }
    }
}