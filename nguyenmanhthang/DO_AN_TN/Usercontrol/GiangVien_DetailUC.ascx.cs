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
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(GiangVienEO _GiangVienEO)
        {
            txtPK_sMaGV.Text = _GiangVienEO.PK_sMaGV;
            txtsHoTenGV.Text = _GiangVienEO.sHotenGV;
            txtsTendangnhapGV.Text = _GiangVienEO.sTendangnhapGV;
            txtsMatkhauGV.Text = _GiangVienEO.sMatkhauGV;
            txtsEmailGV.Text = _GiangVienEO.sEmailGV;
            txtsDiachiGV.Text = _GiangVienEO.sDiachiGV;
            txtsSdtGV.Text = _GiangVienEO.sSdtGV;
            try { txttNgaysinhGV.Text = Convert.ToString(_GiangVienEO.tNgaysinhGV); }
            catch { txttNgaysinhGV.Text = ""; }
            ddlbGioitinhGV.SelectedValue = Convert.ToString(_GiangVienEO.bGioitinhGV);
            txtsCMNDGV.Text = _GiangVienEO.sCMNDGV;
            txttNgayCapCMNDGV.Text = Convert.ToString(_GiangVienEO.tNgayCapCMNDGV);
            txtsNoiCapCMNDGV.Text = _GiangVienEO.sNoiCapCMNDGV;
            ddlbHonNhanGV.SelectedValue = Convert.ToString(_GiangVienEO.bHonNhanGV);
            txttNgayNhanCongTacGV.Text = Convert.ToString(_GiangVienEO.tNgayNhanCongTacGV);
            try { ddlbiChucVuGV.SelectedValue = Convert.ToString(_GiangVienEO.iChucVuGV); }
            catch { ddlbiChucVuGV.SelectedIndex = 0; }
            try { ddliHocViGV.SelectedValue = Convert.ToString(_GiangVienEO.iHocViGV);}
            catch { ddlbiChucVuGV.SelectedIndex = 0; }
            ddlbCongChucGV.SelectedValue = Convert.ToString(_GiangVienEO.bCongChucGV);
            txtsLinkChannels.Text = Convert.ToString(_GiangVienEO.sLinkChannels);
            txtsLinkChatRooms.Text = _GiangVienEO.sLinkChatRooms;
            try { ddliTrangThaiGV.SelectedValue = _GiangVienEO.iTrangThaiGV.ToString(); }
            catch { ddliTrangThaiGV.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
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
            GiangVienEO _GiangVienEO = new GiangVienEO();
            BindDataDetail(_GiangVienEO);
        }
        #endregion

        private GiangVienEO getObject()
        {
            try
            {
                GiangVienEO _GiangVienEO = new GiangVienEO();
                _GiangVienEO.PK_sMaGV = txtPK_sMaGV.Text;
                _GiangVienEO.sHotenGV = txtsHoTenGV.Text;
                _GiangVienEO.sTendangnhapGV = txtsTendangnhapGV.Text;
                _GiangVienEO.sMatkhauGV = txtsMatkhauGV.Text;
                _GiangVienEO.sEmailGV = txtsEmailGV.Text;
                _GiangVienEO.sDiachiGV = txtsDiachiGV.Text;
                _GiangVienEO.sSdtGV = txtsSdtGV.Text;
                _GiangVienEO.tNgaysinhGV = Convert.ToDateTime(txttNgaysinhGV.Text);
                _GiangVienEO.bGioitinhGV = Convert.ToBoolean(ddlbGioitinhGV.SelectedValue);
                _GiangVienEO.sCMNDGV = txtsCMNDGV.Text;
                _GiangVienEO.tNgayCapCMNDGV = Convert.ToDateTime(txttNgayCapCMNDGV.Text);
                _GiangVienEO.sNoiCapCMNDGV = txtsNoiCapCMNDGV.Text;
                _GiangVienEO.bHonNhanGV = Convert.ToBoolean(ddlbHonNhanGV.SelectedValue);

                _GiangVienEO.tNgayNhanCongTacGV = Convert.ToDateTime(txttNgayNhanCongTacGV.Text);
                _GiangVienEO.iChucVuGV = Convert.ToInt16(ddlbiChucVuGV.Text);
                _GiangVienEO.iHocViGV = Convert.ToInt16(ddliHocViGV.Text);
                _GiangVienEO.bCongChucGV = Convert.ToBoolean(ddlbCongChucGV.SelectedValue);
                _GiangVienEO.sLinkChannels = txtsLinkChannels.Text;
                _GiangVienEO.sLinkChatRooms = txtsLinkChatRooms.Text;
                _GiangVienEO.iTrangThaiGV = Convert.ToInt16(ddliTrangThaiGV.SelectedValue);
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

            ddlbiChucVuGV.DataSource = GetListConstants.GiangVien_iChucVuGV_GLC();
            ddlbiChucVuGV.DataTextField = "Value";
            ddlbiChucVuGV.DataValueField = "Key";
            ddlbiChucVuGV.DataBind();

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
    }
}