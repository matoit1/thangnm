using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;
namespace ThangNMjsc.Admin.Edit
{
    public partial class OrdersDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    OrdersDetailUC1.dtOrdersDetail = OrdersBO.getDataSetOrdersbyOrders_ID(Convert.ToInt64(Request.QueryString["Orders_ID"])).Tables[0];
                    if (Convert.ToBoolean(OrdersDetailUC1.dtOrdersDetail.Rows[0]["Pay_Status"]) == true)
                    {
                        btnExcute.Visible = false;
                    }
                }
                catch (Exception) {}
            }
        }

        protected void btnExcute_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersBO.setUpdateOrders(Request.QueryString["Orders_ID"], true);
                lblMsg.Text = "Xử lý thành công";
                lblMsg.CssClass = "notificationSuccessful";
                btnExcute.Visible = false;
            }
            catch (Exception)
            {
                lblMsg.Text = "Xử lý Hóa đơn thất bại vui lòng kiểm tra lại";
                lblMsg.CssClass = "notificationError";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersBO.setDeleteOrders(Request.QueryString["Orders_ID"]);
                lblMsg.Text = "Xóa thành công";
                lblMsg.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                lblMsg.Text = "Xóa thất bại vui lòng kiểm tra lại";
                lblMsg.CssClass = "notificationError";
            }
        }
    }
}