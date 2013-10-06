using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BusinessObject;
using EntityObject;
using Common;

namespace ThangNMjsc.Product
{
    public partial class Cart : System.Web.UI.Page
    {
        private string merchant_site_code = "30713";
        private string merchant_pass = "tipshop303909";
        private string receiver = "thang.991992@gmail.com";

        public DataTable tb = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadPayMethod();
                if (Request.Cookies["client"] != null)
                {
                    DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["client"].Value);
                    txtPay_FullName.Text = ds.Tables[0].Rows[0]["Accounts_Fullname"].ToString();
                    txtPay_Email.Text = ds.Tables[0].Rows[0]["Accounts_Email"].ToString();
                    txtPay_PhoneNumber.Text = ds.Tables[0].Rows[0]["Accounts_PhoneNumber"].ToString();
                    txtPay_Address.Text = ds.Tables[0].Rows[0]["Accounts_Address"].ToString();
                }
                tb = (DataTable)Session["Cart"];
                if (tb != null)
                {
                    if (tb.Rows.Count > 0)
                    {
                        grvListMyCart.DataSource = tb;
                        grvListMyCart.DataBind();
                    }
                    lblTongtien.Text = tongtien(tb).ToString();
                }
            }
        }

        public void loadPayMethod()
        {
            DataTable dt = PayBO.getDataSetPaybyPay_Visible(true).Tables[0];
            string Key = "";
            string Value = "";
            SortedList slPayMethod = new SortedList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Value = dt.Rows[i]["Pay_Name"].ToString();
                Key = dt.Rows[i]["Pay_ID"].ToString();
                slPayMethod.Add(Key, Value);
            }
            dropPayMethod.DataSource = slPayMethod;
            dropPayMethod.DataTextField = "Value";
            dropPayMethod.DataValueField = "Key";
            dropPayMethod.DataBind();
        }

        // Tính tổng số tiền
        public float tongtien(DataTable tb)
        {
            Int64 invoice_Total = 0;
            try
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    invoice_Total = invoice_Total + Int64.Parse(tb.Rows[i]["Products_Total"].ToString());
                }
            }
            catch { }
            return invoice_Total;
        }

        protected void imgbtnUpdate_Click(object sender, ImageClickEventArgs e)
        {
            tb = (DataTable)Session["Cart"];
            for (int i = 0; i < grvListMyCart.Rows.Count; i++)
            {
                TextBox sl = (TextBox)grvListMyCart.Rows[i].FindControl("txtsl");
                int soluong = int.Parse(sl.Text);
                //cập nhật số lượng cho giỏ hàng
                tb.Rows[i]["Products_Numbers"] = soluong;
                //lấy đơn giá của hàng từ giỏ hàng về. 
                Int64 g = Int64.Parse(tb.Rows[i]["Products_Price"].ToString());
                //cập nhật tổng giá cho giỏ hàng.
                tb.Rows[i]["Products_Total"] = g * soluong;
            }
            //load dữ liệu lại cho Gridview
            grvListMyCart.DataSource = tb;
            grvListMyCart.DataBind();
            //hiển thị tổng tiền.
            lblTongtien.Text = Convert.ToUInt64(tongtien(tb)).ToString();
        }
        public void updateThanhTien_GioHang(DataTable tb, int row, int sl, Int64 gia)
        {
            //double tt = sl * gia;
            DataRow r = tb.Rows[row];
            r["Products_Total"] = Int64.Parse(r["Products_Price"].ToString()) * sl;
        }

        // Thanh toán qua Ngân Lượng
        protected void imgbtnPay_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["client"].Value);
                int CategoryID = Convert.ToInt32(Request.QueryString["CategoryID"]);
                OrdersBO _OrdersBO = new OrdersBO();
                OrdersEO _OrdersEO = _OrdersBO.getNewIDbyInsertOrders(Convert.ToInt32(ds.Tables[0].Rows[0]["Accounts_ID"]), Convert.ToInt32(dropPayMethod.SelectedValue), txtPay_Email.Text, txtPay_FullName.Text, txtPay_Address.Text, txtPay_PhoneNumber.Text, txtPay_Note.Text, Convert.ToDateTime(txtPay_DateOfStart.Text).Date, Convert.ToDateTime(txtPay_DateOfFinish.Text).Date);
                tb = (DataTable)Session["Cart"];
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    OrdersDetailsBO.setInsertOrdersDetails(_OrdersEO.Orders_ID, Convert.ToInt64(tb.Rows[i]["Products_ID"]), Convert.ToInt64(tb.Rows[i]["Products_Price"]), Convert.ToInt32(tb.Rows[i]["Products_Numbers"]));
                }
                OrdersEO _OrdersEO1 = _OrdersBO.getSumQuantitybyOrders_ID(_OrdersEO.Orders_ID);
                switch (Convert.ToInt32(dropPayMethod.SelectedValue))
                {
                    case 1: Nganluong(_OrdersEO.Orders_ID.ToString(), _OrdersEO1.Pay_ID);
                        break;
                    case 2: Paygate(_OrdersEO.Orders_ID.ToString());
                        break;
                    case 3: Baokim(_OrdersEO.Orders_ID.ToString(), _OrdersEO1.Pay_ID);
                        break;
                }
            }
            catch {}
        }

        public void Nganluong(String Orders_ID, Int32 SumQuantity){
            NL_Checkout nlcheckout = new NL_Checkout();
            nlcheckout.merchant_site_code = this.merchant_site_code;
            nlcheckout.secure_pass = this.merchant_pass;
            string rs = nlcheckout.buildCheckoutUrlNew("http://tipshop.tk/success.aspx", "thang.991992@gmail.com", txtPay_Note.Text, Orders_ID, lblTongtien.Text, "vnd", SumQuantity, 0, 0, 0, 0, "", "Nguyễn Mạnh Thắng*|*thang.991992@gmail.com*|*01675279562*|*", "");
            Response.Write(rs);
            Response.Redirect(rs);
        }

        public void Paygate(String Orders_ID)
        {
            try
            {
                var Security_Key = ConfigurationManager.AppSettings["SecretKey"];
                string dataSign = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}", 505, 1, Orders_ID, Convert.ToInt32(lblTongtien.Text), "01675279562", "", Security_Key);
                string signRSA = Security.SHA256encrypt(dataSign);
                string listparam = string.Format("?website_id={0}&payment_method={1}&order_code={2}&amount={3}&receiver_acc={4}&customer_name={5}&customer_mobile={6}&order_des={7}&param_extend={8}&sign={9}",
                    505, 1, Orders_ID, Convert.ToInt32(lblTongtien.Text), "01675279562",
                    txtPay_FullName.Text, txtPay_PhoneNumber.Text, txtPay_Note.Text, "", signRSA);


                string urlRedirect = ConfigurationManager.AppSettings["VTCPay_Url"] + listparam;
                Response.Redirect(urlRedirect, false);

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
                NLogLogger.Info(ex.ToString());
            }
        }

        public void Baokim(String Orders_ID, Int32 SumQuantity)
        {
            BaoKimPayment BaoKimPayment = new BaoKimPayment();
            string rs1 = BaoKimPayment.createRequestUrl(Orders_ID, "thang.991992@gmail.com", lblTongtien.Text, "", "", txtPay_Note.Text, "http://tipshop.tk/success.aspx", "http://tipshop.tk/error.aspx", "http://tipshop.tk/Customer/OrdersDetails.aspx?Orders_ID=" + Orders_ID);
            Response.Write(rs1);
            Response.Redirect(rs1);
        }

        protected void imgbtnDeleteCart_Click(object sender, ImageClickEventArgs e)
        {
            Session["Cart"] = null;
            Response.Redirect("~/Default.aspx");
        }

        protected void grvListMyCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int chiso = int.Parse(e.CommandArgument.ToString());
                try
                {
                    DataTable dt = (DataTable)Session["Cart"];
                    dt.Rows.RemoveAt(chiso);
                    Session["Cart"] = dt;
                    Response.Redirect("~/Cart.aspx");
                }
                catch
                {
                    Response.Redirect("~/Cart.aspx");
                }
            }
        }

        protected void grvListMyCart_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    string Products_ID = (string)grvListMyCart.DataKeys[e.Row.RowIndex].Values["Products_ID"];
                    DataSet ds = ProductsBO.getDataSetProductsbyProducts_ID(Convert.ToInt64(Products_ID));
                    HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                    URL1.NavigateUrl = "~/Product/" + Products_ID + "/" + RewriteUrl.ConvertToUnSign(ds.Tables[0].Rows[0]["Products_Name"].ToString()) + ".html";
                }
            }
            catch { }
        }

        protected void grvListMyCart_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListMyCart.PageIndex = e.NewPageIndex;
            //loadCustomers();
        }

    }
}