using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Admin.Edit
{
    public partial class EditSetting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtWebsite_Content.EnterMode = CKEditor.NET.EnterMode.BR;
            if (!IsPostBack)
            {
                LoadCKEditor();
                if (Request.QueryString["Website_ID"] != null)
                {
                    lblTitle.Text = "Sửa bài viết";
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                    try
                    {
                        DataSet ds = WebsiteBO.getDataSetWebsitebyWebsite_ID(Convert.ToInt32(Request.QueryString["Website_ID"]));
                        txtWebsite_Title.Text = ds.Tables[0].Rows[0]["Website_Title"].ToString();
                        txtWebsite_Content.Text = ds.Tables[0].Rows[0]["Website_Content"].ToString();
                        lblWebsite_LastUpdate.Text = "Cập nhật lần cuối: " + ds.Tables[0].Rows[0]["Website_LastUpdate"].ToString();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    lblTitle.Text = "Thêm bài viết mới";
                    lblWebsite_LastUpdate.Visible = false;
                    btnAdd.Visible = true;
                    btnUpdate.Visible = false;
                }
            }
        }

        protected void LoadCKEditor()
        {
            txtWebsite_Content.config.toolbar = new object[] { 
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                WebsiteBO.setInsertWebsite(txtWebsite_Title.Text, txtWebsite_Content.Text);
                lblError.Text = "Thêm bài viết thành công";
                lblError.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                lblError.Text = "Thêm bài viết bị lỗi, Vui lòng kiểm tra lại.";
                lblError.CssClass = "notificationError";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                WebsiteBO.setUpdateWebsite(Convert.ToInt32(Request.QueryString["Website_ID"]), txtWebsite_Title.Text, txtWebsite_Content.Text);
                lblError.Text = "Cập nhật bài viết thành công";
                lblError.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                lblError.Text = "Cập nhật bài viết bị lỗi, Vui lòng kiểm tra lại.";
                lblError.CssClass = "notificationError";
            }
        }
    }
}