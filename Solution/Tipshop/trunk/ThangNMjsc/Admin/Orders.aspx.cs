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
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSupports_Type.Attributes.Add("placeholder", "Tìm kiếm theo tiêu đề hỗ trợ");
                loadOrder();
            }
        }

        private void loadOrder()
        {
            try
            {
                DataTable dt = OrdersBO.getDataSetOrders(true).Tables[0];
                grvListOrder.DataSource = dt;
                grvListOrder.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void grvListOrder_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Orders_ID = (Int64)grvListOrder.DataKeys[e.Row.RowIndex].Values["Orders_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/OrdersDetails.aspx?Orders_ID=" + Orders_ID + "&ViewMode=true";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListOrder.SelectedRows)
                {
                    strID += "," + (Int64)grvListOrder.DataKeys[row.RowIndex].Values["Orders_ID"];

                }
                OrdersBO.setDeleteOrders(strID.Substring(1));
                loadOrder();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListOrder.PageIndex = e.NewPageIndex;
            loadOrder();
        }

        protected void btnShowSearchAdvanced_Click(object sender, EventArgs e)
        {
            if (PanelSearchAdvanced.Visible == true)
            {
                PanelSearchAdvanced.Visible = false;
            }
            else
            {
                PanelSearchAdvanced.Visible = true;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtAnswers_DateTimeA1.Text == "")
            //    {
            //        txtAnswers_DateTimeA1.Text = "09/09/1990";
            //    }
            //    if (txtAnswers_DateTimeA2.Text == "")
            //    {
            //        txtAnswers_DateTimeA2.Text = "09/09/2050";
            //    }
            //    DataTable dt = AnswersBO.getDataSetSearchAccountsbySupports_Type(true, txtSupports_Type.Text, txtAccounts_FullName.Text, txtProducts_Name.Text, Convert.ToDateTime(txtAnswers_DateTimeA1.Text).Date, Convert.ToDateTime(txtAnswers_DateTimeA2.Text).Date.AddDays(1)).Tables[0];
            //    grvListOrder.DataSource = dt;
            //    grvListOrder.DataBind();
            //    txtAnswers_DateTimeA1.Text = "";
            //    txtAnswers_DateTimeA2.Text = "";
            //}
            //catch (Exception)
            //{
            //}
        }
    }
}