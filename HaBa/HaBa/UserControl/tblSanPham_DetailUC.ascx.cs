using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries;

namespace HaBa.UserControl
{
    public partial class tblSanPham_DetailUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public Int16 iType
        {
            get { return (Int16)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblSanPhamEO _tblSanPhamEO)
        {
            txtPK_lSanPhamID.Text = Convert.ToString(_tblSanPhamEO.PK_lSanPhamID);
            try { ddlFK_iNhomSanPhamID.SelectedValue = Convert.ToString(_tblSanPhamEO.FK_iNhomSanPhamID); }
            catch { ddlFK_iNhomSanPhamID.SelectedIndex = 0; }
            txtsTenSanPham.Text = Convert.ToString(_tblSanPhamEO.sTenSanPham);
            txtsMoTa.Text = Convert.ToString(_tblSanPhamEO.sMoTa);
            txtsXuatXu.Text = Convert.ToString(_tblSanPhamEO.sXuatXu);
            txtsLinkImage.Text = Convert.ToString(_tblSanPhamEO.sLinkImage);
            txtlGiaBan.Text = Convert.ToString(_tblSanPhamEO.lGiaBan);
            txtiVAT.Text = Convert.ToString(_tblSanPhamEO.iVAT);
            try { ddliDoTuoi.SelectedValue = Convert.ToString(_tblSanPhamEO.iDoTuoi); }
            catch { ddliDoTuoi.SelectedIndex = 0; }
            try { ddliGioiTinh.SelectedValue = Convert.ToString(_tblSanPhamEO.iGioiTinh); }
            catch { ddliGioiTinh.SelectedIndex = 0; }
            txtiSoLuong.Text = Convert.ToString(_tblSanPhamEO.iSoLuong);
            txttNgayCapNhat.Text = Convert.ToString(_tblSanPhamEO.tNgayCapNhat);
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblSanPhamEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
            
        }

        private tblSanPhamEO getObject()
        {
            try
            {
                tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                _tblSanPhamEO.PK_lSanPhamID = Convert.ToInt64(txtPK_lSanPhamID.Text);
                try { _tblSanPhamEO.FK_iNhomSanPhamID = Convert.ToInt16(ddlFK_iNhomSanPhamID.SelectedValue); }
                catch { lblFK_iNhomSanPhamID.Text = Messages.Ma_Khong_Hop_Le; }
                _tblSanPhamEO.sTenSanPham = Convert.ToString(txtsTenSanPham.Text);
                _tblSanPhamEO.sMoTa = Convert.ToString(txtsMoTa.Text);
                _tblSanPhamEO.sXuatXu = Convert.ToString(txtsXuatXu.Text);
                _tblSanPhamEO.sLinkImage = Convert.ToString(txtsLinkImage.Text);
                _tblSanPhamEO.lGiaBan = Convert.ToInt64(txtlGiaBan.Text);
                _tblSanPhamEO.iVAT = Convert.ToInt16(txtiVAT.Text);
                try { _tblSanPhamEO.iDoTuoi = Convert.ToInt16(ddliDoTuoi.SelectedValue); }
                catch { lbliDoTuoi.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSanPhamEO.iDoTuoi = 0; }
                try { _tblSanPhamEO.iGioiTinh = Convert.ToInt16(ddliGioiTinh.SelectedValue); }
                catch { lbliGioiTinh.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSanPhamEO.iGioiTinh = 0; }
                _tblSanPhamEO.iSoLuong = Convert.ToInt16(txtiSoLuong.Text);
                _tblSanPhamEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text);
                try { _tblSanPhamEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSanPhamEO.iTrangThai = 0; }
                return _tblSanPhamEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_iNhomSanPhamID.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddlFK_iNhomSanPhamID.DataTextField = "FK_iTaiKhoanID_Nhan";
            ddlFK_iNhomSanPhamID.DataValueField = "PK_lHoaDonID";
            ddlFK_iNhomSanPhamID.DataBind();

            ddliDoTuoi.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddliDoTuoi.DataTextField = "sTenSanPham";
            ddliDoTuoi.DataValueField = "PK_lSanPhamID";
            ddliDoTuoi.DataBind();

            ddliGioiTinh.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddliGioiTinh.DataTextField = "FK_iTaiKhoanID_Nhan";
            ddliGioiTinh.DataValueField = "PK_lHoaDonID";
            ddliGioiTinh.DataBind();

            ddliTrangThai.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddliTrangThai.DataTextField = "sTenSanPham";
            ddliTrangThai.DataValueField = "PK_lSanPhamID";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_lSanPhamID.Text = "";
            lblFK_iNhomSanPhamID.Text = "";
            lblsTenSanPham.Text = "";
            lblsMoTa.Text = "";
            lblsXuatXu.Text = "";
            lblsLinkImage.Text = "";
            lbllGiaBan.Text = "";
            lbliVAT.Text = "";
            lbliDoTuoi.Text = "";
            lbliGioiTinh.Text = "";
            lbliSoLuong.Text = "";
            lbltNgayCapNhat.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblSanPhamDAO.SanPham_Insert(getObject()) == true)
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
                if (tblSanPhamDAO.SanPham_Update(getObject()) == true)
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
                if (tblSanPhamDAO.SanPham_Delete(getObject()) == true)
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
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            BindDataDetail(_tblSanPhamEO);
        }
        #endregion
    }
}