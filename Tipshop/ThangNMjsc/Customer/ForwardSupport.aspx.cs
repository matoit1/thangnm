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

namespace ThangNMjsc.Customer
{
    public partial class Forward : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAnswers_Content.EnterMode = CKEditor.NET.EnterMode.BR;
            LoadCKEditor();
            if (!IsPostBack)
            {
                Supports_Status();
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
                        panelForward.Visible = false;
                    }
                }
                catch (Exception) { }
            }
        }
        protected void btnForward_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 Support_ID = Convert.ToInt64(Request.QueryString["Supports_ID"]);
                AnswersBO.setForwardSupports(Support_ID, txtAnswers_Content.Text);
                msg.Text = "Gửi lại hỗ trợ thành công";
                msg.CssClass = "notificationSuccessful";
                Page.Response.Redirect(Page.Request.Url.ToString() + "&ViewMode=true", true);
            }
            catch (Exception)
            {
                msg.Text = "Gửi lại hỗ trợ bị lỗi, Vui lòng kiểm tra lại";
                msg.CssClass = "notificationError";
            }
        }

        protected void rpSupport_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (((Label)e.Item.FindControl("lblStaff_Name")).Text == "")
            {
                ((Panel )e.Item.FindControl("pnAdmin")).Visible = false;
        
            }
        }

        private void Supports_Status()
        {
            try
            {
                DataSet dt = AnswersBO.getDataSetSupportsbySupports_ID(Convert.ToInt64(Request.QueryString["Supports_ID"]));
                if (Convert.ToBoolean(dt.Tables[0].Rows[0]["Supports_Status"]) == false)
                {
                    panelForward.Visible = false;
                }
            }
            catch (Exception)
            {
                panelForward.Visible = false;
            }
        }

        protected void LoadCKEditor()
        {
            txtAnswers_Content.config.toolbar = new object[] { 
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