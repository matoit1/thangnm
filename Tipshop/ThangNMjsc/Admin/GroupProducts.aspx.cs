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
    public partial class GroupProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGroupProducts();
            }
        }

        private void loadGroupProducts()
        {
            try
            {
                DataTable dt = ProductsBO.getDataSetGroupProducts(0).Tables[0];
                grvListGroupProducts.DataSource = dt;
                grvListGroupProducts.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListGroupProducts_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Products_ID = (Int64)grvListGroupProducts.DataKeys[e.Row.RowIndex].Values["Products_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/EditGroupProducts.aspx?Products_ID=" + Products_ID + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpEdit");
                URL2.NavigateUrl = "~/Admin/Edit/EditGroupProducts.aspx?Products_ID=" + Products_ID;
            }
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListGroupProducts.SelectedRows)
                {
                    strID += "," + (Int64)grvListGroupProducts.DataKeys[row.RowIndex].Values["Products_ID"];

                }
                ProductsBO.setdeleteProductsbyProducts_ID(strID.Substring(1));
                loadGroupProducts();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListGroupProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListGroupProducts.PageIndex = e.NewPageIndex;
            loadGroupProducts();
        }
    }
}