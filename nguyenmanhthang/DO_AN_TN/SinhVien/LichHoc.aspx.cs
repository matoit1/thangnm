using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.SinhVien
{
    public partial class LichHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LichDayVaHoc_ListUC1.btnAddNew.Visible = false;
            LichDayVaHoc_ListUC1.btnDeleteList.Visible = false;
            if (!IsPostBack)
            {
                PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sTendangnhapSV = Request.Cookies["sinhvien"].Value;
                _LichDayVaHocEO.FK_sMalop = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).FK_sMaLop;
                LichDayVaHoc_ListUC1.BindData(_PhanCongCongTacEO, _LichDayVaHocEO, 1);
                LichDayVaHoc_ListUC2.BindData(_PhanCongCongTacEO, _LichDayVaHocEO, 2);
            }
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            //LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
            //_LichDayVaHocEO.FK_sMaPCCT = LichDayVaHoc_ListUC1.FK_sMaPCCT;
            //_LichDayVaHocEO.FK_sMalop = LichDayVaHoc_ListUC1.FK_sMalop;
            //_LichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(_LichDayVaHocEO);
            //LichDayVaHoc_ListUC1.BindDataDetail(_LichDayVaHocEO);
            Response.Redirect("~/SinhVien/HocTap.aspx?PK_sMalop=" + LichDayVaHoc_ListUC1.FK_sMalop + "&FK_sMaPCCT=" + LichDayVaHoc_ListUC1.FK_sMaPCCT);
        }
    }
}