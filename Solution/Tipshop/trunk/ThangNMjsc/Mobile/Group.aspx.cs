using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;

namespace ThangNMjsc.Mobile
{
    public partial class Group : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Products_ID"] != null)
                {
                    Int64 Products_ID = Convert.ToInt64(Request.QueryString["Products_ID"]);
                    datalistProduct.DataSource = ProductsBO.getDataSetGroupProductsShow(Products_ID);
                    if (Request.QueryString["Products_Parent"] != null)
                    {
                        Int64 Products_Parent = Convert.ToInt32(Request.QueryString["Products_Parent"]);
                        datalistProduct.DataSource = ProductsBO.getDataSetGroupProductsShow(Products_Parent);
                    }
                    datalistProduct.DataBind();
                }
            }
        }
    }
}