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
using System.Text.RegularExpressions;

namespace HaMy
{
    public partial class frmNguoiDung : Form
    {
        #region "Form"
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            ClearMessages();
            txtPK_iNguoiDung.Enabled = false;
            loadDataToDropDownList();
            BindDataGridView();
        }
        #endregion


        #region LoadData
        public void BindDataGridView()
        {
            grvNguoiDung.Visible = false;
            DataSet dsNguoiDung = new DataSet();
            try
            {
                dsNguoiDung = tblNguoiDungDAO.NguoiDung_SelectList();
                if (dsNguoiDung.Tables[0].Rows.Count > 0)
                {
                    grvNguoiDung.Visible = true;
                    grvNguoiDung.AutoGenerateColumns = false;
                    grvNguoiDung.DataSource = dsNguoiDung.Tables[0];
                    //grvNguoiDung.DataMember = dsNguoiDung.Tables[0].ToString();
                }
            }
            catch
            {
            }
        }

        public void BindDataDetail(tblNguoiDungEO _tblNguoiDungEO)
        {
            txtPK_iNguoiDung.Text = Convert.ToString(_tblNguoiDungEO.PK_iNguoiDung);
            txtsHoTen.Text = Convert.ToString(_tblNguoiDungEO.sHoTen);
            txtsDiaChi.Text = Convert.ToString(_tblNguoiDungEO.sDiaChi);
            txtsEmail.Text = Convert.ToString(_tblNguoiDungEO.sEmail);
            txtsSoDienThoai.Text = Convert.ToString(_tblNguoiDungEO.sSoDienThoai);
            dpktNgaySinh.Text = (_tblNguoiDungEO.tNgaySinh == DateTime.MinValue) ? DateTime.Now.ToString() : Convert.ToString(_tblNguoiDungEO.tNgaySinh);
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
                _tblNguoiDungEO.PK_iNguoiDung = (String.IsNullOrEmpty(txtPK_iNguoiDung.Text)) ? 0 : Convert.ToInt32(txtPK_iNguoiDung.Text);
                _tblNguoiDungEO.sHoTen = Convert.ToString(txtsHoTen.Text);
                _tblNguoiDungEO.sDiaChi = Convert.ToString(txtsDiaChi.Text);
                _tblNguoiDungEO.sEmail = Convert.ToString(txtsEmail.Text);
                _tblNguoiDungEO.sSoDienThoai = Convert.ToString(txtsSoDienThoai.Text);
                _tblNguoiDungEO.tNgaySinh = Convert.ToDateTime(dpktNgaySinh.Text);
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
            try
            {
                DataTable dt = Commons.Convert_SortList_To_DataTable(GetListConstants.TaiKhoan_iTrangThai_GLC());
                cboiTrangThai.DataSource = dt;
                cboiTrangThai.DisplayMember = "Value";
                cboiTrangThai.ValueMember = "Key";
            }
            catch { }
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_iNguoiDung.Text) == true)
            {
                lblPK_iNguoiDung.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_iNguoiDung.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsHoTen.Text) == true)
            {
                lblsHoTen.Text = Messages.Khong_Duoc_De_Trong;
                txtsHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsDiaChi.Text) == true)
            {
                lblsDiaChi.Text = Messages.Khong_Duoc_De_Trong;
                txtsDiaChi.Focus();
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
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtsSoDienThoai.Text) == true)
            {
                lblsSoDienThoai.Text = Messages.Khong_Duoc_De_Trong;
                txtsSoDienThoai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsNgheNghiep.Text) == true)
            {
                lblsNgheNghiep.Text = Messages.Khong_Duoc_De_Trong;
                txtsNgheNghiep.Focus();
                return false;
            }
            return true;
        }

        public void ClearMessages()
        {
            lblMsg.Text = "";
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
        #endregion

        #region "Event DataGridView"
        private void grvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
            foreach (DataGridViewRow row in grvNguoiDung.SelectedRows)
            {
                _tblNguoiDungEO.PK_iNguoiDung = Convert.ToInt32(row.Cells[0].Value);
                _tblNguoiDungEO.sHoTen = row.Cells[1].Value.ToString();
                _tblNguoiDungEO.sDiaChi = row.Cells[2].Value.ToString();
                _tblNguoiDungEO.sEmail = row.Cells[3].Value.ToString();
                _tblNguoiDungEO.sSoDienThoai = row.Cells[4].Value.ToString();
                _tblNguoiDungEO.tNgaySinh = Convert.ToDateTime(row.Cells[5].Value);
                _tblNguoiDungEO.bGioiTinh = Convert.ToBoolean(row.Cells[6].Value);
                _tblNguoiDungEO.sNgheNghiep = row.Cells[7].Value.ToString();
                _tblNguoiDungEO.iTrangThai = Convert.ToInt16(row.Cells[8].Value);
            }
            //if (_tblNguoiDungEO.PK_iNguoiDung != 0)
            //{
                BindDataDetail(_tblNguoiDungEO);
            //}
        }
        #endregion

        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dsNguoiDung = new DataSet();
            dsNguoiDung = tblNguoiDungDAO.NguoiDung_Search(getObject());
            grvNguoiDung.Visible = true;
            grvNguoiDung.AutoGenerateColumns = false;
            grvNguoiDung.DataSource = dsNguoiDung.Tables[0];
            //grvNguoiDung.DataMember = dsNguoiDung.Tables[0].ToString();
            //grvNguoiDung.DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                ClearMessages();
                lblMsg.Text = "";
                try
                {
                    if (CheckInput() == true)
                    {
                        if (tblNguoiDungDAO.NguoiDung_Insert(getObject()) == true)
                        {
                            lblMsg.Text = Messages.Them_Thanh_Cong;
                        }
                        else
                        {
                            lblMsg.Text = Messages.Them_That_Bai;
                        }
                        BindDataGridView();
                        tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
                        BindDataDetail(_tblNguoiDungEO);
                        ClearMessages();
                    }
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
                if (CheckInput() == true)
                {
                    if (tblNguoiDungDAO.NguoiDung_Update(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                    }
                    else
                    {
                        lblMsg.Text = Messages.Sua_That_Bai;
                    }
                    BindDataGridView();
                    tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
                    BindDataDetail(_tblNguoiDungEO);
                }
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
                if (tblNguoiDungDAO.NguoiDung_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
                BindDataGridView();
                tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
                BindDataDetail(_tblNguoiDungEO);
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
            tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
            BindDataDetail(_tblNguoiDungEO);
        }
        #endregion

    }
}
