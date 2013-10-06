using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace ThangNMjsc.UserControls
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadProducts();
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            loadProducts(); 
        }
        private void loadProducts()
        {
            try
            {
            //    DataTable dt = ProductsBO.getDataSetProducts(0).Tables[0];
                grvListProducts.DataSource = SearchProductUC1.dtSearchProduct;
                grvListProducts.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListProducts_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Products_ID = (Int64)grvListProducts.DataKeys[e.Row.RowIndex].Values["Products_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/EditProducts.aspx?Products_ID=" + Products_ID + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpEdit");
                URL2.NavigateUrl = "~/Admin/Edit/EditProducts.aspx?Products_ID=" + Products_ID;
            }
        }

        protected void grvListProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListProducts.PageIndex = e.NewPageIndex;
            loadProducts();
        }

    }
}