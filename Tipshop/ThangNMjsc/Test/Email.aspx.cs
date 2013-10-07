using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace ThangNMjsc.Test
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("it.site44.com@gmail.com", "thang303909");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            String[] addr = txtTo.Text.Split(',');
            try
            {
                mail.From = new MailAddress("it.site44.com@gmail.com",
                "ThangNM Mail", System.Text.Encoding.UTF8);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);
                mail.Subject = txtSubject.Text;
                mail.Body = txtConTent.Text;
                //if (lbAttachFile.Items.Count != 0)
                //{
                //    for (i = 0; i < lbAttachFile.Items.Count; i++)
                //        mail.Attachments.Add(new Attachment(lbAttachFile.Items[i].ToString()));
                //}
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.ReplyTo = new MailAddress(txtTo.Text);
                SmtpServer.Send(mail);
            }
            catch (Exception ex) { }
        }
    }
}