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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int countNewSupport = AnswersBO.getDataSetNewSupports(false).Tables[0].Rows.Count;
                lblCountNewSupport.Text = "  " + Convert.ToString(countNewSupport) + "  ";
                int countNewOder = OrdersBO.getDataSetOrders(false).Tables[0].Rows.Count;
                lblCountNewOrder.Text = "  " + Convert.ToString(countNewOder) + "  ";
            }
        }
    }
}