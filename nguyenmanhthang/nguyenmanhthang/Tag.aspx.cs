using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyenmanhthang
{
    public partial class Tag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Topic_Tag"] != null)
                {
                    txtTag.Text = Request.QueryString["Topic_Tag"];
                }
            }
        }
    }
}