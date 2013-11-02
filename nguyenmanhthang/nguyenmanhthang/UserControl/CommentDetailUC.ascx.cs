using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Collections;
using System.Data;

namespace nguyenmanhthang.UserControl
{
    public partial class CommentDetailUC : System.Web.UI.UserControl
    {
        #region "Khai Báo Biến, Thuộc tính"
        public event EventHandler Back;
        #endregion

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
            txtComment_Content.config.toolbar = new object[] { 
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
                int Topic_ID = 3;
                bool status;
                if (Convert.ToInt32(ddlTopic_Status.SelectedValue) == 1) { status = true; }
                else { status = false; }
                bool check = CommentBO.Comment_Insert(Topic_ID,txtComment_Name.Text,txtComment_Email.Text,txtComment_Website.Text, txtComment_Content.Text);
                if (check == true)
                {
                    lblMessage.Text = "Bình luận mới thành công";
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
                //Key = "0";
                //Value = "Articles";
                //slloadDropDownList.Add(Key, Value);
                //Value = "Tutorials";
                //Key = "1";
                //slloadDropDownList.Add(Key, Value);
                //Value = "Freebies";
                //Key = "2";
                //slloadDropDownList.Add(Key, Value);
                //ddlTopic_Category.DataSource = slloadDropDownList;
                //ddlTopic_Category.DataTextField = "Value";
                //ddlTopic_Category.DataValueField = "Key";
                //ddlTopic_Category.DataBind();
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

        public void LoadDetailComment(Int64 ID, bool state) // state =true thì thêm; state =false thì sửa
        {
            txtComment_ID.Text = ID.ToString();
            //if (ID != 0)
            //{
            //    try
            //    {
            //        DataSet dsDetailComment = CommentBO.Topic_getTopicbyTopic_ID(ID);
            //        txtTopic_Title.Text = dsDetailComment.Tables[0].Rows[0]["Topic_Title"].ToString();
            //        txtTopic_Content.Text = dsDetailComment.Tables[0].Rows[0]["Topic_Content"].ToString();
            //        txtTopic_LinkImage.Text = dsDetailComment.Tables[0].Rows[0]["Topic_LinkImage"].ToString();
            //        txtTopic_Tag.Text = dsDetailComment.Tables[0].Rows[0]["Topic_Tag"].ToString();
            //        txtTopic_Author.Text = dsDetailComment.Tables[0].Rows[0]["Accounts_FullName"].ToString();
            //        txtTopic_ID.Text = dsDetailComment.Tables[0].Rows[0]["Topic_ID"].ToString();
            //        txtTopic_LastUpdate.Text = dsDetailComment.Tables[0].Rows[0]["Topic_LastUpdate"].ToString();
            //        txtTopic_Visit.Text = dsDetailComment.Tables[0].Rows[0]["Topic_Visit"].ToString();
            //    }
            //    catch { }
            //}
            //else
            //{
            //    txtTopic_Title.Text = "";
            //    txtTopic_Content.Text = "";
            //    txtTopic_LinkImage.Text = "";
            //    txtTopic_Tag.Text = "";
            //    txtTopic_Author.Text = "";
            //    txtTopic_ID.Text = "";
            //    txtTopic_LastUpdate.Text = "";
            //    txtTopic_Visit.Text = "";
            //}
            //if (state == true)
            //{
            //    pnlInfo1.Visible = false;
            //    pnlInfo2.Visible = false;
            //    btnPublish.Visible = true;
            //    btnUpdate.Visible = false;
            //}
            //else
            //{
            //    pnlInfo1.Visible = true;
            //    pnlInfo2.Visible = true;
            //    btnPublish.Visible = false;
            //    btnUpdate.Visible = true;
            //    txtTopic_ID.Enabled = false;
            //    txtTopic_Author.Enabled = false;
            //    txtTopic_LastUpdate.Enabled = false;
            //    txtTopic_Visit.Enabled = false;
            //}
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //DataSet Author = AccountsBO. Accounts_GetAccounts_IDbyAccounts_Username(Request.Cookies["administrator"].ToString());
            //    //int Accounts_ID =Convert.ToInt32(Author.Tables[0].Rows[0]["Accounts_ID"]);
            //    int Accounts_ID = 3;
            //    bool status;
            //    string Topic_LinkImage;
            //    if (Convert.ToInt32(ddlTopic_Status.SelectedValue) == 1) { status = true; }
            //    else { status = false; }
            //    if (txtTopic_LinkImage.Text == "") { Topic_LinkImage = "~//Images//Topic//Default.jpg"; }
            //    else { Topic_LinkImage = txtTopic_LinkImage.Text; }
            //    string Topic_Description = RemoveHtmlTags.RemoveHtmlTagsUsingCharArray(txtTopic_Content.Text);
            //    bool check = TopicBO.Topic_Update(Convert.ToInt64(txtTopic_ID.Text), Accounts_ID, txtTopic_Title.Text, Topic_LinkImage, 1, 1, txtTopic_Tag.Text, txtTopic_Content.Text, Topic_Description, Convert.ToInt32(txtTopic_Visit.Text), status);
            //    if (check == true)
            //    {
            //        lblMessage.Text = "Thêm bài viết mới thành công";
            //        lblMessage.CssClass = "alert_success";
            //    }
            //    else
            //    {
            //        lblMessage.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
            //        lblMessage.CssClass = "alert_error";
            //    }
            //}
            //catch
            //{
            //    lblMessage.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
            //    lblMessage.CssClass = "alert_error";
            //}
        }

        protected void ibtnBack_Click(object sender, ImageClickEventArgs e)
        {
            if (Back != null)
            {
                Back(this, EventArgs.Empty);
            }
        }
    }
}