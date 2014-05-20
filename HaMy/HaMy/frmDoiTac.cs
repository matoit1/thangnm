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
    public partial class frmDoiTac : Form
    {
        #region "Form"
        public frmDoiTac()
        {
            InitializeComponent();
        }
        
        private void frmDoiTac_Load(object sender, EventArgs e)
        {
            txtPK_iDoiTac.Enabled = false;
            loadDataToDropDownList();
            BindDataGridView();
        }
        #endregion

        #region LoadData
        public void BindDataGridView()
        {
            grvDoiTac.Visible = false;
            DataSet dsDoiTac = new DataSet();
            try
            {
                dsDoiTac = tblDoiTacDAO.DoiTac_SelectList();
                if (dsDoiTac.Tables[0].Rows.Count > 0)
                {
                    grvDoiTac.Visible = true;
                    grvDoiTac.AutoGenerateColumns = false;
                    grvDoiTac.DataSource = dsDoiTac.Tables[0];
                    //grvDoiTac.DataMember = dsDoiTac.Tables[0].ToString();
                }
            }
            catch
            {
            }
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
            dpktNgaySinh.Text = (_tblDoiTacEO.tNgaySinh == DateTime.MinValue) ? DateTime.Now.ToString() : Convert.ToString(_tblDoiTacEO.tNgaySinh);
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
                _tblDoiTacEO.PK_iDoiTac = (String.IsNullOrEmpty(txtPK_iDoiTac.Text)) ? 0 : Convert.ToInt32(txtPK_iDoiTac.Text);
                _tblDoiTacEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblDoiTacEO.sDiaChi = Convert.ToString(txtsDiaChi.Text);
                _tblDoiTacEO.sEmail = Convert.ToString(txtsEmail.Text);
                _tblDoiTacEO.sSoDienThoai = Convert.ToString(txtsSoDienThoai.Text);
                _tblDoiTacEO.tNgaySinh = Convert.ToDateTime(dpktNgaySinh.Text);
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
            try
            {
                try
                {
                    cboFK_iNhom.DataSource = tblNhomDAO.Nhom_SelectList().Tables[0];
                    cboFK_iNhom.DisplayMember = "sTenNhom";
                    cboFK_iNhom.ValueMember = "PK_iNhom";
                }
                catch (Exception) { }

                try
                {
                    cboFK_iMoiQuanHe.DataSource = tblMoiQuanHeDAO.MoiQuanHe_SelectList().Tables[0];
                    cboFK_iMoiQuanHe.DisplayMember = "sTen";
                    cboFK_iMoiQuanHe.ValueMember = "PK_iMoiQuanHe";
                }
                catch (Exception) { }
                try
                {
                    DataTable dt = Commons.Convert_SortList_To_DataTable(GetListConstants.TaiKhoan_iTrangThai_GLC());
                    cboiTrangThai.DataSource = dt;
                    cboiTrangThai.DisplayMember = "Value";
                    cboiTrangThai.ValueMember = "Key";
                }
                catch { }
            }
            catch (Exception) { }
        }

        public void ClearMessages()
        {
            lblMsg.Text = "";
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
        #endregion

        #region "Event DataGridView"
        private void grvDoiTac_SelectionChanged(object sender, EventArgs e)
        {
            tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
            foreach (DataGridViewRow row in grvDoiTac.SelectedRows)
            {
                _tblDoiTacEO.FK_iNhom = Convert.ToInt32(row.Cells[0].Value);
                _tblDoiTacEO.PK_iDoiTac = Convert.ToInt32(row.Cells[1].Value);
                _tblDoiTacEO.sHoTen = row.Cells[2].Value.ToString();
                _tblDoiTacEO.sDiaChi = row.Cells[3].Value.ToString();
                _tblDoiTacEO.sEmail = row.Cells[4].Value.ToString();
                _tblDoiTacEO.sSoDienThoai = row.Cells[5].Value.ToString();
                _tblDoiTacEO.tNgaySinh = Convert.ToDateTime(row.Cells[6].Value);
                _tblDoiTacEO.bGioiTinh = Convert.ToBoolean(row.Cells[7].Value);
                _tblDoiTacEO.sNgheNghiep = row.Cells[8].Value.ToString();
                _tblDoiTacEO.FK_iMoiQuanHe = Convert.ToInt32(row.Cells[9].Value);
                _tblDoiTacEO.sGhiChu = row.Cells[10].Value.ToString();
                _tblDoiTacEO.iTrangThai = Convert.ToInt16(row.Cells[11].Value);
            }
            if (_tblDoiTacEO.PK_iDoiTac != 0)
            {
                BindDataDetail(_tblDoiTacEO);
            }
        }
        #endregion

        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dsDoiTac = new DataSet();
            dsDoiTac = tblDoiTacDAO.DoiTac_Search(getObject());
            grvDoiTac.Visible = true;
            grvDoiTac.AutoGenerateColumns = false;
            grvDoiTac.DataSource = dsDoiTac.Tables[0];
            //grvDoiTac.DataMember = dsDoiTac.Tables[0].ToString();
            //grvDoiTac.DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                ClearMessages();
                lblMsg.Text = "";
                try
                {
                    if (tblDoiTacDAO.DoiTac_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
                    BindDataGridView();
                    tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
                    BindDataDetail(_tblDoiTacEO);
                    ClearMessages();
                }
                catch (Exception ex)
                {
                    lblMsg.Text = Messages.Loi + ex.Message;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblDoiTacDAO.DoiTac_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
                BindDataGridView();
                tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
                BindDataDetail(_tblDoiTacEO);
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
                if (tblDoiTacDAO.DoiTac_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
                BindDataGridView();
                tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
                BindDataDetail(_tblDoiTacEO);
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
            tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
            BindDataDetail(_tblDoiTacEO);
        }
        #endregion
    }
}
