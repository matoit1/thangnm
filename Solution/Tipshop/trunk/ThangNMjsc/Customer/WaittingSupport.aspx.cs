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
    public partial class Waitting : System.Web.UI.Page
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
                DataTable dt = AnswersBO.getDataSetSupportsbyCustomer_IDandSupports_Status(idcurrent, false).Tables[0];
                grvListSupportWaitting.DataSource = dt;
                grvListSupportWaitting.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListSupportWaitting_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Products_ID = (Int64)grvListSupportWaitting.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Customer/ForwardSupport.aspx?Supports_ID=" + Products_ID + "&ViewMode=true";
            }
        }

        protected void grvListSupportWaitting_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSupportWaitting.PageIndex = e.NewPageIndex;
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
                DataTable dt = AnswersBO.getDataSetSearchAccountsbySupports_Type(false, txtSupports_Type.Text, Request.Cookies["client"].Value, txtProducts_Name.Text, Convert.ToDateTime(txtAnswers_DateTimeA1.Text).Date, Convert.ToDateTime(txtAnswers_DateTimeA2.Text).Date.AddDays(1)).Tables[0];
                grvListSupportWaitting.DataSource = dt;
                grvListSupportWaitting.DataBind();
                txtAnswers_DateTimeA1.Text = "";
                txtAnswers_DateTimeA2.Text = "";
            }
            catch (Exception)
            {
            }
        }
    }
}