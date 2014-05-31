using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.DataAccessObject;

namespace CongKy.GiangVien
{
    public partial class GiaoTrinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_giangvien"].Value;
                _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                tblChiTietGiaoTrinh_DetailUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                tblChiTietGiaoTrinh_ListUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                tblChiTietGiaoTrinh_ListUC1.newfeed = false;
                tblChiTietGiaoTrinh_DetailUC1.Permit_Access();
                tblChiTietGiaoTrinh_ListUC1.BindData();
            }
            catch
            {
            }
        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID = tblChiTietGiaoTrinh_ListUC1.PK_iGiaoTrinhID;
            _tblChiTietGiaoTrinhEO = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_SelectItem(_tblChiTietGiaoTrinhEO);

            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            _tblMonHocEO.PK_iMonHocID = tblChiTietGiaoTrinh_ListUC1.PK_iMonHocID;

            tblChiTietGiaoTrinh_DetailUC1.BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
            tblChiTietGiaoTrinh_DetailUC1.btnUpdate.Visible = true;
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            tblChiTietGiaoTrinh_DetailUC1.BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
            tblChiTietGiaoTrinh_DetailUC1.btnInsert.Visible = true;
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblChiTietGiaoTrinh_ListUC1.BindData();
        }
    }
}