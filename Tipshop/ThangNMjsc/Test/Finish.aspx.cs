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
    public partial class Finish : System.Web.UI.Page
    {
        int idcurrent;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
                grvListSupportFinish.DataSource = dt;
                grvListSupportFinish.DataBind();
            }
            catch (Exception)
            {
            }
        }
        
        protected void grvListSupportFinish_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Products_ID = (Int64)grvListSupportFinish.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Customer/ForwardSupport.aspx?Supports_ID=" + Products_ID + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpForward");
                URL2.NavigateUrl = "~/Customer/ForwardSupport.aspx?Supports_ID=" + Products_ID;
            }
        }

        protected void grvListSupportFinish_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSupportFinish.PageIndex = e.NewPageIndex;
            loadSupport();
        }
    }
}