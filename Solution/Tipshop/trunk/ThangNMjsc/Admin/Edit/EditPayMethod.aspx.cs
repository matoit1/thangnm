using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using BusinessObject;
using System.Collections;
using System.Text.RegularExpressions;

namespace ThangNMjsc.Admin.Edit
{
    public partial class EditPayMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label14.Text = "";
            if (!IsPostBack)
            {
                txtPay_Name.Attributes.Add("placeholder", "VD: Ngân lượng");
                if (Request.QueryString["Pay_ID"] != null)
                {
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                    lblTitle.Text = "Sửa phương thức thanh toán";
                    int Pay_ID = Convert.ToInt32(Request.QueryString["Pay_ID"]);
                    try
                    {
                        DataSet ds = PayBO.getDataSetPaybyPay_ID(Pay_ID);
                        txtPay_ID.Text =Convert.ToString(Pay_ID);
                        txtPay_Name.Text = Convert.ToString(ds.Tables[0].Rows[0]["Pay_Name"]);
                        ChkPay_Visible.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Pay_Visible"]);
                        if (Request.QueryString["ViewMode"] == "true")
                        {
                            panelEdit.Enabled = false;
                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    lblPay_ID.Visible = false;
                    txtPay_ID.Visible = false;
                    txtPay_Name.Enabled = true;
                    btnAdd.Visible = true;
                    btnUpdate.Visible = false;
                    lblTitle.Text = "Thêm phương thức thanh toán mới";
                }

            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PayBO.setUpdatePay(Convert.ToInt32(txtPay_ID.Text), txtPay_Name.Text, ChkPay_Visible.Checked);
                Label14.Text = "Cập nhật Phương thức thanh toán thành công";
                Label14.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label14.Text = "Cập nhật Phương thức thanh toán bị lỗi, Vui lòng kiểm tra lại";
                Label14.CssClass = "notificationError";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PayBO.setInsertPay(txtPay_Name.Text, ChkPay_Visible.Checked);
                Label14.Text = "Thêm Phương thức thanh toán thành công";
                Label14.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label14.Text = "Thêm Phương thức thanh toán mới bị lỗi, Vui lòng kiểm tra lại";
                Label14.CssClass = "notificationError";
                return;
            }
        }
    }
}