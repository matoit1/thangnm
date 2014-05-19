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
    public partial class frmDoiTac : Form
    {
        public frmDoiTac()
        {
            InitializeComponent();
        }
        public void BindDataDetail(tblDoiTacEO _tblDoiTacEO)
        {
            try { cboFK_iNhom.SelectedValue = Convert.ToString(_tblDoiTacEO.FK_iNhom); }
            catch { cboFK_iNhom.SelectedIndex = 0; }
            txtPK_iDoiTac.Text = Convert.ToString(_tblDoiTacEO.PK_iDoiTac);
            txtsHoTen.Text = Convert.ToString(_tblDoiTacEO.sHoTen);
            txtsDiaChi.Text = Convert.ToString(_tblDoiTacEO.sDiaChi);
            txtsEmail.Text = Convert.ToString(_tblDoiTacEO.sEmail);
            txtsSoDienThoai.Text = Convert.ToString(_tblDoiTacEO.sSoDienThoai);
            txttNgaySinh.Text = Convert.ToString(_tblDoiTacEO.tNgaySinh);
            rbtnbGioiTinh.Checked = Convert.ToBoolean(_tblDoiTacEO.bGioiTinh);
            if (rbtnbGioiTinh.Checked == true)
            {
                rbtnbGioiTinh2.Checked = false;
            }
            else
            {
                rbtnbGioiTinh2.Checked = true;
            }
            txtsNgheNghiep.Text = Convert.ToString(_tblDoiTacEO.sNgheNghiep);
            try { cboFK_iMoiQuanHe.SelectedValue = Convert.ToString(_tblDoiTacEO.FK_iMoiQuanHe); }
            catch { cboFK_iMoiQuanHe.SelectedIndex = 0; }
            txtsGhiChu.Text = Convert.ToString(_tblDoiTacEO.sGhiChu);
            try { cboiTrangThai.SelectedValue = Convert.ToString(_tblDoiTacEO.iTrangThai); }
            catch { cboiTrangThai.SelectedIndex = 0; }

        }

        public tblDoiTacEO getObject()
        {
            try
            {
                tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
                try { _tblDoiTacEO.FK_iNhom = Convert.ToInt32(cboFK_iNhom.SelectedValue); }
                catch { cboFK_iNhom.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblDoiTacEO.FK_iNhom = 0; }
                _tblDoiTacEO.PK_iDoiTac = Convert.ToInt32(txtPK_iDoiTac.Text);
                _tblDoiTacEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblDoiTacEO.sDiaChi = Convert.ToString(txtsDiaChi.Text);
                _tblDoiTacEO.sEmail = Convert.ToString(txtsEmail.Text);
                _tblDoiTacEO.sSoDienThoai = Convert.ToString(txtsSoDienThoai.Text);
                _tblDoiTacEO.tNgaySinh = Convert.ToDateTime(txttNgaySinh.Text);
                _tblDoiTacEO.bGioiTinh = Convert.ToBoolean(rbtnbGioiTinh.Checked);
                _tblDoiTacEO.sNgheNghiep = Convert.ToString(txtsNgheNghiep.Text);
                try { _tblDoiTacEO.FK_iMoiQuanHe = Convert.ToInt32(cboFK_iMoiQuanHe.SelectedValue); }
                catch { cboFK_iMoiQuanHe.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblDoiTacEO.FK_iMoiQuanHe = 0; }
                _tblDoiTacEO.sGhiChu = Convert.ToString(txtsGhiChu.Text);
                try { _tblDoiTacEO.iTrangThai = Convert.ToInt16(cboiTrangThai.SelectedValue); }
                catch { cboiTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblDoiTacEO.iTrangThai = 0; }
                return _tblDoiTacEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            cboFK_iNhom.DataSource = GetListConstants.SanPham_iTrangThai_GLC();
            cboFK_iNhom.DisplayMember = "Value";
            cboFK_iNhom.ValueMember = "Key";

            cboFK_iMoiQuanHe.DataSource = GetListConstants.SanPham_iTrangThai_GLC();
            cboFK_iMoiQuanHe.DisplayMember = "Value";
            cboFK_iMoiQuanHe.ValueMember = "Key";

            cboiTrangThai.DataSource = GetListConstants.SanPham_iTrangThai_GLC();
            cboiTrangThai.DisplayMember = "Value";
            cboiTrangThai.ValueMember = "Key";
        }

        public void ClearMessages()
        {
            lblFK_iNhom.Text = "";
            lblPK_iDoiTac.Text = "";
            lblsHoTen.Text = "";
            lblsDiaChi.Text = "";
            lblsEmail.Text = "";
            lblsSoDienThoai.Text = "";
            lbltNgaySinh.Text = "";
            lblbGioiTinh.Text = "";
            lblsNgheNghiep.Text = "";
            lblFK_iMoiQuanHe.Text = "";
            lblsGhiChu.Text = "";
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
