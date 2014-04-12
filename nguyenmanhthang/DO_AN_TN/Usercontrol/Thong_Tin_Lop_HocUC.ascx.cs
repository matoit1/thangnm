using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;

namespace DO_AN_TN.UserControl
{
    public partial class Thong_Tin_Lop_HocUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BinData(LopHocEO _LopHocEO, PhanCongCongTacEO _PhanCongCongTacEO)
        {
            lblsTenlop.Text = _LopHocEO.sTenlop;
            lbliSiso.Text = Convert.ToString(_LopHocEO.iSiso);
            lblsHoTenGV.Text = _PhanCongCongTacEO.FK_sMaGV;
            lblsTenMonhoc.Text = _PhanCongCongTacEO.FK_sMaMonhoc;
        }
    }
}