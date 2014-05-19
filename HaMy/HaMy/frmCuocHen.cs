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
using HaMy.DataAccessObject;

namespace HaMy
{
    public partial class frmCuocHen : Form
    {
        public frmCuocHen()
        {
            InitializeComponent();
        }

        private void frmCuocHen_Load(object sender, EventArgs e)
        {
            loadDataToDropDownList();
        }

        public void BindDataDetail(tblCuocHenEO _tblCuocHenEO)
        {
            txtPK_lCuocHen.Text = Convert.ToString(_tblCuocHenEO.PK_lCuocHen);
            try { cboFK_iNguoiDung.SelectedValue = Convert.ToString(_tblCuocHenEO.FK_iNguoiDung); }
            catch { cboFK_iNguoiDung.SelectedIndex = 0; }
            try { cboFK_iDoiTac.SelectedValue = Convert.ToString(_tblCuocHenEO.FK_iDoiTac); }
            catch { cboFK_iDoiTac.SelectedIndex = 0; }
            txtsNoiDung.Text = Convert.ToString(_tblCuocHenEO.sNoiDung);
            txtsDiaDiem.Text = Convert.ToString(_tblCuocHenEO.sDiaDiem);
            txttNgayGioBatDau.Text = Convert.ToString(_tblCuocHenEO.tNgayGioBatDau);
            txttNgayGioKetThuc.Text = Convert.ToString(_tblCuocHenEO.tNgayGioKetThuc);
            try { cboiTrangThai.SelectedValue = Convert.ToString(_tblCuocHenEO.iTrangThai); }
            catch { cboiTrangThai.SelectedIndex = 0; }

        }

        public tblCuocHenEO getObject()
        {
            try
            {
                tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                _tblCuocHenEO.PK_lCuocHen = Convert.ToInt64(txtPK_lCuocHen.Text);
                try { _tblCuocHenEO.FK_iNguoiDung = Convert.ToInt16(cboFK_iNguoiDung.SelectedValue); }
                catch { cboFK_iNguoiDung.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblCuocHenEO.FK_iNguoiDung = 0; }
                try { _tblCuocHenEO.FK_iDoiTac = Convert.ToInt32(cboFK_iDoiTac.SelectedValue); }
                catch { cboFK_iDoiTac.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblCuocHenEO.FK_iDoiTac = 0; }
                _tblCuocHenEO.sNoiDung = Convert.ToString(txtsNoiDung.Text);
                _tblCuocHenEO.sDiaDiem = Convert.ToString(txtsDiaDiem.Text);
                _tblCuocHenEO.tNgayGioBatDau = Convert.ToDateTime(txttNgayGioBatDau.Text);
                _tblCuocHenEO.tNgayGioKetThuc = Convert.ToDateTime(txttNgayGioKetThuc.Text);
                try { _tblCuocHenEO.iTrangThai = Convert.ToInt16(cboiTrangThai.SelectedValue); }
                catch { cboiTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblCuocHenEO.iTrangThai = 0; }
                return _tblCuocHenEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            cboFK_iNguoiDung.DataSource = tblNguoiDungDAO.NguoiDung_SelectList().Tables[0];
            cboFK_iNguoiDung.DisplayMember = "sHoTen";
            cboFK_iNguoiDung.ValueMember = "PK_iNguoiDung";

            cboFK_iDoiTac.DataSource = tblDoiTacDAO.DoiTac_SelectList().Tables[0];
            cboFK_iDoiTac.DisplayMember = "sHoTen";
            cboFK_iDoiTac.ValueMember = "PK_iDoiTac";

            try
            {
                DataTable dt = Commons.Convert_SortList_To_DataTable(GetListConstants.CuocHen_iTrangThai_GLC());
                cboiTrangThai.DataSource = dt;
                cboiTrangThai.DisplayMember = "Value";
                cboiTrangThai.ValueMember = "Key";
            }
            catch { }
        }

        public void ClearMessages()
        {
            lblPK_lCuocHen.Text = "";
            lblFK_iNguoiDung.Text = "";
            lblFK_iDoiTac.Text = "";
            lblsNoiDung.Text = "";
            lblsDiaDiem.Text = "";
            lbltNgayGioBatDau.Text = "";
            lbltNgayGioKetThuc.Text = "";
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
