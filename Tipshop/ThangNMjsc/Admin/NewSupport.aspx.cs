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
    public partial class NewSupport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSupports_Type.Attributes.Add("placeholder", "Tìm kiếm theo tiêu đề hỗ trợ");
                loadNewSupport();
            }
            
        }

        private void loadNewSupport()
        {
            try
            {
                DataTable dt = AnswersBO.getDataSetNewSupports(false).Tables[0];
                grvListNewSupport.DataSource = dt;
                grvListNewSupport.DataBind();
            }
            catch (Exception)
            {
            }
        }


        protected void grvListNewSupport_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HyperLink URL = (HyperLink)e.Row.FindControl("hpReply");
                Int64 Supports_ID = (Int64)grvListNewSupport.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
                URL.NavigateUrl = "~/Admin/Edit/ReplyNewSupport.aspx?Supports_ID=" + Supports_ID;
            }
        }



        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListNewSupport.SelectedRows)
                {
                    strID += "," + (Int64)grvListNewSupport.DataKeys[row.RowIndex].Values["Supports_ID"];

                }
                AnswersBO.setdeleteAnswersbyAnswers_ID(strID.Substring(1));
                loadNewSupport();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListNewSupport_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListNewSupport.PageIndex = e.NewPageIndex;
            loadNewSupport();
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
                DataTable dt = AnswersBO.getDataSetSearchAccountsbySupports_Type(false, txtSupports_Type.Text, txtAccounts_FullName.Text, txtProducts_Name.Text, Convert.ToDateTime(txtAnswers_DateTimeA1.Text).Date, Convert.ToDateTime(txtAnswers_DateTimeA2.Text).Date.AddDays(1)).Tables[0];
                grvListNewSupport.DataSource = dt;
                grvListNewSupport.DataBind();
                txtAnswers_DateTimeA1.Text = "";
                txtAnswers_DateTimeA2.Text = "";
            }
            catch (Exception)
            {
            }
        }
    }
}