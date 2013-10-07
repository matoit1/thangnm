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
using System.Net.Mail;

namespace ThangNMjsc.Accounts
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { }
        }

        protected void lbtnReset_Click(object sender, EventArgs e)
        {
            DataSet ds = AccountsBO.getDataSetAccountsbyUsername(txtAccounts_Username.Text);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (txtAccounts_Username.Text == ds.Tables[0].Rows[0]["Accounts_Username"].ToString())
                {
                    if (txtAccounts_Email.Text == ds.Tables[0].Rows[0]["Accounts_Email"].ToString())
                    {
                        SmtpClient SmtpServer = new SmtpClient();
                        SmtpServer.Credentials = new System.Net.NetworkCredential("it.site44.com@gmail.com", "ydtndlpacvzspqid");
                        SmtpServer.Port = 587;
                        SmtpServer.Host = "smtp.gmail.com";
                        SmtpServer.EnableSsl = true;
                        MailMessage mail = new MailMessage();
                        String[] addr = txtAccounts_Email.Text.Split(',');
                        try
                        {
                            string newpass = Encrypt.RandomPassword();
                            mail.From = new MailAddress("it.site44.com@gmail.com", "Reset Password [" + txtAccounts_Username.Text + "] ThangNM Join Stock Company", System.Text.Encoding.UTF8);
                            Byte i;
                            for (i = 0; i < addr.Length; i++)
                                mail.To.Add(addr[i]);
                            mail.Subject = "Reset Password [" + txtAccounts_Username.Text + "] ThangNM Join Stock Company";
                            mail.Body = "Tên đăng nhập: [" + txtAccounts_Username.Text + "].  Mật khẩu mới của bạn là: " + newpass;
                            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                            mail.ReplyTo = new MailAddress(txtAccounts_Email.Text);
                            SmtpServer.Send(mail);
                            AccountsBO.setResetPasswordAccounts(txtAccounts_Username.Text, Encrypt.Crypt(newpass));
                            lblMsg.Text = "Hệ thống đã gửi mật khẩu mới vào Email của bạn";
                            lblMsg.CssClass = "successful";
                        }
                        catch (Exception ex)
                        {
                            lblMsg.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                            lblMsg.CssClass = "error";
                        }
                    }
                    else
                    {
                        lblMsg.Text = "Địa chỉ Email không đúng, Vui lòng thử lại";
                        lblMsg.CssClass = "error";
                    }
                }
                else
                {
                    lblMsg.Text = "Tài khoản không đúng, Vui lòng thử lại";
                    lblMsg.CssClass = "error";
                }
            }
            else
            {
                lblMsg.Text = "Không có tên tài khoản và email nào trùng khớp. Vui lòng kiểm tra lại";
                lblMsg.CssClass = "error";
            }            
        }
    }
}