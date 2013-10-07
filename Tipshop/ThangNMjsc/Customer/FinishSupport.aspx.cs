using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Customer
{
    public partial class FinishSupport : System.Web.UI.Page
    {
        int idcurrent;
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
                string Accounts_Username = Request.Cookies["client"].Value;
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Accounts_Username);
                idcurrent = Convert.ToInt32(ds.Tables[0].Rows[0]["Accounts_ID"]);
                DataTable dt = AnswersBO.getDataSetSupportsbyCustomer_IDandSupports_Status(idcurrent, true).Tables[0];
                grvListSupport.DataSource = dt;
                grvListSupport.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListSupport_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSupport.PageIndex = e.NewPageIndex;
            loadSupport();
        }

        protected void grvListSupport_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Supports_ID = (Int64)grvListSupport.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Customer/ForwardSupport.aspx?Supports_ID=" + Supports_ID + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpForward");
                URL2.NavigateUrl = "~/Customer/ForwardSupport.aspx?Supports_ID=" + Supports_ID;
            }
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
                DataTable dt = AnswersBO.getDataSetSearchAccountsbySupports_Type(true, txtSupports_Type.Text, Request.Cookies["client"].Value, txtProducts_Name.Text, Convert.ToDateTime(txtAnswers_DateTimeA1.Text).Date, Convert.ToDateTime(txtAnswers_DateTimeA2.Text).Date.AddDays(1)).Tables[0];
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