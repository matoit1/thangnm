using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Customer
{
    public partial class OrdersDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OrdersDetailUC1.dtOrdersDetail = OrdersBO.getDataSetOrdersbyOrders_ID(Convert.ToInt64(Request.QueryString["Orders_ID"])).Tables[0];
            }
        }
    }
}