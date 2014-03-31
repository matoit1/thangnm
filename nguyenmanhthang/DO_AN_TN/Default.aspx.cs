using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnTrangChu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnQuanTri_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QuanTri/Default.aspx");
        }

        protected void btnGiangVien_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GiangVien/Default.aspx");
        }

        protected void btnSinhVien_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SinhVien/Default.aspx");
        }
    }
}