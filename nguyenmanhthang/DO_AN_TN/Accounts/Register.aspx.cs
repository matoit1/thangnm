﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;
using System.Text.RegularExpressions;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang.Accounts
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            CaptchaProvider captchaPro = new CaptchaProvider();
            if (captchaPro.IsValidCode(txtCaptcha.Text))
            {
                if (txtAccounts_FullName.Text != "")
                {
                    if (txtAccounts_Password.Text != "")
                    {
                        if (txtAccounts_Address.Text != "")
                        {
                            txtAccounts_Address.BackColor = System.Drawing.ColorTranslator.FromHtml("#00CC00");
                            if (chkAgree.Checked == true)
                            {
                                try
                                {
                                    AccountsBO.Insert(txtAccounts_Username.Text, Encrypt.Crypt(txtAccounts_Password.Text), txtAccounts_Email.Text, 0, txtAccounts_LinkAvatar.Text, txtAccounts_FullName.Text, txtAccounts_Address.Text, Convert.ToDateTime(txtAccounts_DateOfBirth.Text).Date, txtAccounts_PhoneNumber.Text, "", 0, true, true);
                                    Response.Cookies["client"].Value = txtAccounts_Username.Text;
                                    Response.Redirect("~/Default.aspx");
                                }
                                catch (Exception)
                                {
                                    lblMsg.Text = "Đăng ký tài khoản không thành công, Vui lòng kiểm tra lại";
                                }
                            }
                            if (chkAgree.Checked == false)
                            {
                                lblMsg.Text = "Bạn chưa đồng ý với các điều khoản của chúng tôi";
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
            else
            {
                lblMsg.Text = "Captcha không chính xác";
                lblMsg.CssClass = "notificationError";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgCaptcha.ImageUrl = new CaptchaProvider().CreateCaptcha();
            }
        }

        protected void txtAccounts_Email_TextChanged(object sender, EventArgs e)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (reg.IsMatch(txtAccounts_Email.Text)) //Kiem tra xem email co dung dinh dang abc@xyz.com ko?
            {
                DataSet a = AccountsBO.CheckAccounts_Email(txtAccounts_Email.Text);
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
            DataSet b = AccountsBO.CheckAccounts_Username(txtAccounts_Username.Text);
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

        protected void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgree.Checked == false)
            {
                lblMsg.Text = "Bạn chưa đồng ý với các điều khoản của chúng tôi";
            }
            else
            {
                lblMsg.Text = "Đăng ký tài khoản";
            }
        }

        protected void ChangeCaptcha_Click(object sender, EventArgs e)
        {
            imgCaptcha.ImageUrl = new CaptchaProvider().CreateCaptcha();
        }
    }
}