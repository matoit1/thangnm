using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaMy.EntityObject;
using HaMy.SharedLibraries;
using HaBa.SharedLibraries;

namespace HaMy
{
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        public void BindDataDetail(tblNguoiDungEO _tblNguoiDungEO)
        {
            txtPK_iNguoiDung.Text = Convert.ToString(_tblNguoiDungEO.PK_iNguoiDung);
            txtsHoTen.Text = Convert.ToString(_tblNguoiDungEO.sHoTen);
            txtsDiaChi.Text = Convert.ToString(_tblNguoiDungEO.sDiaChi);
            txtsEmail.Text = Convert.ToString(_tblNguoiDungEO.sEmail);
            txtsSoDienThoai.Text = Convert.ToString(_tblNguoiDungEO.sSoDienThoai);
            txttNgaySinh.Text = Convert.ToString(_tblNguoiDungEO.tNgaySinh);
            rbtnbGioiTinh.Checked = Convert.ToBoolean(_tblNguoiDungEO.bGioiTinh);
            if(rbtnbGioiTinh.Checked ==true){
                rbtnbGioiTinh2.Checked=false;
            }
            else{
                rbtnbGioiTinh2.Checked=true;
            }
            txtsNgheNghiep.Text = Convert.ToString(_tblNguoiDungEO.sNgheNghiep);
            try { cboiTrangThai.SelectedValue = Convert.ToString(_tblNguoiDungEO.iTrangThai); }
            catch { cboiTrangThai.SelectedIndex = 0; }

        }

        public tblNguoiDungEO getObject()
        {
            try
            {
                tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
                _tblNguoiDungEO.PK_iNguoiDung = Convert.ToInt32(txtPK_iNguoiDung.Text);
                _tblNguoiDungEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblNguoiDungEO.sDiaChi = Convert.ToString(txtsDiaChi.Text);
                _tblNguoiDungEO.sEmail = Convert.ToString(txtsEmail.Text);
                _tblNguoiDungEO.sSoDienThoai = Convert.ToString(txtsSoDienThoai.Text);
                _tblNguoiDungEO.tNgaySinh = Convert.ToDateTime(txttNgaySinh.Text);
                _tblNguoiDungEO.bGioiTinh = Convert.ToBoolean(rbtnbGioiTinh.Checked);
                _tblNguoiDungEO.sNgheNghiep = Convert.ToString(txtsNgheNghiep.Text);
                try { _tblNguoiDungEO.iTrangThai = Convert.ToInt16(cboiTrangThai.SelectedValue); }
                catch { cboiTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblNguoiDungEO.iTrangThai = 0; }
                return _tblNguoiDungEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {

            cboiTrangThai.DataSource = GetListConstants.TaiKhoan_iTrangThai_GLC();
            cboiTrangThai.DisplayMember  = "Value";
            cboiTrangThai.ValueMember = "Key";
        }

        public void ClearMessages()
        {
            lblPK_iNguoiDung.Text = "";
            lblsHoTen.Text = "";
            lblsDiaChi.Text = "";
            lblsEmail.Text = "";
            lblsSoDienThoai.Text = "";
            lbltNgaySinh.Text = "";
            lblbGioiTinh.Text = "";
            lblsNgheNghiep.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
