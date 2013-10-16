using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace nguyenmanhthang.Admin
{
    public partial class New_Topic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCKEditor();
                loadDropDownList();
            }
        }

        protected void loadCKEditor()
        {
            txtContent.config.toolbar = new object[] { 
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

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            txtContent.Text = "helo";
            txtContent.Text =Convert.ToString(ddlTypePublic.SelectedIndex);
        }

        public void loadDropDownList()
        {
            SortedList slloadDropDownList = new SortedList();
            string Key, Value;
            try
            {
                Key = "0";
                Value = "Articles";
                slloadDropDownList.Add(Key, Value);
                Value = "Tutorials";
                Key = "1";
                slloadDropDownList.Add(Key, Value);
                Value = "Freebies";
                Key = "2";
                slloadDropDownList.Add(Key, Value);
                ddlCategory.DataSource = slloadDropDownList;
                ddlCategory.DataTextField = "Value";
                ddlCategory.DataValueField = "Key";
                ddlCategory.DataBind();
            }
            catch {
                lblMessage.Text = "Không Load được các Thể loại";
                lblMessage.CssClass = "alert_error";
            }
            try
            {
                slloadDropDownList.Clear();
                Key = "0";
                Value = "Xuất bản";
                slloadDropDownList.Add(Key, Value);
                Value = "Lưu vào nháp";
                Key = "1";
                slloadDropDownList.Add(Key, Value);
                ddlTypePublic.DataSource = slloadDropDownList;
                ddlTypePublic.DataTextField = "Value";
                ddlTypePublic.DataValueField = "Key";
                ddlTypePublic.DataBind();
            }
            catch
            {
                lblMessage.Text = "Không Load được Kiểu đăng bài";
                lblMessage.CssClass = "alert_error";
            }
        }
    }
}