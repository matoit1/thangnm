using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenmanhthang.Library.Permit_Access
{
    public class WebPageBase : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            if (Session.GetCurrentUser() == null)
            {
                Response.Redirect("Login.aspx?returnUrl=" + Request.Url.PathAndQuery);
            }
            base.OnInit(e);
        }
    }
}