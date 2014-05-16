using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHOU.SinhVien
{
    public partial class ChonLop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["PK_sSubject"] != null)
            {
                CaHocUC1.Visible = true;
                CaHocUC1.FK_sSubject = Request.QueryString["PK_sSubject"];
                CaHocUC1.FK_sStudent = Session["account_sv"].ToString();
            }
        }

        protected void GoClass_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SinhVien/HocTap.aspx?PK_sSubject=" + CaHocUC1.FK_sSubject + "&lCaHoc=" + CaHocUC1.lCaHoc);
        }
    }
}