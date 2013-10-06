using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Product
{
    public partial class Search : System.Web.UI.Page
    {
        string contentsearch;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Products_Name"] != null)
                {
                    contentsearch =Request.QueryString["Products_Name"];
                    loadRequestProducts();
                }
            }
        }

        private void loadRequestProducts()
        {
            try
            {
                DataTable dt = ProductsBO.getDataSetProducts(0).Tables[0];
                grvListProducts.DataSource = dt;
                grvListProducts.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ProductsBO.getDataSetSearchProductsbyName(txtProducts_Name.Text, txtProducts_Description.Text, txtProducts_Info.Text, txtProducts_Origin.Text).Tables[0];
                grvListProducts.DataSource = dt;
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
                URL1.NavigateUrl = "~/Product/Product.aspx?Products_ID=" + Products_ID;
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpPaid");
                URL2.NavigateUrl = "~/Product/Product.aspx?Products_ID=" + Products_ID + "&Paid=true";
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

        protected void grvListProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListProducts.PageIndex = e.NewPageIndex;
            loadRequestProducts();
        }
    }
}