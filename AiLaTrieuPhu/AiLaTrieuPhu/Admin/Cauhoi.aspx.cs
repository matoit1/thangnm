using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AiLaTrieuPhu.Library;

namespace AiLaTrieuPhu.Admin
{
    public partial class Cauhoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grvDanhsachCauhoiMuc1.DataSource = CauhoiDAO.DanhsachCauhoi(1);
            grvDanhsachCauhoiMuc1.DataBind();
            grvDanhsachCauhoiMuc2.DataSource = CauhoiDAO.DanhsachCauhoi(2);
            grvDanhsachCauhoiMuc2.DataBind();
        }
    }
}