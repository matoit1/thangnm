using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace EHOU.UserControl
{
    public partial class Thong_Tin_Lop_HocUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //tSyncCurrentTime.Interval = 1000;
        }

        public void BinData(tblSubjectEO _tblSubjectEO)
        {
            //MonHocEO _MonHocEO = new MonHocEO();
            //_MonHocEO.PK_sMaMonhoc = _PhanCongCongTacEO.FK_sMaMonhoc;
            //_MonHocEO = MonHocDAO.MonHoc_SelectItem(_MonHocEO);

            //GiangVienEO _GiangVienEO = new GiangVienEO();
            //_GiangVienEO.PK_sMaGV = _PhanCongCongTacEO.FK_sMaGV;
            //_GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);

            //lblsTenlop.Text = _LopHocEO.PK_sMalop + " - " + _LopHocEO.sTenlop;
            lblsTenMonhoc.Text = _tblSubjectEO.sName;
            tblAccountEO _tblAccountEO = new tblAccountEO();
            _tblAccountEO.PK_sUsername = _tblSubjectEO.FK_sTeacher;
            lblsHoTenGV.Text = tblAccountDAO.Account_SelectItem(_tblAccountEO).sName + " - " + _tblSubjectEO.FK_sTeacher;
            //lbliSiso.Text = Convert.ToString(_LopHocEO.iSiso);
            //lbliCaHoc.Text = Convert.ToString(_LichDayVaHocEO.iCaHoc);
            //lbliSoTietDay.Text = Convert.ToString(_LichDayVaHocEO.iSoTietDay);
            //lbltNgayBatDau.Text = _PhanCongCongTacEO.tNgayBatDau.ToShortDateString();
            //lbltNgayKetThuc.Text = _PhanCongCongTacEO.tNgayKetThuc.ToShortDateString();
            lbliTrangThai.Text = GetTextConstants.tblPart_iStatus_GTC(_tblSubjectEO.iStatus);
        }
    }
}