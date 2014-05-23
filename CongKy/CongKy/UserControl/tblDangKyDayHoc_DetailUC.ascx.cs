using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.DataAccessObject;
using CongKy.SharedLibraries;

namespace CongKy.UserControl
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
            //loadCKEditor();
        }

        public void BindDataDetail(tblMonHocEO _tblSanPhamEO)
        {
            txtPK_sSanPhamID.Text = Convert.ToString(_tblSanPhamEO.PK_sSanPhamID);
            try { ddlFK_iNhomSanPhamID.SelectedValue = Convert.ToString(_tblSanPhamEO.FK_iNhomSanPhamID); }
            catch { ddlFK_iNhomSanPhamID.SelectedIndex = 0; }
            txtsTenSanPham.Text = Convert.ToString(_tblSanPhamEO.sTenSanPham);
            txtsMoTa.Text = Convert.ToString(_tblSanPhamEO.sMoTa);
            //txtsThongTin.Text = Convert.ToString(_tblSanPhamEO.sThongTin);
            txtsXuatXu.Text = Convert.ToString(_tblSanPhamEO.sXuatXu);
            if (String.IsNullOrEmpty(_tblSanPhamEO.sLinkImage) == true) { txtsLinkImage.Text = "~/Images/Product/"; } else { txtsLinkImage.Text = Convert.ToString(_tblSanPhamEO.sLinkImage); }
            //txtsLinkImage.Text = Convert.ToString(_tblSanPhamEO.sLinkImage);
            txtlGiaBan.Text = Convert.ToString(_tblSanPhamEO.lGiaBan);
            txtiVAT.Text = Convert.ToString(_tblSanPhamEO.iVAT);
            try { ddliDoTuoi.SelectedValue = Convert.ToString(_tblSanPhamEO.iDoTuoi); }
            catch { ddliDoTuoi.SelectedIndex = 0; }
            try { ddliGioiTinh.SelectedValue = Convert.ToString(_tblSanPhamEO.iGioiTinh); }
            catch { ddliGioiTinh.SelectedIndex = 0; }
            txtiSoLuong.Text = Convert.ToString(_tblSanPhamEO.iSoLuong);
            if (_tblSanPhamEO.tNgayCapNhat == DateTime.MinValue) { txttNgayCapNhat.Text = DateTime.Now.ToString(); } else { txttNgayCapNhat.Text = Convert.ToString(_tblSanPhamEO.tNgayCapNhat); }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblSanPhamEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
            
        }

        private tblMonHocEO getObject()
        {
            try
            {
                tblMonHocEO _tblSanPhamEO = new tblMonHocEO();
                _tblSanPhamEO.PK_sSanPhamID = Convert.ToString(txtPK_sSanPhamID.Text);
                try { _tblSanPhamEO.FK_iNhomSanPhamID = Convert.ToInt16(ddlFK_iNhomSanPhamID.SelectedValue); }
                catch { lblFK_iNhomSanPhamID.Text = Messages.Ma_Khong_Hop_Le; }
                _tblSanPhamEO.sTenSanPham = Convert.ToString(txtsTenSanPham.Text);
                //_tblSanPhamEO.sMoTa = Commons.RemoveHtmlTagsUsingCharArray(Convert.ToString(txtsThongTin.Text));
               // _tblSanPhamEO.sThongTin = Convert.ToString(txtsThongTin.Text);
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
            ddlFK_iNhomSanPhamID.DataSource = tblGiaoTrinhDAO.NhomSanPham_SelectList();
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

        public bool CheckInput()
        {
            Int64 num64;
            Int16 num16;
            tblMonHocEO _tblSanPhamEO = new tblMonHocEO();
            if (string.IsNullOrEmpty(txtPK_sSanPhamID.Text) == true)
            {
                lblPK_sSanPhamID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_sSanPhamID.Focus();
                return false;
            }
            else
            {
                _tblSanPhamEO.PK_sSanPhamID = txtPK_sSanPhamID.Text;
                if (tblMonHocDAO.SanPham_CheckExists_PK_sSanPhamID(_tblSanPhamEO) == true)
                {
                    lblPK_sSanPhamID.Text = Messages.Ma_Da_Ton_Tai;
                    txtPK_sSanPhamID.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsTenSanPham.Text) == true)
            {
                lblsTenSanPham.Text = Messages.Khong_Duoc_De_Trong;
                txtsTenSanPham.Focus();
                return false;
            }
            //if (string.IsNullOrEmpty(txtsThongTin.Text) == true)
            //{
            //    lblsThongTin.Text = Messages.Khong_Duoc_De_Trong;
            //    txtsThongTin.Focus();
            //    return false;
            //}
            if (string.IsNullOrEmpty(txtsXuatXu.Text) == true)
            {
                lblsXuatXu.Text = Messages.Khong_Duoc_De_Trong;
                txtsXuatXu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsLinkImage.Text) == true)
            {
                lblsLinkImage.Text = Messages.Khong_Duoc_De_Trong;
                txtsLinkImage.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtlGiaBan.Text) == true)
            {
                lbllGiaBan.Text = Messages.Khong_Duoc_De_Trong;
                txtlGiaBan.Focus();
                return false;
            }
            else
            {
                bool isNum = Int64.TryParse(txtlGiaBan.Text, out num64);
                if (isNum == false)
                {
                    lbllGiaBan.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtlGiaBan.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtiVAT.Text) == true)
            {
                lbliVAT.Text = Messages.Khong_Duoc_De_Trong;
                txtiVAT.Focus();
                return false;
            }
            else
            {
                bool isNum = Int16.TryParse(txtiVAT.Text, out num16);
                if (isNum == false)
                {
                    lbliVAT.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtiVAT.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtiSoLuong.Text) == true)
            {
                lbliSoLuong.Text = Messages.Khong_Duoc_De_Trong;
                txtiSoLuong.Focus();
                return false;
            }
            else
            {
                bool isNum = Int16.TryParse(txtiSoLuong.Text, out num16);
                if (isNum == false)
                {
                    lbliSoLuong.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtiSoLuong.Focus();
                    return false;
                }
            }
            return true;
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
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
            lblMsg.Text = "";
            try
            {
              if (CheckInput() == true)
               {
                if (tblMonHocDAO.SanPham_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                    ClearMessages();
                    tblMonHocEO _tblSanPhamEO = new tblMonHocEO();
                    BindDataDetail(_tblSanPhamEO);
                }
                else
                {
                    lblMsg.Text = Messages.Them_That_Bai;
                }
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
            lblMsg.Text = "";
            try
            {
              if (CheckInput() == true)
               {
                if (tblMonHocDAO.SanPham_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                    ClearMessages();
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
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
            lblMsg.Text = "";
            try
            {
                tblChiTietGiaoTrinhEO _tblChiTietHoaDonEO = new tblChiTietGiaoTrinhEO();
                _tblChiTietHoaDonEO.FK_sSanPhamID = getObject().PK_sSanPhamID;
                if (tblChiTietGiaoTrinhDAO.ChiTietHoaDon_CheckExists_FK_sSanPhamID(_tblChiTietHoaDonEO) == false)
                {
                    if (tblMonHocDAO.SanPham_Delete(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Xoa_Thanh_Cong;
                        ClearMessages();
                        tblMonHocEO _tblSanPhamEO = new tblMonHocEO();
                        BindDataDetail(_tblSanPhamEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Xoa_That_Bai;
                    }
                }
                else
                {
                    lblMsg.Text = Messages.Ma_San_Pham_Da_Dung_Trong_Chi_Tiet_Hoa_Don;
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
            lblMsg.Text = "";
            tblMonHocEO _tblSanPhamEO = new tblMonHocEO();
            BindDataDetail(_tblSanPhamEO);
        }
        #endregion

        #region "Config CKEditor"
        //protected void loadCKEditor()
        //{
        //    txtsThongTin.config.toolbar = new object[] { 
        //      new object[] { "Save", "NewPage", "Preview", "-", "Templates" },
        //        new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt" },
        //        new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
			
        //        "/",
        //        new object[] { "Bold", "Italic", "Underline", "Strike" },
        //        new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv" },
        //        new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
        //        new object[] { "BidiLtr", "BidiRtl" },
        //        new object[] { "Link", "Unlink", "Anchor" },
        //        new object[] { "Image"},
        //        "/"
        //    };
        //}
        #endregion
    }
}