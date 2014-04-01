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
    public partial class GiangVien_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(GiangVienEO _GiangVienEO)
        {
            try { txtPK_sMaGV.Text = Convert.ToString(_GiangVienEO.PK_sMaGV); }
            catch { txtPK_sMaGV.Text = "";  lblPK_sMaGV.Text = Messages.Ma_Khong_Hop_Le; }
            txtsHoTenGV.Text = Convert.ToString(_GiangVienEO.sHotenGV);
            txtsTendangnhapGV.Text = Convert.ToString(_GiangVienEO.sTendangnhapGV);
            txtsMatkhauGV.Text = Convert.ToString(_GiangVienEO.sMatkhauGV);
            txtsEmailGV.Text = Convert.ToString(_GiangVienEO.sEmailGV);
            txtsDiachiGV.Text = Convert.ToString(_GiangVienEO.sDiachiGV);
            txtsSdtGV.Text = Convert.ToString(_GiangVienEO.sSdtGV);
            txttNgaysinhGV.Text = Convert.ToString(_GiangVienEO.tNgaysinhGV.ToShortDateString());
            ddlbGioitinhGV.SelectedValue = Convert.ToString(_GiangVienEO.bGioitinhGV);
            txtsCMNDGV.Text = Convert.ToString(_GiangVienEO.sCMNDGV);
            txttNgayCapCMNDGV.Text = Convert.ToString(_GiangVienEO.tNgayCapCMNDGV.ToShortDateString());
            txtsNoiCapCMNDGV.Text = Convert.ToString(_GiangVienEO.sNoiCapCMNDGV);
            ddlbHonNhanGV.SelectedValue = Convert.ToString(_GiangVienEO.bHonNhanGV);
            txttNgayNhanCongTacGV.Text = Convert.ToString(_GiangVienEO.tNgayNhanCongTacGV.ToShortDateString());
            try { ddliChucVuGV.SelectedValue = Convert.ToString(_GiangVienEO.iChucVuGV); }
            catch { ddliChucVuGV.SelectedIndex = 0; lbliChucVuGV.Text = Messages.Loi_Tai_Du_Lieu; }
            try { ddliHocViGV.SelectedValue = Convert.ToString(_GiangVienEO.iHocViGV);}
            catch { ddliHocViGV.SelectedIndex = 0; lbliHocViGV.Text = Messages.Loi_Tai_Du_Lieu; }
            ddlbCongChucGV.SelectedValue = Convert.ToString(_GiangVienEO.bCongChucGV);
            txtsLinkChannelsGV.Text = Convert.ToString(_GiangVienEO.sLinkChannelsGV);
            txtsLinkChatRoomsGV.Text = Convert.ToString(_GiangVienEO.sLinkChatRoomsGV);
            txtsLinkAvatarGV.Text = Convert.ToString(_GiangVienEO.sLinkAvatarGV);
            try { ddliTrangThaiGV.SelectedValue = _GiangVienEO.iTrangThaiGV.ToString(); }
            catch { ddliTrangThaiGV.SelectedIndex = 0; lbliTrangThaiGV.Text = Messages.Loi_Tai_Du_Lieu; }
        }

        private GiangVienEO getObject()
        {
            try
            {
                GiangVienEO _GiangVienEO = new GiangVienEO();
                _GiangVienEO.PK_sMaGV = Convert.ToString(txtPK_sMaGV.Text);
                _GiangVienEO.sHotenGV = Convert.ToString(txtsHoTenGV.Text);
                _GiangVienEO.sTendangnhapGV = Convert.ToString(txtsTendangnhapGV.Text);
                _GiangVienEO.sMatkhauGV = Convert.ToString(Security.EnCrypt(txtsMatkhauGV.Text));
                _GiangVienEO.sEmailGV = Convert.ToString(txtsEmailGV.Text);
                _GiangVienEO.sDiachiGV = Convert.ToString(txtsDiachiGV.Text);
                _GiangVienEO.sSdtGV = Convert.ToString(txtsSdtGV.Text);
                try { _GiangVienEO.tNgaysinhGV = Convert.ToDateTime(txttNgaysinhGV.Text); }
                catch { lbltNgaysinhGV.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                _GiangVienEO.bGioitinhGV = Convert.ToBoolean(ddlbGioitinhGV.SelectedValue);
                _GiangVienEO.sCMNDGV = Convert.ToString(txtsCMNDGV.Text);
                try { _GiangVienEO.tNgayCapCMNDGV = Convert.ToDateTime(txttNgayCapCMNDGV.Text); }
                catch { lbltNgayCapCMNDGV.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                _GiangVienEO.sNoiCapCMNDGV = Convert.ToString(txtsNoiCapCMNDGV.Text);
                _GiangVienEO.bHonNhanGV = Convert.ToBoolean(ddlbHonNhanGV.SelectedValue);
                try { _GiangVienEO.tNgayNhanCongTacGV = Convert.ToDateTime(txttNgayNhanCongTacGV.Text); }
                catch { lbltNgayNhanCongTacGV.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                try { _GiangVienEO.iChucVuGV = Convert.ToInt16(ddliChucVuGV.Text); }
                catch { lbliChucVuGV.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _GiangVienEO.iHocViGV = Convert.ToInt16(ddliHocViGV.Text); }
                catch { lbliHocViGV.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                _GiangVienEO.bCongChucGV = Convert.ToBoolean(ddlbCongChucGV.SelectedValue);
                _GiangVienEO.sLinkChannelsGV = Convert.ToString(txtsLinkChannelsGV.Text);
                _GiangVienEO.sLinkChatRoomsGV = Convert.ToString(txtsLinkChatRoomsGV.Text);
                _GiangVienEO.sLinkAvatarGV = Convert.ToString(txtsLinkAvatarGV.Text);
                try { _GiangVienEO.iTrangThaiGV = Convert.ToInt16(ddliTrangThaiGV.SelectedValue); }
                catch { lbliTrangThaiGV.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _GiangVienEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlbGioitinhGV.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlbGioitinhGV.DataTextField = "Value";
            ddlbGioitinhGV.DataValueField = "Key";
            ddlbGioitinhGV.DataBind();

            ddlbHonNhanGV.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlbHonNhanGV.DataTextField = "Value";
            ddlbHonNhanGV.DataValueField = "Key";
            ddlbHonNhanGV.DataBind();

            ddliChucVuGV.DataSource = GetListConstants.GiangVien_iChucVuGV_GLC();
            ddliChucVuGV.DataTextField = "Value";
            ddliChucVuGV.DataValueField = "Key";
            ddliChucVuGV.DataBind();

            ddliHocViGV.DataSource = GetListConstants.GiangVien_iHocViGV_GLC();
            ddliHocViGV.DataTextField = "Value";
            ddliHocViGV.DataValueField = "Key";
            ddliHocViGV.DataBind();

            ddlbCongChucGV.DataSource = GetListConstants.GiangVien_bCongChucGV_GLC();
            ddlbCongChucGV.DataTextField = "Value";
            ddlbCongChucGV.DataValueField = "Key";
            ddlbCongChucGV.DataBind();

            ddliTrangThaiGV.DataSource = GetListConstants.GiangVien_iTrangThaiGV_GLC();
            ddliTrangThaiGV.DataTextField = "Value";
            ddliTrangThaiGV.DataValueField = "Key";
            ddliTrangThaiGV.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_sMaGV.Text = "";
            lblsHoTenGV.Text = "";
            lblsTendangnhapGV.Text = "";
            lblsMatkhauGV.Text = "";
            lblsEmailGV.Text = "";
            lblsDiachiGV.Text = "";
            lblsSdtGV.Text = "";
            lbltNgaysinhGV.Text = "";
            lblbGioitinhGV.Text = "";
            lblsCMNDGV.Text = "";
            lbltNgayCapCMNDGV.Text = "";
            lblsNoiCapCMNDGV.Text = "";
            lblbHonNhanGV.Text = "";
            lbltNgayNhanCongTacGV.Text = "";
            lbliChucVuGV.Text = "";
            lbliHocViGV.Text = "";
            lblbCongChucGV.Text = "";
            lblsLinkChannelsGV.Text = "";
            lblsLinkChatRoomsGV.Text = "";
            lblsLinkAvatarGV.Text = "";
            lbliTrangThaiGV.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (GiangVienDAO.GiangVien_Insert(getObject()) == true)
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
                if (GiangVienDAO.GiangVien_Update(getObject()) == true)
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
                if (GiangVienDAO.GiangVien_Delete(getObject()) == true)
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
            GiangVienEO _GiangVienEO = new GiangVienEO();
            BindDataDetail(_GiangVienEO);
        }
        #endregion
    }
}