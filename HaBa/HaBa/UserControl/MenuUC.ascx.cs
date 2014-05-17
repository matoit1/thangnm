using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HaBa.UserControl
{
    public partial class MenuUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Nhan.aspx?keyword=" +txtKeyWord.Text);
        }
    }
}