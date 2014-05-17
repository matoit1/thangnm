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
            loadCKEditor();
        }

        public void BindDataDetail(tblSanPhamEO _tblSanPhamEO)
        {
            txtPK_sSanPhamID.Text = Convert.ToString(_tblSanPhamEO.PK_sSanPhamID);
            try { ddlFK_iNhomSanPhamID.SelectedValue = Convert.ToString(_tblSanPhamEO.FK_iNhomSanPhamID); }
            catch { ddlFK_iNhomSanPhamID.SelectedIndex = 0; }
            txtsTenSanPham.Text = Convert.ToString(_tblSanPhamEO.sTenSanPham);
            txtsMoTa.Text = Convert.ToString(_tblSanPhamEO.sMoTa);
            txtsThongTin.Text = Convert.ToString(_tblSanPhamEO.sThongTin);
            txtsXuatXu.Text = Convert.ToString(_tblSanPhamEO.sXuatXu);
            txtsLinkImage.Text = Convert.ToString(_tblSanPhamEO.sLinkImage);
            txtlGiaBan.Text = Convert.ToString(_tblSanPhamEO.lGiaBan);
            txtiVAT.Text = Convert.ToString(_tblSanPhamEO.iVAT);
            try { ddliDoTuoi.SelectedValue = Convert.ToString(_tblSanPhamEO.iDoTuoi); }
            catch { ddliDoTuoi.SelectedIndex = 0; }
            try { ddliGioiTinh.SelectedValue = Convert.ToString(_tblSanPhamEO.iGioiTinh); }
            catch { ddliGioiTinh.SelectedIndex = 0; }
            txtiSoLuong.Text = Convert.ToString(_tblSanPhamEO.iSoLuong);
            if (_tblSanPhamEO.tNgayCapNhat == DateTime.MinValue) { txttNgayCapNhat.Text = DateTime.Now.ToString("dd/MM/yyyy"); } else { txttNgayCapNhat.Text = Convert.ToString(_tblSanPhamEO.tNgayCapNhat); }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblSanPhamEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
            
        }

        private tblSanPhamEO getObject()
        {
            try
            {
                tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                _tblSanPhamEO.PK_sSanPhamID = Convert.ToString(txtPK_sSanPhamID.Text);
                try { _tblSanPhamEO.FK_iNhomSanPhamID = Convert.ToInt16(ddlFK_iNhomSanPhamID.SelectedValue); }
                catch { lblFK_iNhomSanPhamID.Text = Messages.Ma_Khong_Hop_Le; }
                _tblSanPhamEO.sTenSanPham = Convert.ToString(txtsTenSanPham.Text);
                _tblSanPhamEO.sMoTa = Commons.RemoveHtmlTagsUsingCharArray(Convert.ToString(txtsThongTin.Text));
                _tblSanPhamEO.sThongTin = Convert.ToString(txtsThongTin.Text);
                _tblSanPhamEO.sXuatXu = Convert.ToString(txtsXuatXu.Text);
                _tblSanPhamEO.sLinkImage = Convert.ToString(txtsLinkImage.Text);
                _tblSanPhamEO.lGiaBan = Convert.ToInt64(txtlGiaBan.Text);
                _tblSanPhamEO.iVAT = Convert.ToInt16(txtiVAT.Text);
                try { _tblSanPhamEO.iDoTuoi = Convert.ToInt16(ddliDoTuoi.SelectedValue); }
                catch { lbliDoTuoi.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSanPhamEO.iDoTuoi = 0; }
                try { _tblSanPhamEO.iGioiTinh = Convert.ToInt16(ddliGioiTinh.SelectedValue); }
                catch { lbliGioiTinh.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSanPhamEO.iGioiTinh = 0; }
                _tblSanPhamEO.iSoLuong = Convert.ToInt16(txtiSoLuong.Text);
                //_tblSanPhamEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text);
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
            ddlFK_iNhomSanPhamID.DataSource = tblNhomSanPhamDAO.NhomSanPham_SelectList();
            ddlFK_iNhomSanPhamID.DataTextField = "sTenNhom";
            ddlFK_iNhomSanPhamID.DataValueField = "PK_iNhomSanPhamID";
            ddlFK_iNhomSanPhamID.DataBind();

            ddliDoTuoi.DataSource = GetListConstants.SanPham_iDoTuoi_GLC();
            ddliDoTuoi.DataTextField = "Value";
            ddliDoTuoi.DataValueField = "Key";
            ddliDoTuoi.DataBind();

            ddliGioiTinh.DataSource = GetListConstants.SanPham_iGioiTinh_GLC();
            ddliGioiTinh.DataTextField = "Value";
            ddliGioiTinh.DataValueField = "Key";
            ddliGioiTinh.DataBind();

            ddliTrangThai.DataSource = GetListConstants.SanPham_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_sSanPhamID.Text = "";
            lblFK_iNhomSanPhamID.Text = "";
            lblsTenSanPham.Text = "";
            lblsMoTa.Text = "";
            lblsThongTin.Text = "";
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

        #region "Config CKEditor"
        protected void loadCKEditor()
        {
            txtsThongTin.config.toolbar = new object[] { 
              new object[] { "Save", "NewPage", "Preview", "-", "Templates" },
                new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt" },
                new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
			
                "/",
                new object[] { "Bold", "Italic", "Underline", "Strike" },
                new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv" },
                new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
                new object[] { "BidiLtr", "BidiRtl" },
                new object[] { "Link", "Unlink", "Anchor" },
                new object[] { "Image"},
                "/"
            };
        }
        #endregion
    }
}