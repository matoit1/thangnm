using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;
using CongKy.EntityObject;
using CongKy.SharedLibraries.Constants;

namespace CongKy.GiangVien
{
    public partial class MonHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                    _tblTaiKhoanEO.sTenDangNhap =
                    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_giangvien"].Value;
                    _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                    switch(Convert.ToInt16(Request.QueryString["iTrangThai"])){
                        case ChiTietGiaoTrinh_iTrangThai_C.Mon_Dang_Day: tblMonHoc_ListUC1.iTrangThai = ChiTietGiaoTrinh_iTrangThai_C.Mon_Dang_Day;
                            tblMonHoc_ListUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                            break;
                        case ChiTietGiaoTrinh_iTrangThai_C.Mo: tblMonHoc_ListUC1.iTrangThai = ChiTietGiaoTrinh_iTrangThai_C.Mo; break;
                    }
                }
            }
            catch
            {
            }
            tblMonHoc_ListUC1.btnAddNew.Visible = false;
            tblMonHoc_DetailUC1.Permit_Access();
        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            _tblMonHocEO.PK_iMonHocID = tblMonHoc_ListUC1.PK_iMonHocID;
            _tblMonHocEO = tblMonHocDAO.MonHoc_SelectItem(_tblMonHocEO);
            tblMonHoc_DetailUC1.BindDataDetail(_tblMonHocEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblMonHocEO _MonHocEO = new tblMonHocEO();
            tblMonHoc_DetailUC1.BindDataDetail(_MonHocEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblMonHoc_ListUC1.BindData();
        }
    }
}