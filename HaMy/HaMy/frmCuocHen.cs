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
using System.Threading;

namespace HaMy
{
    public partial class frmCuocHen : Form
    {
        #region "Form"
        public frmCuocHen()
        {
            InitializeComponent();
        }

        private void frmCuocHen_Load(object sender, EventArgs e)
        {
            ClearMessages();
            txtPK_lCuocHen.Enabled = false;
            loadDataToDropDownList();
            BindDataGridView();
        }
        #endregion

        #region LoadData
        public void BindDataGridView()
        {
            grvCuocHen.Visible = false;
            DataSet dsCuocHen = new DataSet();
            try
            {
                dsCuocHen = tblCuocHenDAO.CuocHen_SelectList();
                if (dsCuocHen.Tables[0].Rows.Count > 0)
                {
                    grvCuocHen.Visible = true;
                    grvCuocHen.AutoGenerateColumns = false;
                    grvCuocHen.DataSource = dsCuocHen.Tables[0];
                    //grvDoiTac.DataMember = dsDoiTac.Tables[0].ToString();
                }
            }
            catch
            {
            }
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
            dpktNgayGioBatDau.Text = (_tblCuocHenEO.tNgayGioBatDau == DateTime.MinValue) ? DateTime.Now.ToString() : Convert.ToString(_tblCuocHenEO.tNgayGioBatDau);
            dpktNgayGioKetThuc.Text = (_tblCuocHenEO.tNgayGioKetThuc == DateTime.MinValue) ? DateTime.Now.ToString() : Convert.ToString(_tblCuocHenEO.tNgayGioKetThuc);
            try { cboiTrangThai.SelectedValue = Convert.ToString(_tblCuocHenEO.iTrangThai); }
            catch { cboiTrangThai.SelectedIndex = 0; }
        }

        public tblCuocHenEO getObject()
        {
            try
            {
                tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                _tblCuocHenEO.PK_lCuocHen = (String.IsNullOrEmpty(txtPK_lCuocHen.Text)) ? 0 : Convert.ToInt64(txtPK_lCuocHen.Text);
                try { _tblCuocHenEO.FK_iNguoiDung = Convert.ToInt32(cboFK_iNguoiDung.SelectedValue); }
                catch { cboFK_iNguoiDung.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblCuocHenEO.FK_iNguoiDung = 0; }
                try { _tblCuocHenEO.FK_iDoiTac = Convert.ToInt32(cboFK_iDoiTac.SelectedValue); }
                catch { cboFK_iDoiTac.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblCuocHenEO.FK_iDoiTac = 0; }
                _tblCuocHenEO.sNoiDung = Convert.ToString(txtsNoiDung.Text);
                _tblCuocHenEO.sDiaDiem = Convert.ToString(txtsDiaDiem.Text);
                _tblCuocHenEO.tNgayGioBatDau = Convert.ToDateTime(dpktNgayGioBatDau.Text);
                _tblCuocHenEO.tNgayGioKetThuc = Convert.ToDateTime(dpktNgayGioKetThuc.Text);
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
            //lblMsg.Text = "";
            lblPK_lCuocHen.Text = "";
            lblFK_iNguoiDung.Text = "";
            lblFK_iDoiTac.Text = "";
            lblsNoiDung.Text = "";
            lblsDiaDiem.Text = "";
            lbltNgayGioBatDau.Text = "";
            lbltNgayGioKetThuc.Text = "";
            lbliTrangThai.Text = "";
        }
        #endregion



        #region "Event DataGridView"
        private void grvCuocHen_SelectionChanged(object sender, EventArgs e)
        {
            tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
            foreach (DataGridViewRow row in grvCuocHen.SelectedRows)
            {
                _tblCuocHenEO.PK_lCuocHen = Convert.ToInt64(row.Cells[0].Value);
                _tblCuocHenEO.FK_iNguoiDung = Convert.ToInt32(row.Cells[1].Value);
                _tblCuocHenEO.FK_iDoiTac = Convert.ToInt32(row.Cells[2].Value);
                _tblCuocHenEO.sNoiDung = row.Cells[3].Value.ToString();
                _tblCuocHenEO.sDiaDiem = row.Cells[4].Value.ToString();
                _tblCuocHenEO.tNgayGioBatDau = Convert.ToDateTime(row.Cells[5].Value);
                _tblCuocHenEO.tNgayGioKetThuc = Convert.ToDateTime(row.Cells[6].Value);
                _tblCuocHenEO.iTrangThai = Convert.ToInt16(row.Cells[7].Value);
            }
            //if (_tblCuocHenEO.PK_lCuocHen != 0)
            //{
                BindDataDetail(_tblCuocHenEO);
            //}
        }
        #endregion


        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dsCuocHen = new DataSet();
            dsCuocHen = tblCuocHenDAO.CuocHen_Search(getObject());
            grvCuocHen.Visible = true;
            grvCuocHen.AutoGenerateColumns = false;
            grvCuocHen.DataSource = dsCuocHen.Tables[0];
            //grvCuocHen.DataMember = dsCuocHen.Tables[0].ToString();
            //grvCuocHen.DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                ClearMessages();
                lblMsg.Text = "";
                try
                {
                    if (tblCuocHenDAO.CuocHen_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
                    BindDataGridView();
                    tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                    BindDataDetail(_tblCuocHenEO);
                    ClearMessages();
                }
                catch (Exception ex)
                {
                    lblMsg.Text = Messages.Loi + ex.Message;
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblCuocHenDAO.CuocHen_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
                BindDataGridView();
                tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                BindDataDetail(_tblCuocHenEO);
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblCuocHenDAO.CuocHen_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
                BindDataGridView();
                tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                BindDataDetail(_tblCuocHenEO);
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            BindDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
            BindDataDetail(_tblCuocHenEO);
        }
        #endregion


    }
}
