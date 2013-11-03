using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Data;
using System.Collections;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang.UserControl
{
    public partial class AccountsDetailUC : System.Web.UI.UserControl
    {
        #region "Khai Báo Biến, Thuộc tính"
        public event EventHandler Back;
        public Int64 Accounts_ID
        {
            get { return Convert.ToInt64(ViewState["Accounts_ID"]); }
            set { ViewState["Accounts_ID"] = value; }
        }
        public bool state
        {
            get { return Convert.ToBoolean(ViewState["state"]); }
            set { ViewState["state"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCKEditor();
                loadDropDownList();
                LoadDetailAccounts(Accounts_ID, false);
            }
        }

        protected void loadCKEditor()
        {
            txtAccounts_Signature.config.toolbar = new object[] { 
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
                string Topic_LinkImage;
                if (txtAccounts_LinkAvatar.Text == "") { Topic_LinkImage = "~//Images//Avatar//Default.jpg"; }
                else { Topic_LinkImage = txtAccounts_LinkAvatar.Text; }
                bool Accounts_Status;
                if (ddlAccounts_Status.Text == "1") { Accounts_Status = true; }
                else { Accounts_Status = false; }
                bool check = AccountsBO.Insert(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, Convert.ToInt32(ddlAccounts_Permission.SelectedValue), Topic_LinkImage, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text, txtAccounts_Signature.Text, 0, chkAccounts_Notification.Checked, Accounts_Status);
                if (check == true)
                {
                    lblMessage.Text = "Thêm tài khoản mới thành công";
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
            int Key;
            string Value;
            try
            {
                Key = 0;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                Key = 1;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                Key = 2;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                Key = 3;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                Key = 4;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                Key = 5;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                Key = 6;
                Value = GetTextConstant.getTextByAccounts_Permission(Key);
                slloadDropDownList.Add(Key, Value);
                ddlAccounts_Permission.DataSource = slloadDropDownList;
                ddlAccounts_Permission.DataTextField = "Value";
                ddlAccounts_Permission.DataValueField = "Key";
                ddlAccounts_Permission.DataBind();
            }
            catch
            {
                lblMessage.Text = "Không Load được các Thể loại";
                lblMessage.CssClass = "alert_error";
            }
            try
            {
                slloadDropDownList.Clear();
                Key = 0;
                Value = "Khóa tài khoản";
                slloadDropDownList.Add(Key, Value);
                Value = "Mở tài khoản";
                Key = 1;
                slloadDropDownList.Add(Key, Value);
                ddlAccounts_Status.DataSource = slloadDropDownList;
                ddlAccounts_Status.DataTextField = "Value";
                ddlAccounts_Status.DataValueField = "Key";
                ddlAccounts_Status.DataBind();
                ddlAccounts_Status.SelectedIndex = 1;
            }
            catch
            {
                lblMessage.Text = "Không Load được Kiểu đăng bài";
                lblMessage.CssClass = "alert_error";
            }
        }

        public void LoadDetailAccounts(Int64 ID, bool state) // state =true thì thêm; state =false thì sửa
        {
            if (ID != 0)
            {
                try
                {
                    DataSet dsDetailAccounts = AccountsBO.SelectInfoByAccounts_ID(ID);
                    txtAccounts_ID.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_ID"].ToString();
                    txtAccounts_Username.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Username"].ToString();
                    txtAccounts_Password.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Password"].ToString();
                    txtAccounts_Email.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Email"].ToString();
                    txtAccounts_FullName.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_FullName"].ToString();
                    txtAccounts_Address.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Address"].ToString();
                    txtAccounts_DateOfBirth.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_DateOfBirth"].ToString();
                    txtAccounts_PhoneNumber.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_PhoneNumber"].ToString();
                    ddlAccounts_Permission.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Permission"].ToString();
                    txtAccounts_LinkAvatar.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                    txtAccounts_Signature.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Signature"].ToString();
                    txtAccounts_Like.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_Like"].ToString();
                    chkAccounts_Notification.Checked = Convert.ToBoolean(dsDetailAccounts.Tables[0].Rows[0]["Accounts_Notification"]);
                    ddlAccounts_Status.SelectedIndex = Convert.ToInt32(dsDetailAccounts.Tables[0].Rows[0]["Accounts_Status"]);
                    txtAccounts_RegisterDate.Text = dsDetailAccounts.Tables[0].Rows[0]["Accounts_RegisterDate"].ToString();
                }
                catch { }
            }
            else
            {
                txtAccounts_ID.Text = "";
                txtAccounts_Username.Text = "";
                txtAccounts_Password.Text = "";
                txtAccounts_Email.Text = "";
                txtAccounts_FullName.Text = "";
                txtAccounts_Address.Text = "";
                txtAccounts_DateOfBirth.Text = "";
                txtAccounts_PhoneNumber.Text = "";
                ddlAccounts_Permission.Text = "";
                txtAccounts_LinkAvatar.Text = "";
                txtAccounts_Signature.Text = "";
                txtAccounts_Like.Text = "";
                chkAccounts_Notification.Checked = false;
                ddlAccounts_Status.Text = "";
                txtAccounts_RegisterDate.Text = "";
            }
            if (state == true)
            {
                pnlAccounts_ID.Visible = false;
                pnlAccounts_Like.Visible = false;
                pnlAccounts_RegisterDate.Visible = false;
                btnPublish.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                pnlAccounts_ID.Visible = true;
                pnlAccounts_Like.Visible = true;
                pnlAccounts_RegisterDate.Visible = true;
                txtAccounts_ID.Enabled = false;
                txtAccounts_Like.Enabled = false;
                txtAccounts_RegisterDate.Enabled = false;
                btnPublish.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Topic_LinkImage;
                if (txtAccounts_LinkAvatar.Text == "") { Topic_LinkImage = "~//Images//Avatar//Default.jpg"; }
                else { Topic_LinkImage = txtAccounts_LinkAvatar.Text; }
                bool Accounts_Status;
                if (ddlAccounts_Status.Text == "1") { Accounts_Status = true; }
                else { Accounts_Status = false; }
                bool check = AccountsBO.Update(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, Convert.ToInt32(ddlAccounts_Permission.SelectedValue), Topic_LinkImage, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text, txtAccounts_Signature.Text, Convert.ToInt32(txtAccounts_Like.Text), chkAccounts_Notification.Checked, Accounts_Status);
                if (check == true)
                {
                    lblMessage.Text = "Sửa tài khoản thành công";
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

        protected void ibtnBack_Click(object sender, ImageClickEventArgs e)
        {
            if (Back != null)
            {
                Back(this, EventArgs.Empty);
            }
        }
    }
}