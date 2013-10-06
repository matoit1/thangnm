using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ThangNMjsc.UserControls
{
    public partial class OrdersDetail : System.Web.UI.UserControl
    {
        private DataTable _dtOrdersDetail;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadOrder();
        }

        public DataTable dtOrdersDetail
        {
            get { return this._dtOrdersDetail; }
            set { _dtOrdersDetail = value; }
        }

        private void loadOrder()
        {
            try
            {
                lblOrders_ID.Text = "[ Mã Hóa đơn: #" + dtOrdersDetail.Rows[0]["Orders_ID"] + " ]";
                lblCustomer.Text = dtOrdersDetail.Rows[0]["Accounts_FullName"].ToString();
                lblPay_Name.Text = dtOrdersDetail.Rows[0]["Pay_Name"].ToString();
                lblPay_FullName.Text = dtOrdersDetail.Rows[0]["Pay_FullName"].ToString();
                lblPay_DateOfStart.Text = dtOrdersDetail.Rows[0]["Pay_DateOfStart"].ToString();
                lblPay_Address.Text = dtOrdersDetail.Rows[0]["Pay_Address"].ToString();
                lblPay_DateOfFinish.Text = dtOrdersDetail.Rows[0]["Pay_DateOfFinish"].ToString();
                lblPay_PhoneNumber.Text = dtOrdersDetail.Rows[0]["Pay_PhoneNumber"].ToString();
                lblPay_Status.Text = dtOrdersDetail.Rows[0]["Pay_Status"].ToString();
                lblPay_Email.Text = dtOrdersDetail.Rows[0]["Pay_Email"].ToString();
                grvListOrder.DataSource = dtOrdersDetail;
                grvListOrder.DataBind();
                Int64 TotalMoney = 0;
                for (int i = 0; i < dtOrdersDetail.Rows.Count; i++)
                {
                    int sl = Convert.ToInt32(dtOrdersDetail.Rows[i]["OrdersDetails_Quantity"]);
                    Int64 Price = Convert.ToInt64(dtOrdersDetail.Rows[i]["OrdersDetails_UnitPrice"]);
                    TotalMoney = TotalMoney + (sl * Price);
                }
                lblTotal.Text = "Tổng tiền: " + Convert.ToUInt64(TotalMoney) + " VNĐ";
            }
            catch (Exception)
            {
            }
        }

        protected void grvListOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListOrder.PageIndex = e.NewPageIndex;
            loadOrder();
        }
    }
}