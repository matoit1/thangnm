using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;
using System.Collections;

namespace ThangNMjsc.Admin.Edit
{
    public partial class EditGroupProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtProducts_Name.Attributes.Add("placeholder", "VD: Máy tính");
            txtProducts_Description.Attributes.Add("placeholder", "VD: Máy tính xách tay chính hãng ASUS");
            txtProducts_Description.EnterMode = CKEditor.NET.EnterMode.BR;
            LoadCKEditor();
            if (!IsPostBack)
            {
                loadGroupProducts();
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                dropProducts_Parent.Visible = false;
                radiobtnParent.Checked = true;
                Int64 Products_ID;
                if (Request.QueryString["Products_ID"] != null) //Neu la dang Sua 1 Nhom SP
                {
                    Products_ID = Convert.ToInt64(Request.QueryString["Products_ID"]);
                    try
                    {
                        DataSet ds = ProductsBO.getDataSetProductsbyProducts_ID(Products_ID);
                        txtProducts_ID.Text = Convert.ToString(Products_ID);
                        txtProducts_Name.Text = ds.Tables[0].Rows[0]["Products_Name"].ToString();
                        txtProducts_Description.Text = ds.Tables[0].Rows[0]["Products_Description"].ToString();
                        chkProducts_Visible.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Products_Visible"]);
                        if (Convert.ToInt64(ds.Tables[0].Rows[0]["Products_Parent"]) != 0)
                        {
                            radiobtnChildrent.Checked = true;
                            dropProducts_Parent.Visible = true;
                            dropProducts_Parent.Text = ds.Tables[0].Rows[0]["Products_Parent"].ToString();
                        }
                        if (Request.QueryString["ViewMode"] == "true")
                        {
                            Panel1.Enabled = false;
                        }
                    }
                    catch (Exception) { }
                }
                else     //Neu la dang Them 1 Nhom SP
                {
                    btnAdd.Visible = true;
                    btnUpdate.Visible = false;
                    lblProducts_ID.Visible = false;
                    txtProducts_ID.Visible=false;
                    Products_ID = Convert.ToInt64(null);
                }
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 Products_Parent;
            if (radiobtnParent.Checked == true) // Kiem tra xem co phai la nhom con ko?
            {
                Products_Parent = 0;
            }
            else
            {
                Products_Parent = Convert.ToInt64(dropProducts_Parent.SelectedValue);
            }
            try
            {
                ProductsBO.setUpdateGroupProducts(Convert.ToInt64(txtProducts_ID.Text), Products_Parent, txtProducts_Name.Text, txtProducts_Description.Text, chkProducts_Visible.Checked);
                lblMsg.Text = "Cập nhật nhóm Sản phẩm thành công";
                lblMsg.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                lblMsg.Text = "Cập nhật nhóm Sản phẩm bị lỗi, Vui lòng kiểm tra lại.";
                lblMsg.CssClass = "notificationError";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Int64 Products_Parent;
            if (radiobtnParent.Checked == true) // Kiem tra xem co phai la nhom con ko?
            {
                Products_Parent = 0;
            }
            else
            {
                Products_Parent=Convert.ToInt64(dropProducts_Parent.SelectedValue);
            }
            try
            {
                ProductsBO.setInsertGroupProducts(Products_Parent, txtProducts_Name.Text, txtProducts_Description.Text);
                lblMsg.Text = "Thêm nhóm Sản phẩm mới thành công";
                lblMsg.CssClass = "notificationSuccessful";
                txtProducts_Description.Text = "";
                txtProducts_Name.Text = "";
            }
            catch (Exception)
            {
                lblMsg.Text = "Thêm nhóm Sản phẩm mới bị lỗi, Vui lòng kiểm tra lại.";
                lblMsg.CssClass = "notificationError";
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
            dropProducts_Parent.DataSource = slCountry;
            dropProducts_Parent.DataTextField = "Value";
            dropProducts_Parent.DataValueField = "Key";
            dropProducts_Parent.DataBind();
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
        }

        protected void radiobtnParent_CheckedChanged(object sender, EventArgs e)
        {
            dropProducts_Parent.Visible = false;
        }

        protected void radiobtnChildrent_CheckedChanged(object sender, EventArgs e)
        {
            dropProducts_Parent.Visible = true;
        }
    }
}