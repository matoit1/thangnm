using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;

namespace HaBa.UserControl
{
    public partial class tblHoaDon_DetailUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public Int16 iType
        {
            get { return (Int16)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblHoaDonEO _tblHoaDonEO)
        {
            txtPK_lHoaDonID.Text = Convert.ToString(_tblHoaDonEO.PK_lHoaDonID);
            try { ddlFK_iTaiKhoanID_Giao.SelectedValue = Convert.ToString(_tblHoaDonEO.FK_iTaiKhoanID_Giao); }
            catch { ddlFK_iTaiKhoanID_Giao.SelectedIndex = 0; }
            try { ddlFK_iTaiKhoanID_Nhan.SelectedValue = Convert.ToString(_tblHoaDonEO.FK_iTaiKhoanID_Nhan); }
            catch { ddlFK_iTaiKhoanID_Nhan.SelectedIndex = 0; }
            try { ddlFK_iThanhToanID.SelectedValue = Convert.ToString(_tblHoaDonEO.FK_iThanhToanID); }
            catch { ddlFK_iTaiKhoanID_Giao.SelectedIndex = 0; }
            txtsHoTen.Text = Convert.ToString(_tblHoaDonEO.sHoTen);
            txtsEmail.Text = Convert.ToString(_tblHoaDonEO.sEmail);
            txtsHoTen.Text = Convert.ToString(_tblHoaDonEO.sHoTen);
            txtsEmail.Text = Convert.ToString(_tblHoaDonEO.sDiaChi);
            txtsHoTen.Text = Convert.ToString(_tblHoaDonEO.sSoDienThoai);
            txtsEmail.Text = Convert.ToString(_tblHoaDonEO.sGhiChu);
            txttNgayDatHang.Text = Convert.ToString(_tblHoaDonEO.tNgayDatHang);
            txttNgayGiaoHang.Text = Convert.ToString(_tblHoaDonEO.tNgayGiaoHang);
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblHoaDonEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblHoaDonEO getObject()
        {
            try
            {
                tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                _tblHoaDonEO.PK_lHoaDonID = Convert.ToInt64(txtPK_lHoaDonID.Text);
                try { _tblHoaDonEO.FK_iTaiKhoanID_Giao = Convert.ToInt32(ddlFK_iTaiKhoanID_Giao.SelectedValue); }
                catch { lblFK_iTaiKhoanID_Giao.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblHoaDonEO.FK_iTaiKhoanID_Giao = 0; }
                try { _tblHoaDonEO.FK_iTaiKhoanID_Nhan = Convert.ToInt32(ddlFK_iTaiKhoanID_Nhan.SelectedValue); }
                catch { lblFK_iTaiKhoanID_Nhan.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblHoaDonEO.FK_iTaiKhoanID_Nhan = 0; }
                _tblHoaDonEO.FK_iThanhToanID = Convert.ToInt16(ddlFK_iThanhToanID.Text);
                _tblHoaDonEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblHoaDonEO.sEmail = Convert.ToString(txtsHoTen.Text);
                _tblHoaDonEO.sDiaChi = Convert.ToString(txtsHoTen.Text);
                _tblHoaDonEO.sSoDienThoai = Convert.ToString(txtsHoTen.Text);
                _tblHoaDonEO.sGhiChu = Convert.ToString(txtsHoTen.Text);
                _tblHoaDonEO.tNgayDatHang = Convert.ToDateTime(txtsHoTen.Text);
                _tblHoaDonEO.tNgayGiaoHang = Convert.ToDateTime(txtsHoTen.Text);
                try { _tblHoaDonEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblHoaDonEO.iTrangThai = 0; }
                return _tblHoaDonEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_iTaiKhoanID_Giao.DataSource = tblHoaDonDAO.HoaDon_SelectList();
            ddlFK_iTaiKhoanID_Giao.DataTextField = "FK_iTaiKhoanID_Nhan";
            ddlFK_iTaiKhoanID_Giao.DataValueField = "PK_lHoaDonID";
            ddlFK_iTaiKhoanID_Giao.DataBind();

            ddlFK_iTaiKhoanID_Nhan.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddlFK_iTaiKhoanID_Nhan.DataTextField = "sTenSanPham";
            ddlFK_iTaiKhoanID_Nhan.DataValueField = "PK_sSanPhamID";
            ddlFK_iTaiKhoanID_Nhan.DataBind();

            ddlFK_iThanhToanID.DataSource = tblHoaDonDAO.HoaDon_SelectList();
            ddlFK_iThanhToanID.DataTextField = "FK_iTaiKhoanID_Nhan";
            ddlFK_iThanhToanID.DataValueField = "PK_lHoaDonID";
            ddlFK_iThanhToanID.DataBind();

            ddliTrangThai.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddliTrangThai.DataTextField = "sTenSanPham";
            ddliTrangThai.DataValueField = "PK_sSanPhamID";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_lHoaDonID.Text = "";
            lblFK_iTaiKhoanID_Giao.Text = "";
            lblFK_iTaiKhoanID_Nhan.Text = "";
            lblFK_iThanhToanID.Text = "";
            lblsHoTen.Text = "";
            lblsEmail.Text = "";
            lblsDiaChi.Text = "";
            lblsSoDienThoai.Text = "";
            lblsGhiChu.Text = "";
            lbltNgayDatHang.Text = "";
            lbltNgayGiaoHang.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblHoaDonDAO.HoaDon_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Them_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblHoaDonDAO.HoaDon_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblHoaDonDAO.HoaDon_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            BindDataDetail(_tblHoaDonEO);
        }
        #endregion
    }
}