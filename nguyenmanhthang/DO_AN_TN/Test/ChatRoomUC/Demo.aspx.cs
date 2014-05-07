using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries.Constants;
using EntityObject;

namespace DO_AN_TN.Test.ChatRoomUC
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TinNhanEO _TinNhanEO = new TinNhanEO();
                _TinNhanEO.FK_sPhongChat = "TTHCM";
                _TinNhanEO.FK_sNguoiGui = Request.Cookies["sinhvien"].Value;
                _TinNhanEO.iTrangThai = 1;
                ChatUC1.objTinNhanEO = _TinNhanEO;
            }
            catch { }
        }
    }
}