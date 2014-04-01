using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using System.Data;
using System.Net.Mail;
using DataAccessObject;
using EntityObject;

namespace DO_AN_TN.UserControl
{
    public partial class ForgotPasswordUC : System.Web.UI.UserControl
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
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sTendangnhapSV = txtAccounts_Username.Text;
                _SinhVienEO = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO);
                if (_SinhVienEO != null)
                {
                    if (txtAccounts_Username.Text == _SinhVienEO.sTendangnhapSV)
                    {
                        if (txtAccounts_Email1.Text == _SinhVienEO.sEmailSV)
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
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sEmailSV = txtAccounts_Email2.Text;
                _SinhVienEO.sSdtSV = txtAccounts_PhoneNumber.Text;
                _SinhVienEO = SinhVienDAO.SinhVien_SelectBysEmailSVvssSdtSV(_SinhVienEO);
                if (_SinhVienEO != null)
                {
                    reset(_SinhVienEO.sTendangnhapSV, txtAccounts_Email2.Text);
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
                string newpass = Security.RandomPassword();
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
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sTendangnhapSV = acc;
                _SinhVienEO.sMatkhauSV = Security.EnCrypt(newpass);
                SinhVienDAO.SinhVien_ResetPassword(_SinhVienEO);
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