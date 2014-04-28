using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tydyShop
{
    public partial class GroupProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["Products_Group"] != null)
                    {
                        Gallery3DUC1.BindData(ProductsDAO.getDataSetGroupProductsShow(Convert.ToInt64(Request.QueryString["Products_Group"])));
                    }
                }
            }
            catch { }
        }
    }
}