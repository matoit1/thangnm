using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;
namespace ThangNMjsc.Admin
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtAccounts_FullName.Attributes.Add("placeholder", "Tìm kiếm theo tên Khách hàng");
                loadCustomers();
            }
            
        }

        private void loadCustomers()
        {
            try
            {
                DataTable dt = AccountsBO.getDataSetAccounts(0).Tables[0];
                grvListCustomer.DataSource = dt;
                grvListCustomer.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListCustomer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string Accounts_Username = (string)grvListCustomer.DataKeys[e.Row.RowIndex].Values["Accounts_Username"];
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
                foreach (GridViewRow row in grvListCustomer.SelectedRows)
                {
                    strID += "," + grvListCustomer.DataKeys[row.RowIndex].Values["Accounts_Username"];

                }
                AccountsBO.setdeleteAccountsbyUsername(strID.Substring(1));
                loadCustomers();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListCustomer.PageIndex = e.NewPageIndex;
            loadCustomers();
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
                DataTable dt = AccountsBO.getDataSetSearchAccountsbyFullname(txtAccounts_FullName.Text, txtAccounts_Username.Text, txtAccounts_Email.Text, "0",txtAccounts_Address.Text).Tables[0];
                grvListCustomer.DataSource = dt;
                grvListCustomer.DataBind();
            }
            catch (Exception)
            {
            }
        }

        public static String GetTmpDate(){
            string strTmpDate = System.DateTime.Now.ToShortDateString();
            strTmpDate = strTmpDate.Replace(":", "-").Trim();
            strTmpDate = strTmpDate.Replace("/", "-").Trim();
            return strTmpDate;
        }

        protected void btnExportExcel_Click(object sender, EventArgs e)
        {
            try{
                Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=Report_" + GetTmpDate() + ".xls");
            Response.ContentType = "application/excel";
            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            grvListCustomer.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();



            //    Response.ClearContent();
            //string attachment = ("attachment; filename=Report_" + GetTmpDate() + ".xls");
            //Response.ClearContent();
            //Response.AddHeader("content-disposition", attachment);
            //Response.ContentType = "application/ms-excel";
            //StringWriter strWrite = New StringWriter();
            //HtmlTextWriter htmWrite = new HtmlTextWriter(strWrite);
            //Form 
            //Dim htmfrm As New HtmlForm();
            //grEmp.Parent.Controls.Add(htmfrm);
            //htmfrm.Attributes("runat") = "server";
            //htmfrm.Controls.Add(grEmp);
            //htmfrm.RenderControl(htmWrite);
            //Response.Write(strWrite.ToString());
            //Response.Flush();
            //Response.[End]();
            }
            catch (Exception)
            {
            }
        }
    }
}