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
    public partial class PayMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadPay();
            }
        }
        private void loadPay()
        {
            try
            {
                DataTable dt = PayBO.getDataSetPay().Tables[0];
                grvListPayMethod.DataSource = dt;
                grvListPayMethod.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListPayMethod_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string Pay_ID = Convert.ToString(grvListPayMethod.DataKeys[e.Row.RowIndex].Values["Pay_ID"]);
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/EditPayMethod.aspx?Pay_ID=" + Pay_ID + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpEdit");
                URL2.NavigateUrl = "~/Admin/Edit/EditPayMethod.aspx?Pay_ID=" + Pay_ID;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListPayMethod.SelectedRows)
                {
                    strID += "," + grvListPayMethod.DataKeys[row.RowIndex].Values["Pay_ID"];

                }
                PayBO.setDeletePay(strID.Substring(1));
                loadPay();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListPayMethod_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListPayMethod.PageIndex = e.NewPageIndex;
            loadPay();
        }
    }
}