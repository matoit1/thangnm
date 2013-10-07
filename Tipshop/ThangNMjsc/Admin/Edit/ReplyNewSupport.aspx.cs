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
    public partial class ReplyNewSupport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAnswers_Question.EnterMode = CKEditor.NET.EnterMode.BR;
            Supports_Status();
            LoadCKEditor();
            if (!IsPostBack)
            {
                Int64 Supports_ID;
                if (Request.QueryString["Supports_ID"] != null)
                {
                    Supports_ID = Convert.ToInt64(Request.QueryString["Supports_ID"]);
                }
                else
                {
                    Supports_ID = Convert.ToInt64(null);
                }
                try
                {
                    DataSet dt = AnswersBO.getDataSetSupportsbySupports_ID(Supports_ID);
                    rpSupport.DataSource = dt;
                    rpSupport.DataBind();
                    lblSupports_ID.Text = "Mã hỗ trợ: "  +Convert.ToString(Supports_ID);
                    lblSupports_Type.Text =dt.Tables[0].Rows[0]["Supports_Type"].ToString();
                    lblProducts_Name.Text = "Tên Sản phẩm cần hỗ trợ: " + dt.Tables[0].Rows[0]["Products_Name"].ToString();

                    if (Request.QueryString["ViewMode"] == "true")
                    {
                        PanelReply.Visible = false;
                        btnDelete.Visible = true;
                    }
                }
                catch (Exception) { }
            }
        }
        protected void btnReply_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["administrator"].Value);
                int StaffID = Convert.ToInt32(ds.Tables[0].Rows[0]["Accounts_ID"]);
                DataSet dt = AnswersBO.getDataSetSupportsbySupports_ID(Convert.ToInt64(Request.QueryString["Supports_ID"]));
                int count = dt.Tables[0].Rows.Count;
                Int64 Answers_ID = Convert.ToInt64(dt.Tables[0].Rows[count - 1]["Answers_ID"]);
                Int64 Supports_ID = Convert.ToInt64(dt.Tables[0].Rows[0]["Supports_ID"]);
                AnswersBO.setReplySupports(Answers_ID, Supports_ID, StaffID, txtAnswers_Question.Text);
                msg.Text = "Trả lời hỗ trợ thành công";
                msg.CssClass = "notificationSuccessful";
                Page.Response.Redirect(Page.Request.Url.ToString() + "&ViewMode=true", true);

            }
            catch (Exception)
            {
                msg.Text = "Trả lời hỗ trợ bị lỗi, Vui lòng kiểm tra lại";
                msg.CssClass = "notificationError";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                AnswersBO.setdeleteAnswersbyAnswers_ID(Request.QueryString["Supports_ID"]);
                Response.Redirect(Request.Url.AbsolutePath);
                msg.Text = "Xóa thành công";
                msg.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                msg.Text = "Xóa thất bại vui lòng kiểm tra lại";
                msg.CssClass = "notificationError";
            }
        }

        protected void rpSupport_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (((Label)e.Item.FindControl("lblStaff")).Text == "")
            {
                ((Panel )e.Item.FindControl("pnAdmin")).Visible = false;
        
            }
            
        }

        protected void LoadCKEditor()
        {
            txtAnswers_Question.config.toolbar = new object[] { 
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

        private void Supports_Status()
        {
            try
            {
                DataSet dt = AnswersBO.getDataSetSupportsbySupports_ID(Convert.ToInt64(Request.QueryString["Supports_ID"]));
                if (Convert.ToBoolean(dt.Tables[0].Rows[0]["Supports_Status"]) == true)
                {
                    PanelReply.Visible = false;
                }
            }
            catch (Exception)
            {
                PanelReply.Visible = false;
            }
        }
    }
}