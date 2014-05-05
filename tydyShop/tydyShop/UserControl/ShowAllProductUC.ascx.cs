using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;
using EntityObject;

namespace tydyShop.UserControl
{
    public partial class ShowAllProductUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    DataSet ds = new DataSet();
                    ProductEO _ProductEO = new ProductEO();
                    _ProductEO.bStatus = true;
                    ds = ProductDAO.Product_SelectList_All_Product(_ProductEO);
                    rptLoadAllProduct.DataSource = ds;
                    rptLoadAllProduct.DataBind();
                }
            }
            catch
            {
            }
        }
    }
}