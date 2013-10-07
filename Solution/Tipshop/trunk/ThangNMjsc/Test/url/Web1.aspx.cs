using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ThangNMjsc.url
{
    public partial class Web1 : DevNET.URLRewriter.DevNETPage //ap dung với trang ko dùng MaterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lburl.Text = HttpContext.Current.Request.Url.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lburl.Text = "xin chào";
        }
    }
}