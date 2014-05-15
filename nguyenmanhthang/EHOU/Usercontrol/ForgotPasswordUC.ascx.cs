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

namespace EHOU.UserControl
{
    public partial class ForgotPasswordUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ResetPassword;
        public event EventHandler FindAccount;
        public string login_url
        {
            get { return (string)ViewState["login_url"]; }
            set { ViewState["login_url"] = value; }
        }
        #endregion

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
                if (ResetPassword != null)
                {
                    ResetPassword(this, EventArgs.Empty);
                }
            }
            else
            {
                lblMsg1.Text = Messages.Sai_Captcha;
                lblMsg1.CssClass = "notificationError";
            }
        }

        protected void btnFindAccount_Click(object sender, EventArgs e)
        {
            CaptchaProvider captchaPro = new CaptchaProvider();
            if (captchaPro.IsValidCode(txtCaptcha2.Text))
            {
                if (FindAccount != null)
                {
                    FindAccount(this, EventArgs.Empty);
                } 
            }
            else
            {
                lblMsg2.Text = Messages.Sai_Captcha;
                lblMsg2.CssClass = "notificationError";
            }
        }

        public void Reset_Password(string acc, string email, Int16 type){
            string newpass = Security.RandomPassword();
            bool state = false;
            SinhVienEO _SinhVienEO = new SinhVienEO();
            GiangVienEO _GiangVienEO = new GiangVienEO();
            try
            {
                switch (type)
                {
                    case 1:
                        _SinhVienEO.sTendangnhapSV = acc;
                        _SinhVienEO.sMatkhauSV = Security.EnCrypt(newpass);
                        if (SinhVienDAO.SinhVien_ResetPassword(_SinhVienEO) == true)
                        {
                            Sent_Mail(acc, email, newpass);
                            state = true;
                        }
                        break;
                    case 2: 
                        _GiangVienEO.sTendangnhapGV = acc;
                        _GiangVienEO.sMatkhauGV = Security.EnCrypt(newpass);
                        if (GiangVienDAO.GiangVien_ResetPassword(_GiangVienEO) == true)
                        {
                            Sent_Mail(acc, email, newpass);
                            state = true;
                        }
                        break;
                    case 3: 
                        _GiangVienEO.sTendangnhapGV = acc;
                        _GiangVienEO.sMatkhauGV = Security.EnCrypt(newpass);
                        if (GiangVienDAO.GiangVien_ResetPassword(_GiangVienEO) == true)
                        {
                            Sent_Mail(acc, email, newpass);
                            state = true;
                        }
                        break;
                }
                if(state == true){
                    txtsTendangnhap.Text = "";
                    txtsEmail1.Text = "";
                    txtsSdt.Text = "";
                    txtsEmail2.Text = "";
                }
                else{
                    lblMsg1.Text = Messages.Doi_Mat_Khau_That_Bai;
                    lblMsg1.CssClass = "notificationError";
                    lblMsg2.Text = Messages.Doi_Mat_Khau_That_Bai;
                    lblMsg2.CssClass = "notificationError";
                }
            }
            catch
            {
                lblMsg1.Text = Messages.Doi_Mat_Khau_That_Bai;
                lblMsg1.CssClass = "notificationError";
                lblMsg2.Text = Messages.Doi_Mat_Khau_That_Bai;
                lblMsg2.CssClass = "notificationError";
            }
                  
        }

        public void Sent_Mail(string acc, string email, string newpass)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("it.site44.com@gmail.com", "ydtndlpacvzspqid");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            String[] addr = email.Split(',');
            try
            {
                
                mail.From = new MailAddress("it.site44.com@gmail.com", "Nguyễn Mạnh Thắng - ThangNM", System.Text.Encoding.UTF8);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);
                mail.Subject = "Yêu cầu lấy lại mật khẩu [" + acc + "] " + Request.Url.Host;
                mail.Body = "Bạn đã sử dụng chức năng lấy lại mật khẩu trên website " + Request.Url.Host + "\n\n" +
                    "   Tên đăng nhập của bạn là: " + acc + ".\n" +
                    "   Mật khẩu mới của bạn là : " + newpass + "\n\nBạn có thể đăng nhập tại đây: " + login_url;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.ReplyTo = new MailAddress(email);
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                lblMsg1.Text = Messages.Gui_Mail_Doi_Mat_Khau_That_Bai;
                lblMsg1.CssClass = "notificationError";
                lblMsg2.Text = Messages.Gui_Mail_Doi_Mat_Khau_That_Bai;
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