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
    public partial class AddGroupProducts : System.Web.UI.Page
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
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsBO.setInsertGroupProducts(Convert.ToInt64(dropProducts_Parent.SelectedValue), txtProducts_Name.Text, txtProducts_Description.Text);
                Label1.Text = "Thêm nhóm Sản phẩm mới thành công";
                Label1.CssClass = "notificationSuccessful";
                txtProducts_Description.Text = "";
                txtProducts_Name.Text = "";
            }
            catch (Exception)
            {
                Label1.Text = "Thêm nhóm Sản phẩm mới bị lỗi, Vui lòng kiểm tra lại.";
                Label1.CssClass = "notificationError";
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
    }
}