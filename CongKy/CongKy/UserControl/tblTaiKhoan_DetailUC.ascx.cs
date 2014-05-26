using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.SharedLibraries;
using CongKy.DataAccessObject;
using System.Text.RegularExpressions;

namespace CongKy.UserControl
{
    public partial class tblTaiKhoan_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            txtPK_iTaiKhoanID.Text = Convert.ToString(_tblTaiKhoanEO.PK_iTaiKhoanID);
            txtsTenDangNhap.Text = Convert.ToString(_tblTaiKhoanEO.sTenDangNhap);
            txtsMatKhau.Text = Convert.ToString(_tblTaiKhoanEO.sMatKhau);
            txtsHoTen.Text = Convert.ToString(_tblTaiKhoanEO.sHoTen);
            txtsEmail.Text = Convert.ToString(_tblTaiKhoanEO.sEmail);
            txtsDiaChi.Text = Convert.ToString(_tblTaiKhoanEO.sDiaChi);
            txtsSoDienThoai.Text = Convert.ToString(_tblTaiKhoanEO.sSoDienThoai);
            if (String.IsNullOrEmpty(_tblTaiKhoanEO.sLinkAvatar) == true) { txtsLinkAvatar.Text = "~/Images/Avatar/Default.jpg"; } else { txtsLinkAvatar.Text = Convert.ToString(_tblTaiKhoanEO.sLinkAvatar); }
            if (_tblTaiKhoanEO.tNgaySinh == DateTime.MinValue) { txttNgaySinh.Text = DateTime.Now.ToString(); } else { txttNgaySinh.Text = Convert.ToString(_tblTaiKhoanEO.tNgaySinh); }
            if (_tblTaiKhoanEO.tNgayDangKy == DateTime.MinValue) { txttNgayDangKy.Text = DateTime.Now.ToString(); } else { txttNgayDangKy.Text = Convert.ToString(_tblTaiKhoanEO.tNgayDangKy); }
            //txtsLinkAvatar.Text = Convert.ToString(_tblTaiKhoanEO.sLinkAvatar);
            //txttNgaySinh.Text = Convert.ToString(_tblTaiKhoanEO.tNgaySinh);
            //txttNgayDangKy.Text = Convert.ToString(_tblTaiKhoanEO.tNgayDangKy);
            try { ddliQuyenHan.SelectedValue = Convert.ToString(_tblTaiKhoanEO.iQuyenHan); }
            catch { ddliQuyenHan.SelectedIndex = 0; }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblTaiKhoanEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblTaiKhoanEO getObject()
        {
            try
            {
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                try { _tblTaiKhoanEO.PK_iTaiKhoanID = Convert.ToInt32(txtPK_iTaiKhoanID.Text); }
                catch { lblPK_iTaiKhoanID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblTaiKhoanEO.PK_iTaiKhoanID = 0; }
                _tblTaiKhoanEO.sTenDangNhap = Convert.ToString(txtsTenDangNhap.Text);
                _tblTaiKhoanEO.sMatKhau = Security.EnCrypt(Convert.ToString(txtsMatKhau.Text));
                _tblTaiKhoanEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblTaiKhoanEO.sEmail = Convert.ToString(txtsEmail.Text);
                _tblTaiKhoanEO.sDiaChi = Convert.ToString(txtsDiaChi.Text);
                _tblTaiKhoanEO.sSoDienThoai = Convert.ToString(txtsSoDienThoai.Text);
                _tblTaiKhoanEO.sLinkAvatar = Convert.ToString(txtsLinkAvatar.Text);
                _tblTaiKhoanEO.tNgaySinh = Convert.ToDateTime(txttNgaySinh.Text);
                _tblTaiKhoanEO.tNgayDangKy = Convert.ToDateTime(txttNgayDangKy.Text);
                try { _tblTaiKhoanEO.iQuyenHan = Convert.ToInt16(ddliQuyenHan.SelectedValue); }
                catch { lbliQuyenHan.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _tblTaiKhoanEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _tblTaiKhoanEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool CheckValidation()
        {
            try
            {
                if (String.IsNullOrEmpty(txtsMatKhau.Text) == true)
                {
                    return false;
                }
                return true;
            }
            catch { return false; }
        }

        public void loadDataToDropDownList()
        {
            ddliQuyenHan.DataSource = GetListConstants.TaiKhoan_iQuyenHan_GLC();
            ddliQuyenHan.DataTextField = "Value";
            ddliQuyenHan.DataValueField = "Key";
            ddliQuyenHan.DataBind();

            ddliTrangThai.DataSource = GetListConstants.TaiKhoan_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        public bool CheckInput()
        {
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            if (string.IsNullOrEmpty(txtsTenDangNhap.Text) == true)
            {
                lblsTenDangNhap.Text = Messages.Khong_Duoc_De_Trong;
                txtsTenDangNhap.Focus();
                return false;
            }
            else
            {
                _tblTaiKhoanEO.sTenDangNhap = txtsTenDangNhap.Text;
                if (tblTaiKhoanDAO.TaiKhoan_CheckExists_sTenDangNhap(_tblTaiKhoanEO) == true)
                {
                    lblsTenDangNhap.Text = Messages.Ten_Tai_Khoan_Da_Duoc_Su_Dung;
                    txtsTenDangNhap.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsMatKhau.Text) == true)
            {
                lblsMatKhau.Text = Messages.Khong_Duoc_De_Trong;
                txtsMatKhau.Focus();
                return false;
            }
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
                else
                {
                    _tblTaiKhoanEO.sEmail = txtsEmail.Text;
                    if (tblTaiKhoanDAO.TaiKhoan_CheckExists_sEmail(_tblTaiKhoanEO) == true)
                    {
                        lblsEmail.Text = Messages.Email_Da_Duoc_Su_Dung;
                        txtsEmail.Focus();
                        return false;
                    }
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
            return true;
        }


        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_iTaiKhoanID.Text = "";
            lblsTenDangNhap.Text = "";
            lblsMatKhau.Text = "";
            lblsHoTen.Text = "";
            lblsEmail.Text = "";
            lblsDiaChi.Text = "";
            lblsSoDienThoai.Text = "";
            lblsLinkAvatar.Text = "";
            lbltNgaySinh.Text = "";
            lbltNgayDangKy.Text = "";
            lbliQuyenHan.Text = "";
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
                if (tblTaiKhoanDAO.TaiKhoan_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                    ClearMessages();
                    tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                    BindDataDetail(_tblTaiKhoanEO);
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
                if (tblTaiKhoanDAO.TaiKhoan_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                    ClearMessages();
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
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
                //tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                //_tblHoaDonEO.FK_iTaiKhoanID_Giao = getObject().PK_iTaiKhoanID;
                //_tblHoaDonEO.FK_iTaiKhoanID_Nhan = getObject().PK_iTaiKhoanID;
                //if (tblDangKyDayHocDAO.HoaDon_CheckExists_FK_iTaiKhoanID_Giao_FK_iTaiKhoanID_Nhan(_tblHoaDonEO) == false)
                //{
                    if (tblTaiKhoanDAO.TaiKhoan_Delete(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Xoa_Thanh_Cong;
                        ClearMessages();
                        tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                        BindDataDetail(_tblTaiKhoanEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Xoa_That_Bai;
                    }
            //    }
              //  else
                //{
                  //  lblMsg.Text = Messages.Ma_Tai_Khoan_Da_Dung_Trong_Hoa_Don;
                //}
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
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            BindDataDetail(_tblTaiKhoanEO);
        }
        #endregion;

        public void Permit_Access()
        {
            txtPK_iTaiKhoanID.Visible = false;
            lblPK_iTaiKhoanID.Visible = false;
            lblPK_iTaiKhoanID_Title.Visible = false;

            txtsTenDangNhap.Enabled = false;
            txtsEmail.Enabled = false;
            txttNgayDangKy.Enabled = false;

            ddliQuyenHan.Visible = false;
            lbliQuyenHan.Visible = false;
            lbliQuyenHan_Title.Visible = false;

            ddliTrangThai.Visible = false;
            lbliTrangThai.Visible = false;
            lbliTrangThai_Title.Visible = false;

            btnInsert.Visible = false;
            btnDelete.Visible = false;
            btnReset.Visible = false;
        }
        
    }
}