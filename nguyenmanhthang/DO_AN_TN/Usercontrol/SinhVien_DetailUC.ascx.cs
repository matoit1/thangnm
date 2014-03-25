using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.UserControl
{
    public partial class SinhVien_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(SinhVienEO _SinhVienEO)
        {
            ddlFK_sMaLop.SelectedValue = _SinhVienEO.FK_sMaLop;
            txtPK_sMaSV.Text = _SinhVienEO.PK_sMaSV;
            txtsHoTenSV.Text = _SinhVienEO.sHotenSV;
            txtsTendangnhapSV.Text = _SinhVienEO.sTendangnhapSV;
            txtsMatkhauSV.Text = _SinhVienEO.sMatkhauSV;
            txtsEmailSV.Text = _SinhVienEO.sEmailSV;
            txtsDiachiSV.Text = _SinhVienEO.sDiachiSV;
            txtsSdtSV.Text = _SinhVienEO.sSdtSV;
            try { txttNgaysinhSV.Text = Convert.ToString(_SinhVienEO.tNgaysinhSV); }
            catch { txttNgaysinhSV.Text = ""; }
            ddlbGioitinhSV.SelectedValue = Convert.ToString(_SinhVienEO.bGioitinhSV);
            txtsCMNDSV.Text = _SinhVienEO.sCMNDSV;
            txttNgayCapCMNDSV.Text = Convert.ToString(_SinhVienEO.tNgayCapCMNDSV);
            txtsNoiCapCMNDSV.Text = _SinhVienEO.sNoiCapCMNDSV;
            ddlbHonNhanSV.SelectedValue = Convert.ToString(_SinhVienEO.bHonNhanSV);
            txtsNguoiLienHeSV.Text = _SinhVienEO.sNguoiLienHeSV;
            txtsDiaChiNguoiLienHeSV.Text = _SinhVienEO.sDiaChiNguoiLienHeSV;
            txtsSdtNguoiLienHeSV.Text = _SinhVienEO.sSdtNguoiLienHeSV;
            try { ddliQuanHeVoiNguoiLienHeSV.SelectedValue = Convert.ToString(_SinhVienEO.iQuanHeVoiNguoiLienHeSV); }
            catch { ddliQuanHeVoiNguoiLienHeSV.SelectedIndex = 0; }
            ddlbKetnapDoanSV.SelectedValue = Convert.ToString(_SinhVienEO.bKetnapDoanSV);
            txtiNamketnapDoanSV.Text = Convert.ToString(_SinhVienEO.iNamketnapDoanSV);
            txtsNoiketnapDoanSV.Text = _SinhVienEO.sNoiketnapDoanSV;
            txtiNamtotnghiepTHPTSV.Text = Convert.ToString(_SinhVienEO.iNamtotnghiepTHPTSV);
            txttNgayNhapHocSV.Text = Convert.ToString(_SinhVienEO.tNgayNhapHocSV);
            txttNgayRaTruongSV.Text = Convert.ToString(_SinhVienEO.tNgayRaTruongSV);
            txttNgayCapTheSV.Text = Convert.ToString(_SinhVienEO.tNgayCapTheSV);
            try { ddliTrangThaiSV.SelectedValue = _SinhVienEO.iTrangThaiSV.ToString(); }
            catch { ddliTrangThaiSV.SelectedIndex = 0; }
        }



        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (SinhVienDAO.SinhVien_Insert(getObject()) == true)
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
            try
            {
                if (SinhVienDAO.SinhVien_Update(getObject()) == true)
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
            try
            {
                if (SinhVienDAO.SinhVien_Delete(getObject()) == true)
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
            SinhVienEO _SinhVienEO = new SinhVienEO();
            BindDataDetail(_SinhVienEO);
        }

        private SinhVienEO getObject()
        {
            try
            {
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.FK_sMaLop = ddlFK_sMaLop.SelectedValue;
                _SinhVienEO.PK_sMaSV = txtPK_sMaSV.Text;
                _SinhVienEO.sHotenSV = txtsHoTenSV.Text;
                _SinhVienEO.sTendangnhapSV = txtsTendangnhapSV.Text;
                _SinhVienEO.sMatkhauSV = txtsMatkhauSV.Text;
                _SinhVienEO.sEmailSV = txtsEmailSV.Text;
                _SinhVienEO.sDiachiSV = txtsDiachiSV.Text;
                _SinhVienEO.sSdtSV = txtsSdtSV.Text;
                _SinhVienEO.tNgaysinhSV = Convert.ToDateTime(txttNgaysinhSV.Text);
                _SinhVienEO.bGioitinhSV = Convert.ToBoolean(ddlbGioitinhSV.SelectedValue);
                _SinhVienEO.sCMNDSV = txtsCMNDSV.Text;
                _SinhVienEO.tNgayCapCMNDSV = Convert.ToDateTime(txttNgayCapCMNDSV.Text);
                _SinhVienEO.sNoiCapCMNDSV = txtsNoiCapCMNDSV.Text;
                _SinhVienEO.bHonNhanSV = Convert.ToBoolean(ddlbHonNhanSV.SelectedValue);
                _SinhVienEO.sNguoiLienHeSV = txtsNguoiLienHeSV.Text;
                _SinhVienEO.sDiaChiNguoiLienHeSV = txtsDiaChiNguoiLienHeSV.Text;
                _SinhVienEO.sSdtNguoiLienHeSV = txtsSdtNguoiLienHeSV.Text;
                _SinhVienEO.iQuanHeVoiNguoiLienHeSV = Convert.ToInt16(ddliQuanHeVoiNguoiLienHeSV.SelectedValue);
                _SinhVienEO.bKetnapDoanSV = Convert.ToBoolean(ddlbKetnapDoanSV.SelectedValue);
                _SinhVienEO.iNamketnapDoanSV = Convert.ToInt16(txtiNamketnapDoanSV.Text);
                _SinhVienEO.sNoiketnapDoanSV = txtsNoiketnapDoanSV.Text;
                _SinhVienEO.iNamtotnghiepTHPTSV = Convert.ToInt16(txtiNamtotnghiepTHPTSV.Text);
                _SinhVienEO.tNgayNhapHocSV = Convert.ToDateTime(txttNgayNhapHocSV.Text);
                _SinhVienEO.tNgayRaTruongSV = Convert.ToDateTime(txttNgayRaTruongSV.Text);
                _SinhVienEO.tNgayCapTheSV = Convert.ToDateTime(txttNgayCapTheSV.Text);
                _SinhVienEO.iTrangThaiSV = Convert.ToInt16(ddliTrangThaiSV.SelectedValue);
                return _SinhVienEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliTrangThaiSV.DataSource = SinhVienDAO.SinhVien_SelectList();
            ddliTrangThaiSV.DataTextField = "sTenlop";
            ddliTrangThaiSV.DataValueField = "PK_sMalop";
            ddliTrangThaiSV.DataBind();

            ddlbGioitinhSV.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlbGioitinhSV.DataTextField = "Value";
            ddlbGioitinhSV.DataValueField = "Key";
            ddlbGioitinhSV.DataBind();

            ddlbHonNhanSV.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlbHonNhanSV.DataTextField = "Value";
            ddlbHonNhanSV.DataValueField = "Key";
            ddlbHonNhanSV.DataBind();

            ddliQuanHeVoiNguoiLienHeSV.DataSource = GetListConstants.SinhVien_iQuanHeVoiNguoiLienHeSV_GLC();
            ddliQuanHeVoiNguoiLienHeSV.DataTextField = "Value";
            ddliQuanHeVoiNguoiLienHeSV.DataValueField = "Key";
            ddliQuanHeVoiNguoiLienHeSV.DataBind();

            ddlbKetnapDoanSV.DataSource = GetListConstants.SinhVien_bKetnapDoanSV_GLC();
            ddlbKetnapDoanSV.DataTextField = "Value";
            ddlbKetnapDoanSV.DataValueField = "Key";
            ddlbKetnapDoanSV.DataBind();

            ddliTrangThaiSV.DataSource = GetListConstants.SinhVien_iTrangThaiSV_GLC();
            ddliTrangThaiSV.DataTextField = "Value";
            ddliTrangThaiSV.DataValueField = "Key";
            ddliTrangThaiSV.DataBind();
        }
    }
}