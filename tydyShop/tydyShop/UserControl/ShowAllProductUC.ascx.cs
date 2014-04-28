using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;

namespace tydyShop.UserControl
{
    public partial class ShowAllProductUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ProductsDAO.getDataSetProducts(0);
            rptLoadAllProduct.DataSource = ds;
            rptLoadAllProduct.DataBind();
        }
    }
}