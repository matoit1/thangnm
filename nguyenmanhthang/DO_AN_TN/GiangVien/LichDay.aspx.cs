using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.GiangVien
{
    public partial class LichDay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LichDayVaHoc_ListUC1.btnAddNew.Visible = false;
                LichDayVaHoc_ListUC1.btnDeleteList.Visible = false;
                if (!IsPostBack)
                {
                    PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                    LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                    GiangVienEO _GiangVienEO = new GiangVienEO();
                    _GiangVienEO.sTendangnhapGV = Request.Cookies["giangvien"].Value;
                    _PhanCongCongTacEO.FK_sMaGV = GiangVienDAO.GiangVien_SelectBysTendangnhapGV(_GiangVienEO).PK_sMaGV;
                    LichDayVaHoc_ListUC1.BindData(_PhanCongCongTacEO, _LichDayVaHocEO, 1);
                }
            }
            catch { }
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GiangVien/GiangDay.aspx?FK_sMaPCCT=" + LichDayVaHoc_ListUC1.FK_sMaPCCT + "&PK_sMalop=" + LichDayVaHoc_ListUC1.FK_sMalop + "&iCaHoc=" + LichDayVaHoc_ListUC1.iCaHoc);
        }
    }
}