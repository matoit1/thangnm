using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using DataAccessObject;
using EntityObject;

namespace EHOU.UserControl
{
    public partial class PhanCongCongTac_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            try { txtPK_sMaPCCT.Text = Convert.ToString(_PhanCongCongTacEO.PK_sMaPCCT); }
            catch { lblPK_sMaPCCT.Text = Messages.Ma_Khong_Hop_Le; }
            try { ddlFK_sMaGV.Text = Convert.ToString(_PhanCongCongTacEO.FK_sMaGV); }
            catch { lblFK_sMaGV.Text = Messages.Ma_Khong_Hop_Le; }
            try { ddlFK_sMaMonhoc.Text = Convert.ToString(_PhanCongCongTacEO.FK_sMaMonhoc); }
            catch { lblFK_sMaMonhoc.Text = Messages.Ma_Khong_Hop_Le; }
            try { txttNgayBatDau.Text = Convert.ToString(_PhanCongCongTacEO.tNgayBatDau.ToShortDateString()); }
            catch { txttNgayBatDau.Text = ""; lbltNgayBatDau.Text = Messages.Loi_Tai_Du_Lieu; }
            try { txttNgayKetThuc.Text = Convert.ToString(_PhanCongCongTacEO.tNgayKetThuc.ToShortDateString()); }
            catch { lbltNgayKetThuc.Text = Messages.Loi_Tai_Du_Lieu; }
            try { ddliTrangThai.SelectedValue = _PhanCongCongTacEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; lbliTrangThai.Text = Messages.Loi_Tai_Du_Lieu; }
        }

        private PhanCongCongTacEO getObject()
        {
            try
            {
                PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                _PhanCongCongTacEO.PK_sMaPCCT = Convert.ToString(txtPK_sMaPCCT.Text);
                _PhanCongCongTacEO.FK_sMaGV = Convert.ToString(ddlFK_sMaGV.SelectedValue);
                _PhanCongCongTacEO.FK_sMaMonhoc = Convert.ToString(ddlFK_sMaMonhoc.SelectedValue);
                try { _PhanCongCongTacEO.tNgayBatDau = Convert.ToDateTime(txttNgayBatDau.Text); }
                catch { lbltNgayBatDau.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                try { _PhanCongCongTacEO.tNgayKetThuc = Convert.ToDateTime(txttNgayKetThuc.Text); }
                catch { lbltNgayKetThuc.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                try { _PhanCongCongTacEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _PhanCongCongTacEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_sMaGV.DataSource = GiangVienDAO.GiangVien_SelectList();
            ddlFK_sMaGV.DataTextField = "sHoTenGV";
            ddlFK_sMaGV.DataValueField = "PK_sMaGV";
            ddlFK_sMaGV.DataBind();

            ddlFK_sMaMonhoc.DataSource = MonHocDAO.MonHoc_SelectList();
            ddlFK_sMaMonhoc.DataTextField = "sTenMonhoc";
            ddlFK_sMaMonhoc.DataValueField = "PK_sMaMonhoc";
            ddlFK_sMaMonhoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.PhanCongCongTac_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_sMaPCCT.Text = "";
            lblFK_sMaGV.Text = "";
            lblFK_sMaMonhoc.Text = "";
            lbltNgayBatDau.Text = "";
            lbltNgayKetThuc.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (PhanCongCongTacDAO.PhanCongCongTac_Insert(getObject()) == true)
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
                if (PhanCongCongTacDAO.PhanCongCongTac_Update(getObject()) == true)
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
                if (PhanCongCongTacDAO.PhanCongCongTac_Delete(getObject()) == true)
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
            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
            BindDataDetail(_PhanCongCongTacEO);
        }
        #endregion

        #region "CheckExists"
        protected void txtPK_sMaMonhoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                _PhanCongCongTacEO.PK_sMaPCCT = txtPK_sMaPCCT.Text;
                if (PhanCongCongTacDAO.PhanCongCongTac_CheckExists(_PhanCongCongTacEO) == true)
                {
                    lblPK_sMaPCCT.Text = Messages.Ma_Da_Ton_Tai;
                }
                else
                {
                    lblPK_sMaPCCT.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }
        #endregion

        protected void txtPK_sMaPCCT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}