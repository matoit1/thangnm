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
    public partial class NewSupport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAnswers_Content.EnterMode = CKEditor.NET.EnterMode.BR;
            LoadCKEditor();
            if (!IsPostBack)
            {
                txtSupports_Type.Attributes.Add("placeholder", "VD:Báo lỗi sản phẩm");
                loadGroupProducts();
                loadProducts();
                if (Request.QueryString["Accounts_Username"] != null)
                {
                    txtAccounts_Username.Text = Request.QueryString["Accounts_Username"];
                }
                else
                {
                    if (Request.Cookies["client"] != null)
                    {
                        txtAccounts_Username.Text = Request.Cookies["client"].Value;
                    }
                    else
                    {
                        txtAccounts_Username.Text = "";
                    }
                }
                try
                {
                    DataSet ds = AccountsBO.getDataSetAccountsbyUsername(txtAccounts_Username.Text);
                    txtAccounts_Email.Text = ds.Tables[0].Rows[0]["Accounts_Email"].ToString();
                    txtAccounts_FullName.Text = ds.Tables[0].Rows[0]["Accounts_FullName"].ToString();
                    txtAccounts_PhoneNumber.Text = ds.Tables[0].Rows[0]["Accounts_PhoneNumber"].ToString();
                }
                catch (Exception) { }
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


        public void loadProducts()
        {
            try
            {
                DataTable dt = ProductsBO.getDataSetGroupProducts(Convert.ToInt64(dropProducts_Group.SelectedValue)).Tables[0];
                string Key = "";
                string Value = "";
                SortedList slCountry = new SortedList();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Value = dt.Rows[i]["Products_Name"].ToString();
                    Key = dt.Rows[i]["Products_ID"].ToString();
                    slCountry.Add(Key, Value);
                }
                dropProducts.DataSource = slCountry;
                dropProducts.DataTextField = "Value";
                dropProducts.DataValueField = "Key";
                dropProducts.DataBind();
            }
            catch { }
        }



        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (dropProducts.SelectedValue != "")
            {
                try
                {
                    DataSet ds = AccountsBO.getDataSetAccountsbyUsername(txtAccounts_Username.Text);
                    int id_Customer = Convert.ToInt32(ds.Tables[0].Rows[0]["Accounts_ID"]);
                    AnswersBO.setInsertAnswers(id_Customer, Convert.ToInt64(dropProducts.SelectedValue), txtSupports_Type.Text, txtAnswers_Content.Text);
                    Label12.Text = "Gửi yêu cầu hỗ trợ mới thành công";
                    Label12.CssClass = "notificationSuccessful";
                    txtSupports_Type.Text="";
                    txtAnswers_Content.Text = "";
                }
                catch (Exception)
                {
                    Label12.Text = "Gửi yêu cầu hỗ trợ mới bị lỗi, Vui lòng kiểm tra lại.";
                    Label12.CssClass = "notificationError";
                }
            }
            else
            {
                Label12.Text = "Bạn chưa chọn sản phẩm cần hỗ trợ";
                Label12.CssClass = "notificationError";
            }
        }

        protected void dropProducts_Group_Select(object sender, EventArgs e)
        {
            loadProducts();
        }

        protected void btnProfile_click(object sender, EventArgs e)
        {
            string Profile = "~/Customer/Profile.aspx?id=" + txtAccounts_Username.Text;
            Response.Redirect(Profile);
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