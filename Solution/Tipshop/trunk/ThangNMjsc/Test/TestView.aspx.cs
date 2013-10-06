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

namespace ThangNMjsc.Test
{
    public partial class TestView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ViewDanhSach);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ViewThem);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ViewThem);
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ViewDanhSach);
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ViewNOSP);
        }
    }
}