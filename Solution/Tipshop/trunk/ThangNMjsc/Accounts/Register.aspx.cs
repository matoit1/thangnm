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
using System.Text.RegularExpressions;

namespace ThangNMjsc.Accounts
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtAccounts_FullName.Text != "")
            {
                if (txtAccounts_Password.Text != "")
                {
                    if (txtAccounts_Address.Text != "")
                    {
                        txtAccounts_Address.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CC00");
                        if (CheckBoxAgree.Checked == true)
                        {
                            try
                            {
                                AccountsBO.setInsertAccounts(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, txtAccounts_LinkAvatar.Text, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text);
                                Response.Cookies["client"].Value = txtAccounts_Username.Text;
                                Response.Redirect("~/Customer/Default.aspx");
                            }
                            catch (Exception)
                            {
                                lblerror.Text = "Đăng ký tài khoản không thành công, Vui lòng kiểm tra lại";
                            }
                        }
                        if (CheckBoxAgree.Checked == false)
                        {
                            lblerror.Text = "Bạn chưa đồng ý với các điều khoản của chúng tôi";
                        }
                    }
                    else
                    {
                        txtAccounts_Address.Attributes.Add("placeholder", "Bạn phải nhập đúng địa chỉ");
                        txtAccounts_Address.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    }
                }
                else
                {
                    txtAccounts_Password.Text = "Bạn chưa nhập mật khẩu";
                    txtAccounts_Password.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                }
            }
            else
            {
                txtAccounts_FullName.Attributes.Add("placeholder", "Bạn phải nhập đúng tên của mình");
                txtAccounts_FullName.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            }
        }

        protected void txtAccounts_Email_TextChanged(object sender, EventArgs e)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (reg.IsMatch(txtAccounts_Email.Text)) //Kiem tra xem email co dung dinh dang abc@xyz.com ko?
            {
                DataSet a = AccountsBO.setCheckEmailAccounts(txtAccounts_Email.Text);
                if (a.Tables[0].Rows.Count != 0) //Kiem tra xem email da co nguoi khac su dung chua?
                {
                    txtAccounts_Email.Attributes.Add("placeholder", "Email này đã có người sử dụng.");
                    txtAccounts_Email.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                }
                else
                {
                    txtAccounts_Email.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CC00");
                }
             }
             else
             {
                txtAccounts_Email.Attributes.Add("placeholder", "Email không hợp lệ, Vui lòng kiểm tra lại");
                txtAccounts_Email.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
             }
        }

        protected void txtAccounts_Username_TextChanged(object sender, EventArgs e)
        {
            DataSet b = AccountsBO.setCheckUsernameAccounts(txtAccounts_Username.Text);
            if (b.Tables[0].Rows.Count != 0)
            {
                txtAccounts_Username.Attributes.Add("placeholder", "Username này đã có người sử dụng.");
                txtAccounts_Username.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            }
            else
            {
                txtAccounts_Username.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CC00");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void CheckBoxAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAgree.Checked == false)
            {
                lblerror.Text = "Bạn chưa đồng ý với các điều khoản của chúng tôi";
            }
            else
            {
                lblerror.Text = "Đăng ký tài khoản";
            }
        }
    }
}