using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using BusinessObject;

namespace nguyenmanhthang.UserControl
{
    public partial class DetailTopicUC : System.Web.UI.UserControl
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
            txtTopic_Content.config.toolbar = new object[] { 
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
            try
            {
                //DataSet Author = AccountsBO. Accounts_GetAccounts_IDbyAccounts_Username(Request.Cookies["administrator"].ToString());
                //int Accounts_ID =Convert.ToInt32(Author.Tables[0].Rows[0]["Accounts_ID"]);
                int Accounts_ID = 3;
                bool status;
                string Topic_LinkImage;
                if (Convert.ToInt32(ddlTopic_Status.SelectedValue) == 1) { status = true; }
                else { status = false; }
                if (txtTopic_LinkImage.Text == "") { Topic_LinkImage = "~/Images/Topic/Default.jpg"; }
                else { Topic_LinkImage = txtTopic_LinkImage.Text; }
                bool check = TopicBO.Topic_Insert(Accounts_ID, txtTopic_Title.Text, Topic_LinkImage, ddlTopic_Category.SelectedValue, txtTopic_Tag.Text, txtTopic_Content.Text, 0, status);
                if (check == true)
                {
                    lblMessage.Text = "Thêm bài viết mới thành công";
                    lblMessage.CssClass = "alert_success";
                }
                else
                {
                    lblMessage.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                    lblMessage.CssClass = "alert_error";
                }
            }
            catch
            {
                lblMessage.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                lblMessage.CssClass = "alert_error";
            }
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
                ddlTopic_Category.DataSource = slloadDropDownList;
                ddlTopic_Category.DataTextField = "Value";
                ddlTopic_Category.DataValueField = "Key";
                ddlTopic_Category.DataBind();
            }
            catch
            {
                lblMessage.Text = "Không Load được các Thể loại";
                lblMessage.CssClass = "alert_error";
            }
            try
            {
                slloadDropDownList.Clear();
                Key = "0";
                Value = "Lưu vào nháp";
                slloadDropDownList.Add(Key, Value);
                Value = "Xuất bản";
                Key = "1";
                slloadDropDownList.Add(Key, Value);
                ddlTopic_Status.DataSource = slloadDropDownList;
                ddlTopic_Status.DataTextField = "Value";
                ddlTopic_Status.DataValueField = "Key";
                ddlTopic_Status.DataBind();
                ddlTopic_Status.SelectedIndex = 1;
            }
            catch
            {
                lblMessage.Text = "Không Load được Kiểu đăng bài";
                lblMessage.CssClass = "alert_error";
            }
        }
    }
}