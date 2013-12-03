using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AiLaTrieuPhu
{
    public partial class Finish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["state"] != null)
            {
                if (Request.QueryString["state"] == "true")
                {
                    Response.Write("<script>alert('Lưu điểm thành công !!!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Lưu điểm không thành công !!!')</script>");
                }
            }
        }
    }
}