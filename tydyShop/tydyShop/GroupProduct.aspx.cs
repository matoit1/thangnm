using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;

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
                        ProductEO _ProductEO = new ProductEO();
                        _ProductEO.lGroup = Convert.ToInt64(Request.QueryString["Products_Group"]);
                        _ProductEO.bStatus = true;
                        Gallery3DUC1.BindData(ProductDAO.Product_SelectList_All_Product_In_Group(_ProductEO));
                    }
                }
            }
            catch { }
        }
    }
}