using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;
using System.Text.RegularExpressions;

namespace ThangNMjsc.Customer
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label12.Text = "";
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
                try
                {
                    string Accounts_Username = Request.Cookies["client"].Value;
                    DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Accounts_Username);
                    img.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                    txtAccounts_Username.Text = Accounts_Username;
                    txtAccounts_Password.Text = ds.Tables[0].Rows[0]["Accounts_Password"].ToString();
                    txtAccounts_Email.Text = ds.Tables[0].Rows[0]["Accounts_Email"].ToString();
                    txtAccounts_LinkAvatar.Text = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                    txtAccounts_RegisterDate.Text = ds.Tables[0].Rows[0]["Accounts_RegisterDate"].ToString();
                    txtAccounts_FullName.Text = ds.Tables[0].Rows[0]["Accounts_FullName"].ToString();
                    txtAccounts_Address.Text = ds.Tables[0].Rows[0]["Accounts_Address"].ToString();
                    txtAccounts_DateOfBirth.Text = ds.Tables[0].Rows[0]["Accounts_DateOfBirth"].ToString();
                    txtAccounts_PhoneNumber.Text = ds.Tables[0].Rows[0]["Accounts_PhoneNumber"].ToString();
                }
                catch (Exception) { }
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Label12.Text = "";
            if (txtAccounts_Password.Text != "")
            {
                try
                {
                    AccountsBO.setUpdateAccounts(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, txtAccounts_LinkAvatar.Text, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text);
                    Label12.Text = "Cập nhật thông tin cá nhân thành công";
                    Label12.CssClass = "notificationSuccessful";
                }
                catch (Exception)
                {
                    Label12.Text = "Cập nhật thông tin cá nhân bị lỗi, Vui lòng kiểm tra lại.";
                    Label12.CssClass = "notificationError";
                }
            }
            else
            {
                Label12.Text = "Bạn chưa nhập mật khẩu";
                Label12.CssClass = "notificationError";
            }
        }

        protected void txtAccounts_Email_TextChanged(object sender, EventArgs e)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (reg.IsMatch(txtAccounts_Email.Text)) //Kiem tra xem email co dung dinh dang abc@xyz.com ko?
            {
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["client"].Value);
                if (ds.Tables[0].Rows[0]["Accounts_Email"].ToString() != txtAccounts_Email.Text)  //Kiem tra dang them moi hay la sua?
                {
                    DataSet a = AccountsBO.setCheckEmailAccounts(txtAccounts_Email.Text);
                    if (a.Tables[0].Rows.Count != 0) //Kiem tra xem email da co nguoi khac su dung chua?
                    {
                        txtAccounts_Email.Text = "Email này đã có người sử dụng.";
                    }
                }
            }
            else
            {
                txtAccounts_Email.Text = "Email không hợp lệ, Vui lòng kiểm tra lại";
            }
        }
    }
}