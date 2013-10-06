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

namespace ThangNMjsc.Admin.Edit
{
    public partial class EditProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtProducts_Description.EnterMode = CKEditor.NET.EnterMode.BR;
            txtProducts_Info.EnterMode = CKEditor.NET.EnterMode.BR;
            LoadCKEditor();
            if (!IsPostBack)
            {
                txtProducts_Name.Attributes.Add("placeholder", "VD: Máy tính xách tay ASUS X42F");
                txtProducts_Price.Attributes.Add("placeholder", "VD: 100000000");
                txtProducts_Sale.Attributes.Add("placeholder", "VD: 100");
                txtProducts_Origin.Attributes.Add("placeholder", "VD: Đài Loan");
                txtProducts_Image1.Attributes.Add("placeholder", "VD: http://images.com/product1.jpg");
                txtProducts_Image2.Attributes.Add("placeholder", "VD: http://images.com/product2.jpg");
                txtProducts_Image3.Attributes.Add("placeholder", "VD: http://images.com/product3.jpg");
                txtProducts_Video.Attributes.Add("placeholder", "VD: http://videos.com/demo.mp4");
                loadGroupProducts();
                Int64 Products_ID;
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                if (Request.QueryString["Products_ID"] != null)
                {
                    Products_ID = Convert.ToInt64(Request.QueryString["Products_ID"]);
                    try
                    {
                        DataSet ds = ProductsBO.getDataSetProductsbyProducts_ID(Products_ID);
                        txtProducts_ID.Text = Convert.ToString(Products_ID);
                        dropProducts_Group.Text = ds.Tables[0].Rows[0]["Products_Group"].ToString();
                        txtProducts_Name.Text = ds.Tables[0].Rows[0]["Products_Name"].ToString();
                        txtProducts_Price.Text = ds.Tables[0].Rows[0]["Products_Price"].ToString();
                        txtProducts_Sale.Text = ds.Tables[0].Rows[0]["Products_Sale"].ToString();
                        chkProducts_VAT.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Products_VAT"]);
                        txtProducts_Description.Text = ds.Tables[0].Rows[0]["Products_Description"].ToString();
                        txtProducts_Info.Text = ds.Tables[0].Rows[0]["Products_Info"].ToString();
                        txtProducts_Origin.Text = ds.Tables[0].Rows[0]["Products_Origin"].ToString();
                        txtProducts_Image1.Text = ds.Tables[0].Rows[0]["Products_Image1"].ToString();
                        txtProducts_Image2.Text = ds.Tables[0].Rows[0]["Products_Image2"].ToString();
                        txtProducts_Image3.Text = ds.Tables[0].Rows[0]["Products_Image3"].ToString();
                        txtProducts_Video.Text = ds.Tables[0].Rows[0]["Products_Video"].ToString();
                        txtProducts_LastUpdate.Text = ds.Tables[0].Rows[0]["Products_LastUpdate"].ToString();
                        chkProducts_Visible.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Products_Visible"]);
                        if (Request.QueryString["ViewMode"] == "true")
                        {
                            Panel1.Enabled = false;
                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    btnAdd.Visible = true;
                    btnUpdate.Visible = false;
                    lblProducts_ID.Visible = false;
                    txtProducts_ID.Visible = false;
                    lblProducts_LastUpdate.Visible = false;
                    txtProducts_LastUpdate.Visible = false;
                    Products_ID = Convert.ToInt64(null);
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProducts_Sale.Text == "")
            {
                txtProducts_Sale.Text = "0";
            }
            try
            {
                ProductsBO.setInsertProducts(Convert.ToInt64(dropProducts_Group.SelectedValue), txtProducts_Name.Text, Convert.ToInt64(txtProducts_Price.Text), Convert.ToInt64(txtProducts_Sale.Text), chkProducts_VAT.Checked, txtProducts_Description.Text, txtProducts_Info.Text, txtProducts_Origin.Text, txtProducts_Image1.Text, txtProducts_Image2.Text, txtProducts_Image3.Text, txtProducts_Video.Text);
                Label10.Text = "Thêm Sản phẩm mới thành công";
                Label10.CssClass = "notificationSuccessful";
                txtProducts_Name.Text = "";
                txtProducts_Price.Text = "";
                txtProducts_Sale.Text = "";
                txtProducts_Origin.Text = "";
                txtProducts_Image1.Text = "";
                txtProducts_Image2.Text = "";
                txtProducts_Image3.Text = "";
                txtProducts_Video.Text = "";
                txtProducts_Description.Text = "";
                txtProducts_Info.Text = "";
            }
            catch (Exception)
            {
                Label10.Text = "Thêm Sản phẩm mới bị lỗi, Vui lòng kiểm tra lại.";
                Label10.CssClass = "notificationError";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProducts_Sale.Text == "")
            {
                txtProducts_Sale.Text = "0";
            }
            try
            {
                ProductsBO.setUpdateProducts(Convert.ToInt64(txtProducts_ID.Text), Convert.ToInt64(dropProducts_Group.SelectedValue), txtProducts_Name.Text, Convert.ToInt64(txtProducts_Price.Text), Convert.ToInt64(txtProducts_Sale.Text), chkProducts_VAT.Checked, txtProducts_Description.Text, txtProducts_Info.Text, txtProducts_Origin.Text, txtProducts_Image1.Text, txtProducts_Image2.Text, txtProducts_Image3.Text, txtProducts_Video.Text, chkProducts_Visible.Checked);
                Label10.Text = "Cập nhật thành công";
                Label10.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label10.Text = "Cập nhật bị lỗi, Vui lòng kiểm tra lại.";
                Label10.CssClass = "notificationError";
            }
        }

        public void loadGroupProducts()
        {

            DataTable dt = ProductsBO.getDataSetGroupProducts(0).Tables[0];
            string Key = "";
            string Value = "";
            SortedList slCountry = new SortedList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Value = dt.Rows[i]["Products_Name"].ToString();
                Key = dt.Rows[i]["Products_ID"].ToString();
                slCountry.Add(Key, Value);
            }
            dropProducts_Group.DataSource = slCountry;
            dropProducts_Group.DataTextField = "Value";
            dropProducts_Group.DataValueField = "Key";
            dropProducts_Group.DataBind();
        }

        protected void LoadCKEditor()
        {
            txtProducts_Description.config.toolbar = new object[] { 
              new object[] { "Save", "NewPage", "Preview", "-", "Templates" },
				new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt" },
				new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
			
				"/",
				new object[] { "Bold", "Italic", "Underline", "Strike" },
				new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv" },
				new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
				new object[] { "BidiLtr", "BidiRtl" },
				new object[] { "Link", "Unlink", "Anchor" },
				new object[] { "Image"},
				"/"
            };
            txtProducts_Info.config.toolbar = new object[] { 
              new object[] { "Save", "NewPage", "Preview", "-", "Templates" },
				new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt" },
				new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
			
				"/",
				new object[] { "Bold", "Italic", "Underline", "Strike" },
				new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv" },
				new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
				new object[] { "BidiLtr", "BidiRtl" },
				new object[] { "Link", "Unlink", "Anchor" },
				new object[] { "Image"},
				"/"
            };
        }
    }
}