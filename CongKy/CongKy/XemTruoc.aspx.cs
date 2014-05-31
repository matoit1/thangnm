using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.SharedLibraries.Constants;
using CongKy.SharedLibraries;
using CongKy.DataAccessObject;
using System.Data;

namespace CongKy
{
    public partial class XemTruoc : System.Web.UI.Page
    {
        #region "Properties & Event"
        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }

        private Int32 _PK_iMonHocID;
        public Int32 PK_iMonHocID
        {
            get { return this._PK_iMonHocID; }
            set { _PK_iMonHocID = value; }
        }

        private Int32 _PK_iGiaoTrinhID;
        public Int32 PK_iGiaoTrinhID
        {
            get { return this._PK_iGiaoTrinhID; }
            set { _PK_iGiaoTrinhID = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                if (Request.Cookies["CongKy_sinhvien"] != null)
                {
                    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_sinhvien"].Value;
                }
                else
                {
                    if (Request.Cookies["CongKy_giangvien"] != null)
                    {
                        _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_giangvien"].Value;
                    }
                    else
                    {
                        if (Request.Cookies["CongKy_quantri"] != null)
                        {
                            _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_quantri"].Value;
                        }
                    }
                }
                if (_tblTaiKhoanEO.sTenDangNhap == null)
                {
                    Response.Redirect("~/Loi.aspx?Type=" + ERROR_C.Chua_Dang_Nhap);
                }
                else
                {
                    _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                    PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                }
                if (Request.QueryString["PK_iGiaoTrinhID"] != null)
                {

                    int PK_iGiaoTrinhID = Convert.ToInt32(Request.QueryString["PK_iGiaoTrinhID"]);
                    DataSet ds = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_By_PK_iTaiKhoanID_PK_iMonHocID_PK_iGiaoTrinhID(PK_iTaiKhoanID, PK_iMonHocID, PK_iGiaoTrinhID, ChiTietGiaoTrinh_iTrangThai_C.Mo, false);
                    if (_tblTaiKhoanEO.iQuyenHan != TaiKhoan_iQuyenHan_C.QuanTri){
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            Response.Redirect("~/Loi.aspx?Type=" + ERROR_C.Khong_Co_Quyen);
                        }
                    }
                    tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                    _tblChiTietGiaoTrinhEO = DataSet2Object.ChiTietGiaoTrinhDO(ds);
                    BindData(_tblChiTietGiaoTrinhEO);
                    CheckTypeFile(_tblChiTietGiaoTrinhEO.iType, _tblChiTietGiaoTrinhEO.sLinkDownload);
                    
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        public void CheckTypeFile(Int16 type, string sLinkDownload)
        {

            switch (type)
            {
                case ChiTietGiaoTrinh_iType_C.Video:
                    pnlPdf.Visible = false;
                    pnlVideo.Visible = true;
                    VideoUC1.sLinkVideo = sLinkDownload;
                    break;
                case ChiTietGiaoTrinh_iType_C.Pdf:
                    pnlPdf.Visible = true;
                    pnlVideo.Visible = false;
                    PdfUC1.sLinkEbook = sLinkDownload;
                    break;
                default: lblMsg.Text = Messages.Dinh_Dang_File_Khong_Ho_Tro_Xem_Truoc;
                    pnlPdf.Visible = false;
                    pnlVideo.Visible = false;
                    break;
            }
        }

        public void BindData(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            lblPK_iGiaoTrinhID.Text = _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID.ToString();
            lblsTenBaiHoc.Text = _tblChiTietGiaoTrinhEO.sTenBaiHoc;
            lblsThongTin.Text = _tblChiTietGiaoTrinhEO.sThongTin;
            lbltNgayCapNhat.Text = _tblChiTietGiaoTrinhEO.tNgayCapNhat.ToString();
            lbliTrangThai.Text =    GetTextConstants.ChiTietGiaoTrinh_iTrangThai_GTC(_tblChiTietGiaoTrinhEO.iTrangThai);
            hplDownload.NavigateUrl = _tblChiTietGiaoTrinhEO.sLinkDownload;
        }
    }
}