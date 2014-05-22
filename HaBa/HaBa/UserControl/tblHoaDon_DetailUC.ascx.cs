using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries.Constants;
using System.Text.RegularExpressions;
using System.Data;

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
        public string sWarning
        {
            get { return (string)ViewState["sWarning"]; }
            set { ViewState["sWarning"] = value; }
        }
        public int iState 
        {
            get { return (int)ViewState["iState"]; }
            set { ViewState["iState"] = value; }
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
            if (_tblHoaDonEO.tNgayDatHang == DateTime.MinValue) { txttNgayDatHang.Text = DateTime.Now.ToString(); } else { txttNgayDatHang.Text = Convert.ToString(_tblHoaDonEO.tNgayDatHang); }
            if (_tblHoaDonEO.tNgayGiaoHang == DateTime.MinValue) { txttNgayGiaoHang.Text = DateTime.Now.ToString(); } else { txttNgayGiaoHang.Text = Convert.ToString(_tblHoaDonEO.tNgayGiaoHang); }

            //txttNgayDatHang.Text = Convert.ToString(_tblHoaDonEO.tNgayDatHang);
            //txttNgayGiaoHang.Text = Convert.ToString(_tblHoaDonEO.tNgayGiaoHang);
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblHoaDonEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblHoaDonEO getObject()
        {
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            try
            {
                _tblHoaDonEO.PK_lHoaDonID = Convert.ToInt64(txtPK_lHoaDonID.Text);
                try { _tblHoaDonEO.FK_iTaiKhoanID_Giao = Convert.ToInt32(ddlFK_iTaiKhoanID_Giao.SelectedValue); }
                catch { lblFK_iTaiKhoanID_Giao.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblHoaDonEO.FK_iTaiKhoanID_Giao = 0; }
                try { _tblHoaDonEO.FK_iTaiKhoanID_Nhan = Convert.ToInt32(ddlFK_iTaiKhoanID_Nhan.SelectedValue); }
                catch { lblFK_iTaiKhoanID_Nhan.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblHoaDonEO.FK_iTaiKhoanID_Nhan = 0; }
                _tblHoaDonEO.FK_iThanhToanID = Convert.ToInt16(ddlFK_iThanhToanID.Text);
                _tblHoaDonEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblHoaDonEO.sEmail = Convert.ToString(txtsEmail.Text);
                _tblHoaDonEO.sDiaChi = Convert.ToString(txtsDiaChi.Text);
                _tblHoaDonEO.sSoDienThoai = Convert.ToString(txtsSoDienThoai.Text);
                _tblHoaDonEO.sGhiChu = Convert.ToString(txtsGhiChu.Text);
                _tblHoaDonEO.tNgayDatHang = Convert.ToDateTime(txttNgayDatHang.Text);
                _tblHoaDonEO.tNgayGiaoHang = Convert.ToDateTime(txttNgayGiaoHang.Text);
                try { _tblHoaDonEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblHoaDonEO.iTrangThai = 0; }
                return _tblHoaDonEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblHoaDonEO;
            }
        }

        public void loadDataToDropDownList()
        {
            try
            {
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.iQuyenHan = TaiKhoan_iQuyenHan_C.Nhan_Vien;
                ddlFK_iTaiKhoanID_Giao.DataSource = tblTaiKhoanDAO.TaiKhoan_SelectListByiQuyenHan(_tblTaiKhoanEO);
                ddlFK_iTaiKhoanID_Giao.DataTextField = "sHoTen";
                ddlFK_iTaiKhoanID_Giao.DataValueField = "PK_iTaiKhoanID";
                ddlFK_iTaiKhoanID_Giao.DataBind();

                _tblTaiKhoanEO.iQuyenHan = TaiKhoan_iQuyenHan_C.Khach_Hang;
                ddlFK_iTaiKhoanID_Nhan.DataSource = tblTaiKhoanDAO.TaiKhoan_SelectListByiQuyenHan(_tblTaiKhoanEO);
                ddlFK_iTaiKhoanID_Nhan.DataTextField = "sHoTen";
                ddlFK_iTaiKhoanID_Nhan.DataValueField = "PK_iTaiKhoanID";
                ddlFK_iTaiKhoanID_Nhan.DataBind();

                ddlFK_iThanhToanID.DataSource = tblThanhToanDAO.ThanhToan_SelectList();
                ddlFK_iThanhToanID.DataTextField = "sTenThanhToan";
                ddlFK_iThanhToanID.DataValueField = "PK_iThanhToanID";
                ddlFK_iThanhToanID.DataBind();

                ddliTrangThai.DataSource = GetListConstants.HoaDon_iTrangThai_GLC();
                ddliTrangThai.DataTextField = "Value";
                ddliTrangThai.DataValueField = "Key";
                ddliTrangThai.DataBind();
            }
            catch(Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        public string CheckQuantity()
        {
            sWarning = "Sản phẩm không đủ!     ";
            iState = 0;
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            _tblHoaDonEO = getObject();
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblChiTietHoaDonEO.FK_lHoaDonID = _tblHoaDonEO.PK_lHoaDonID;
            DataSet dsChiTietHoaDon = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectListByFK_lHoaDonID(_tblChiTietHoaDonEO);
            foreach (DataRow dr in dsChiTietHoaDon.Tables[0].Rows)
            {
                _tblSanPhamEO = tblSanPhamDAO.SanPham_SelectItemPK_sSanPhamID(dr["FK_sSanPhamID"].ToString());
                if (Convert.ToInt16(dr["iSoLuong"]) > _tblSanPhamEO.iSoLuong)
                {
                    sWarning = sWarning + _tblSanPhamEO.sTenSanPham + "thiếu " + (Convert.ToInt16(dr["iSoLuong"]) - _tblSanPhamEO.iSoLuong) + "//   ";
                    iState = 9;
                }
            }
            return sWarning;
        }



        public string UpdateQuantity()
        {
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            _tblHoaDonEO = getObject();
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblChiTietHoaDonEO.FK_lHoaDonID = _tblHoaDonEO.PK_lHoaDonID;
            DataSet dsChiTietHoaDon = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectListByFK_lHoaDonID(_tblChiTietHoaDonEO);
            foreach (DataRow dr in dsChiTietHoaDon.Tables[0].Rows)
            {
                _tblSanPhamEO = tblSanPhamDAO.SanPham_SelectItemPK_sSanPhamID(dr["FK_sSanPhamID"].ToString());
                Int16 sl = _tblSanPhamEO.iSoLuong;
                _tblSanPhamEO.iSoLuong = (Int16)(sl - Convert.ToInt16(dr["FK_sSanPhamID"]));
                tblSanPhamDAO.SanPham_Update_iSoLuong(_tblSanPhamEO);
            }
            return sWarning;
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtsHoTen.Text) == true)
            {
                lblsHoTen.Text = Messages.Khong_Duoc_De_Trong;
                txtsHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsEmail.Text) == true)
            {
                lblsEmail.Text = Messages.Khong_Duoc_De_Trong;
                txtsEmail.Focus();
                return false;
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(txtsEmail.Text);
                if (match.Success == false)
                {
                    lblsEmail.Text = Messages.Khong_Dung_Dinh_Dang_Email;
                    txtsEmail.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsDiaChi.Text) == true)
            {
                lblsDiaChi.Text = Messages.Khong_Duoc_De_Trong;
                txtsDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsSoDienThoai.Text) == true)
            {
                lblsSoDienThoai.Text = Messages.Khong_Duoc_De_Trong;
                txtsSoDienThoai.Focus();
                return false;
            }
            else
            {
                string sdt;
                sdt = txtsSoDienThoai.Text.Trim().Replace(" ", "");
                try { Convert.ToInt64(sdt); }
                catch
                {
                    lblsSoDienThoai.Text = Messages.Khong_Dung_Dinh_Dang_So_Dien_Thoai;
                    txtsSoDienThoai.Focus();
                    return false;
                }
                if (sdt.Length < 10)
                {
                    lblsSoDienThoai.Text = Messages.Khong_Dung_Dinh_Dang_So_Dien_Thoai_Do_Dai;
                    txtsSoDienThoai.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsGhiChu.Text) == true)
            {
                lblsGhiChu.Text = Messages.Khong_Duoc_De_Trong;
                txtsGhiChu.Focus();
                return false;
            }
            return true;
        }

        private void ClearMessages()
        {
            //lblMsg.Text = "";
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
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    if (tblHoaDonDAO.HoaDon_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                        BindDataDetail(_tblHoaDonEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
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
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    switch (getObject().iTrangThai)
                    {
                        case HoaDon_iTrangThai_C.Chua_Giao_Hang:
                            if (iState == 9)
                            {
                                lblMsg.Text = CheckQuantity();
                            }
                            else
                            {
                                if (tblHoaDonDAO.HoaDon_Update(getObject()) == true)
                                {
                                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                                    ClearMessages();
                                }
                                else
                                {
                                    lblMsg.Text = Messages.Sua_That_Bai;
                                }
                            }
                            break;
                        case HoaDon_iTrangThai_C.Da_Giao_Hang:
                            if (iState == 9)
                            {
                                lblMsg.Text = CheckQuantity();
                            }
                            else
                            {
                                if (tblHoaDonDAO.HoaDon_Update(getObject()) == true)
                                {
                                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                                    UpdateQuantity();
                                    ClearMessages();
                                }
                                else
                                {
                                    lblMsg.Text = Messages.Sua_That_Bai;
                                }
                            }
                            break;
                        default:
                            if (tblHoaDonDAO.HoaDon_Update(getObject()) == true)
                            {
                                lblMsg.Text = Messages.Sua_Thanh_Cong;
                                ClearMessages();
                            }
                            else
                            {
                                lblMsg.Text = Messages.Sua_That_Bai;
                            }
                            break;
                    }
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
            lblMsg.Text = "";
            try
            {
                if (tblHoaDonDAO.HoaDon_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                    BindDataDetail(_tblHoaDonEO);
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
            lblMsg.Text = "";
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            BindDataDetail(_tblHoaDonEO);
        }
        #endregion
    }
}