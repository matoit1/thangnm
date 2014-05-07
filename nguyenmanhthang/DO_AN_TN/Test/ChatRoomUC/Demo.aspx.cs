using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries.Constants;

namespace DO_AN_TN.Test.ChatRoomUC
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session["UserName"] = Request.Cookies["sinhvien"].Value;
                ChatUC1.sUser = Request.Cookies["sinhvien"].Value;
                ChatUC1.sRoom = "TTHCM";
                ChatUC1.iType = Quyen_Han_C.Sinh_Vien;
            }
            catch { }
        }
    }
}