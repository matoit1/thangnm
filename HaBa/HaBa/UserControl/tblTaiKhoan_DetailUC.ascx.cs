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
            try { ddliTrangThai.SelectedValue = _tblTaiKhoanEO.iTrangThai.ToString(); }
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
                try { _tblTaiKhoanEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _tblTaiKhoanEO;
            }
            catch (Exception)
            {
                throw;
            }
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