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
        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_giangvien"].Value;
                    _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                    PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                    switch(Convert.ToInt16(Request.QueryString["iTrangThai"])){
                        case ChiTietGiaoTrinh_iTrangThai_C.Mon_Dang_Day: tblMonHoc_ListUC1.iTrangThai = ChiTietGiaoTrinh_iTrangThai_C.Mon_Dang_Day;
                            tblMonHoc_ListUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                            tblMonHoc_DetailUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                            tblChiTietGiaoTrinh_DetailUC1.PK_iTaiKhoanID = PK_iTaiKhoanID;
                            break;
                        case ChiTietGiaoTrinh_iTrangThai_C.Mo: tblMonHoc_ListUC1.iTrangThai = ChiTietGiaoTrinh_iTrangThai_C.Mo;
                            tblMonHoc_ListUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                            tblMonHoc_DetailUC1.PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                            tabNew.Visible = false;
                            tabAll.Visible = false;
                            tabUpload.Visible = false;
                            break;
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


            tblChiTietGiaoTrinh_ListUC1.PK_iTaiKhoanID = PK_iTaiKhoanID;
            tblChiTietGiaoTrinh_ListUC1.PK_iMonHocID = _tblMonHocEO.PK_iMonHocID;
            tblChiTietGiaoTrinh_ListUC1.iTrangThai = ChiTietGiaoTrinh_iTrangThai_C.Mo;
            tblChiTietGiaoTrinh_ListUC1.newfeed = true;
            tblChiTietGiaoTrinh_ListUC2.PK_iTaiKhoanID = PK_iTaiKhoanID;
            tblChiTietGiaoTrinh_ListUC2.PK_iMonHocID = _tblMonHocEO.PK_iMonHocID;
            tblChiTietGiaoTrinh_ListUC2.iTrangThai = ChiTietGiaoTrinh_iTrangThai_C.Mo;
            tblChiTietGiaoTrinh_ListUC2.newfeed = false;
            tblChiTietGiaoTrinh_ListUC1.BindData();
            tblChiTietGiaoTrinh_ListUC2.BindData();

            tblChiTietGiaoTrinh_DetailUC1.Permit_Access();
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            _tblMonHocEO = new tblMonHocEO();
            tblChiTietGiaoTrinh_DetailUC1.BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
            tblChiTietGiaoTrinh_DetailUC1.btnInsert.Visible = true;

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