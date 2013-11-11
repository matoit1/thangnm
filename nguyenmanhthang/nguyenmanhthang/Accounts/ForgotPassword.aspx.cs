using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Data;
using nguyenmanhthang.Library.Common;
using System.Net.Mail;

namespace nguyenmanhthang.Accounts
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgCaptcha1.ImageUrl = new CaptchaProvider().CreateCaptcha();
                imgCaptcha2.ImageUrl = imgCaptcha1.ImageUrl;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            CaptchaProvider captchaPro = new CaptchaProvider();
            if (captchaPro.IsValidCode(txtCaptcha1.Text))
            {
                DataSet ds = AccountsBO.SelectInfoByAccounts_Username(txtAccounts_Username.Text);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (txtAccounts_Username.Text == ds.Tables[0].Rows[0]["Accounts_Username"].ToString())
                    {
                        if (txtAccounts_Email1.Text == ds.Tables[0].Rows[0]["Accounts_Email"].ToString())
                        {
                            reset(txtAccounts_Username.Text, txtAccounts_Email1.Text);
                            lblMsg1.Text = "Hệ thống đã gửi mật khẩu mới vào Email của bạn";
                            lblMsg1.CssClass = "notificationSuccessful";
                        }
                        else
                        {
                            lblMsg1.Text = "Địa chỉ Email không đúng, Vui lòng thử lại";
                            lblMsg1.CssClass = "notificationError";
                        }
                    }
                    else
                    {
                        lblMsg1.Text = "Tài khoản không đúng, Vui lòng thử lại";
                        lblMsg1.CssClass = "notificationError";
                    }
                }
                else
                {
                    lblMsg1.Text = "Không có tên tài khoản và email nào trùng khớp. Vui lòng kiểm tra lại";
                    lblMsg1.CssClass = "notificationError";
                }
            }
            else
            {
                lblMsg1.Text = "Captcha không chính xác";
                lblMsg1.CssClass = "notificationError";
            }
        }

        protected void btnFindAccount_Click(object sender, EventArgs e)
        {
            CaptchaProvider captchaPro = new CaptchaProvider();
            if (captchaPro.IsValidCode(txtCaptcha2.Text))
            {
                DataSet ds = AccountsBO.SelectInfoByAccounts_EmailvsAccounts_PhoneNumber(txtAccounts_Email2.Text, txtAccounts_PhoneNumber.Text);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    reset(ds.Tables[0].Rows[0]["Accounts_Username"].ToString(), txtAccounts_Email2.Text);
                    lblMsg2.Text = "Hệ thống đã gửi mật khẩu mới vào Email của bạn";
                    lblMsg2.CssClass = "notificationSuccessful";
                }
                else
                {
                    lblMsg2.Text = "Không có email và số điện thoại nào trùng khớp. Vui lòng kiểm tra lại";
                    lblMsg2.CssClass = "notificationError";
                }
            }
            else
            {
                lblMsg2.Text = "Captcha không chính xác";
                lblMsg2.CssClass = "notificationError";
            }
        }

        public void reset(String acc, String email){
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("it.site44.com@gmail.com", "ydtndlpacvzspqid");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            String[] addr = email.Split(',');
            try
            {
                string newpass = Encrypt.RandomPassword();
                mail.From = new MailAddress("it.site44.com@gmail.com", "Nguyễn Mạnh Thắng - ThangNM", System.Text.Encoding.UTF8);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);
                mail.Subject = "Yêu cầu lấy lại mật khẩu [" + acc + "] http://nguyenmanhthang.tk ";
                mail.Body = "Yêu cầu lấy lại mật khẩu từ Website Nguyễn Mạnh Thắng - ThangNM \n\n   Tên đăng nhập của bạn là: " + acc +
                    ".\n   Mật khẩu mới của bạn là : " + newpass + "\n\nBạn có thể đăng nhập tại đây: http://nguyenmanhthang.tk/accounts/login.aspx";
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.ReplyTo = new MailAddress(email);
                SmtpServer.Send(mail);
                AccountsBO.ResetPassword(acc, Encrypt.Crypt(newpass));
                txtAccounts_Username.Text = "";
                txtAccounts_Email1.Text = "";
                txtAccounts_PhoneNumber.Text = "";
                txtAccounts_Email2.Text = "";
            }
            catch (Exception ex)
            {
                lblMsg1.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                lblMsg1.CssClass = "notificationError";
                lblMsg2.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                lblMsg2.CssClass = "notificationError";
            }        
        }

        protected void ChangeCaptcha_Click(object sender, EventArgs e)
        {
            imgCaptcha1.ImageUrl = new CaptchaProvider().CreateCaptcha();
            imgCaptcha2.ImageUrl = imgCaptcha1.ImageUrl;
        }
    }
}