using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
namespace ThangNMjsc.Test
{
    public partial class MailAnonymous : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void btnSubmit_Click(Object sender, EventArgs e)
        {

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //MailMessage objEmail = new MailMessage();
            //objEmail.To = txtTo.Text;
            //objEmail.From = txtFrom.Text;
            //objEmail.Cc = txtCc.Text;
            //objEmail.Subject = txtSubject.Text;
            //objEmail.Body = txtName.Text + ", " + txtComments.Text;
            //objEmail.Priority = MailPriority.High;
            //objEmail.BodyFormat = MailFormat.Html;

            //// Make sure you have appropriate replying permissions from your local system
            ////SmtpMail.SmtpServer = "localhost";

            //try
            //{
            //    SmtpMail.Send(objEmail);
            //    Response.Write("Email sent sucessfully | Đã gởi");
            //}
            //catch (Exception exc)
            //{
            //    Response.Write("Send failure: " + exc.ToString());
            //}
        }
    }
}