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
                try { _tblTaiKhoanEO.PK_iTaiKhoanID = Convert.ToInt16(txtPK_iTaiKhoanID.Text); }
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

        private void ClearMessages()
        {
            lblMsg.Text = "";
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
            try
            {
                if (tblTaiKhoanDAO.TaiKhoan_Insert(getObject()) == true)
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
                if (tblTaiKhoanDAO.TaiKhoan_Update(getObject()) == true)
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
                if (tblTaiKhoanDAO.TaiKhoan_Delete(getObject()) == true)
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
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            BindDataDetail(_tblTaiKhoanEO);
        }
        #endregion;
    }
}