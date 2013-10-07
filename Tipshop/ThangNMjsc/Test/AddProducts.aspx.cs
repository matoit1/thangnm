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

namespace ThangNMjsc.Admin
{
    public partial class AddProducts : System.Web.UI.Page
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
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsBO.setInsertProducts(Convert.ToInt64(dropProducts_Group.SelectedValue), txtProducts_Name.Text, Convert.ToInt64(txtProducts_Price.Text), Convert.ToInt64(txtProducts_Sale.Text), chkProducts_VAT.Checked, txtProducts_Description.Text, txtProducts_Info.Text, txtProducts_Origin.Text, txtProducts_Image1.Text, txtProducts_Image2.Text, txtProducts_Image3.Text, txtProducts_Video.Text);
                Label10.Text = "Thêm Sản phẩm mới thành công";
                Label10.CssClass = "notificationSuccessful";
                txtProducts_Name.Text="";
                txtProducts_Price.Text = "";
                txtProducts_Sale.Text = "";
                txtProducts_Origin.Text = "";
                txtProducts_Image1.Text="";
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