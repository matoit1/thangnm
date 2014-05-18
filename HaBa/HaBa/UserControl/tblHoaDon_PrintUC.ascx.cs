using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.DataAccessObject;
using System.Data;
using HaBa.EntityObject;
using HaBa.SharedLibraries;

namespace HaBa.UserControl
{
    public partial class tblHoaDon_PrintUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        private tblHoaDonEO _objtblHoaDonEO;
        public tblHoaDonEO objtblHoaDonEO
        {
            get { return this._objtblHoaDonEO; }
            set { _objtblHoaDonEO = value; }
        }
        private DataSet _dsDetail;
        public DataSet dsDetail
        {
            get { return this._dsDetail; }
            set { _dsDetail = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_lHoaDonID"] != null)
                    {
                        tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                        tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
                        _tblHoaDonEO.PK_lHoaDonID = Convert.ToInt64(Request.QueryString["PK_lHoaDonID"]);
                        _tblHoaDonEO = tblHoaDonDAO.HoaDon_SelectItem(_tblHoaDonEO);
                        _tblChiTietHoaDonEO.FK_lHoaDonID = _tblHoaDonEO.PK_lHoaDonID;
                        DataSet dsChiTietHoaDon = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectByFK_lHoaDonID(_tblChiTietHoaDonEO);
                        objtblHoaDonEO = _tblHoaDonEO;
                        _dsDetail = dsChiTietHoaDon;
                        BindData(_tblHoaDonEO, dsChiTietHoaDon);
                    }
                }
            }
            catch { }
        }
        private void BindData(tblHoaDonEO _tblHoaDonEO, DataSet dsChiTietHoaDon)
        {
            try
            {
                lblOrders_ID.Text = "[ Mã Hóa đơn: #" + _tblHoaDonEO.PK_lHoaDonID + " ]";
                lblPK_lHoaDonID.Text = Convert.ToString(_tblHoaDonEO.PK_lHoaDonID);
                lblFK_iTaiKhoanID_Giao.Text = tblTaiKhoanDAO.TaiKhoan_SelectItemByPK_iTaiKhoanID(_tblHoaDonEO.FK_iTaiKhoanID_Giao).sHoTen;
                lblFK_iTaiKhoanID_Nhan.Text = tblTaiKhoanDAO.TaiKhoan_SelectItemByPK_iTaiKhoanID(_tblHoaDonEO.FK_iTaiKhoanID_Nhan).sHoTen;
                lblFK_iThanhToanID.Text = tblThanhToanDAO.ThanhToan_SelectItemByPK_iThanhToanID(_tblHoaDonEO.FK_iThanhToanID).sTenThanhToan;
                lblsHoTen.Text = _tblHoaDonEO.sHoTen;
                lblsEmail.Text = _tblHoaDonEO.sEmail;
                lblsDiaChi.Text = _tblHoaDonEO.sDiaChi;
                lblsSoDienThoai.Text = _tblHoaDonEO.sSoDienThoai;
                lbltNgayDatHang.Text = Convert.ToString(_tblHoaDonEO.tNgayDatHang);
                lbltNgayGiaoHang.Text = Convert.ToString(_tblHoaDonEO.tNgayGiaoHang);
                lblsGhiChu.Text = _tblHoaDonEO.sGhiChu;
                lbliTrangThai.Text = GetTextConstants.HoaDon_iTrangThai_GTC(_tblHoaDonEO.iTrangThai);
                grvListChiTietHoaDon.DataSource = dsChiTietHoaDon;
                grvListChiTietHoaDon.DataBind();
                Int64 TotalMoney = 0;
                for (int i = 0; i < dsChiTietHoaDon.Tables[0].Rows.Count; i++)
                {
                    Int64 lGiaBan = Convert.ToInt64(dsChiTietHoaDon.Tables[0].Rows[i]["lGiaBan"]);
                    int iSoLuong = Convert.ToInt32(dsChiTietHoaDon.Tables[0].Rows[i]["iSoLuong"]);
                    TotalMoney = TotalMoney + (lGiaBan * iSoLuong);
                }
                lblTotal.Text = "Tổng tiền: " + Convert.ToUInt64(TotalMoney) + Messages.Viet_Nam_Dong;
            }
            catch (Exception)
            {
            }
        }

        #region "Event GridView"
        protected void grvListChiTietHoaDon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListChiTietHoaDon.PageIndex = e.NewPageIndex;
            BindData(objtblHoaDonEO, dsDetail);
        }
        #endregion
    }
}