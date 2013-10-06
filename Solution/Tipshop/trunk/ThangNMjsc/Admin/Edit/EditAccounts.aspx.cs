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
using System.Text.RegularExpressions;

namespace ThangNMjsc.Admin.Edit
{
    public partial class EditAccounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label14.Text = "";
            if (!IsPostBack)
            {
                txtAccounts_Username.Text = null;
                txtAccounts_Password.Text = null;
                txtAccounts_Address.Attributes.Add("placeholder", "VD:Hà Đông, Hà Nội");
                txtAccounts_DateOfBirth.Attributes.Add("placeholder", "VD: 29/09/1992");
                txtAccounts_FullName.Attributes.Add("placeholder", "VD: Nguyễn Đức Nam");
                txtAccounts_LinkAvatar.Attributes.Add("placeholder", "VD: http://images.com/avatar.jpg");
                txtAccounts_Password.Attributes.Add("placeholder", "VD: ********");
                txtAccounts_PhoneNumber.Attributes.Add("placeholder", "VD: 0125 846 0005");
                txtAccounts_Username.Attributes.Add("placeholder", "VD: nickname");
                txtAccounts_Email.Attributes.Add("placeholder", "VD: user@gmail.com");
                btnRegister.Visible = false;
                btnUpdate.Visible = true;
                lblTitle.Text = "Sửa thông tin tài khoản";
                loadAccounts_Permission();
                if (Request.QueryString["Accounts_Username"] != null)
                {
                    string Accounts_Username = Request.QueryString["Accounts_Username"];
                    try
                    {
                        DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Accounts_Username);
                        img.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                        txtAccounts_Username.Text = Accounts_Username;
                        txtAccounts_Email.Text = ds.Tables[0].Rows[0]["Accounts_Email"].ToString();
                        dropAccounts_Permission.Text = ds.Tables[0].Rows[0]["Accounts_Permission"].ToString();
                        txtAccounts_RegisterDate.Text = ds.Tables[0].Rows[0]["Accounts_RegisterDate"].ToString();
                        txtAccounts_LinkAvatar.Text = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                        txtAccounts_FullName.Text = ds.Tables[0].Rows[0]["Accounts_FullName"].ToString();
                        txtAccounts_Address.Text = ds.Tables[0].Rows[0]["Accounts_Address"].ToString();
                        txtAccounts_DateOfBirth.Text = ds.Tables[0].Rows[0]["Accounts_DateOfBirth"].ToString();
                        txtAccounts_PhoneNumber.Text = ds.Tables[0].Rows[0]["Accounts_PhoneNumber"].ToString();
                        ChkAccounts_Status.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Accounts_Status"]);
                        if (Request.QueryString["ViewMode"] == "true")
                        {
                            Panel1.Enabled = false;
                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    txtAccounts_Username.Enabled = true;
                    btnRegister.Visible = true;
                    btnUpdate.Visible = false;
                    txtAccounts_RegisterDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
                    lblTitle.Text = "Thêm tài khoản mới";
                }

            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Label14.Text = "";
            try
            {
                AccountsBO.setUpdateAccountsAdmin(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, Convert.ToInt32(dropAccounts_Permission.SelectedIndex), txtAccounts_LinkAvatar.Text, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text, ChkAccounts_Status.Checked);
                Label14.Text = "Cập nhật Tài khoản thành công";
                Label14.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label14.Text = "Cập nhật Tài khoản mới bị lỗi, Vui lòng kiểm tra lại";
                Label14.CssClass = "notificationError";
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Label14.Text = "";
            if (dropAccounts_Permission.SelectedIndex == 0)
            {
                try
                {
                    AccountsBO.setInsertAccounts(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, txtAccounts_LinkAvatar.Text, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text);
                    Label14.Text = "Đăng ký Tài khoản thành công";
                    Label14.CssClass = "notificationSuccessful";
                }
                catch (Exception)
                {
                    Label14.Text = "Đăng ký Tài khoản mới bị lỗi, Vui lòng kiểm tra lại";
                    Label14.CssClass = "notificationError";
                    return;
                    
                }
            }
            else
            {
                try
                {
                    AccountsBO.setInsertAccountsAdmin(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, Convert.ToInt32(dropAccounts_Permission.SelectedIndex), txtAccounts_LinkAvatar.Text, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text, ChkAccounts_Status.Checked);
                    Label14.Text = "Đăng ký Tài khoản thành công";
                    Label14.CssClass = "notificationSuccessful";
                }
                catch (Exception)
                {
                    Label14.Text = "Đăng ký Tài khoản mới bị lỗi, Vui lòng kiểm tra lại";
                    Label14.CssClass = "notificationError";
                    return;
                }
            }
        }

        public void loadAccounts_Permission()
        {
            SortedList slPermission = new SortedList();
            string Key = "0";
            string Value = "Khách hàng";
            slPermission.Add(Key, Value);
            Value = "Nhân viên";
            Key = "1";
            slPermission.Add(Key, Value);
            Value = "Quản trị viên";
            Key = "2";
            slPermission.Add(Key, Value);
            dropAccounts_Permission.DataSource = slPermission;
            dropAccounts_Permission.DataTextField = "Value";
            dropAccounts_Permission.DataValueField = "Key";
            dropAccounts_Permission.DataBind();
        }

        protected void txtAccounts_Email_TextChanged(object sender, EventArgs e)
        {
            if (Request.QueryString["Accounts_Username"] == null) //Kiem tra dang them moi hay la sua?
            {
                DataSet a = AccountsBO.setCheckEmailAccounts(txtAccounts_Email.Text);
                if (a.Tables[0].Rows.Count != 0) //Kiem tra xem email da co nguoi khac su dung chua?
                {
                    txtAccounts_Email.Text = "Email này đã có người sử dụng.";
                }
            }
            else
            {
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.QueryString["Accounts_Username"]);
                if (ds.Tables[0].Rows[0]["Accounts_Email"].ToString() != txtAccounts_Email.Text) //Kiem tra xem co phai email hien tai (sua thong tin) ?
                {
                    DataSet a = AccountsBO.setCheckEmailAccounts(txtAccounts_Email.Text);
                    if (a.Tables[0].Rows.Count != 0) //Kiem tra xem email da co nguoi khac su dung chua?
                    {
                        txtAccounts_Email.Text = "Email này đã có người sử dụng.";
                    }
                }
            }
        }

        protected void txtAccounts_Username_TextChanged(object sender, EventArgs e)
        {
            DataSet b = AccountsBO.setCheckUsernameAccounts(txtAccounts_Username.Text);
            if (b.Tables[0].Rows.Count != 0)
            {
                txtAccounts_Username.Text = "Username này đã có người sử dụng.";
            }
        }
    }
}