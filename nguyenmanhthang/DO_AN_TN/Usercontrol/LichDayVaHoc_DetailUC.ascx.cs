using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using DataAccessObject;
using EntityObject;

namespace DO_AN_TN.UserControl
{
    public partial class LichDayVaHoc_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(LichDayVaHocEO _LichDayVaHocEO)
        {
            try { ddlFK_sMaPCCT.SelectedValue = Convert.ToString(_LichDayVaHocEO.FK_sMaPCCT); }
            catch { ddlFK_sMaPCCT.SelectedIndex = 0; lblFK_sMaPCCT.Text = Messages.Ma_Khong_Hop_Le; }
            try { ddlFK_sMalop.SelectedValue = Convert.ToString(_LichDayVaHocEO.FK_sMalop); }
            catch { ddlFK_sMalop.SelectedIndex = 0; lblFK_sMalop.Text = Messages.Ma_Khong_Hop_Le; }
            try { ddliCaHoc.SelectedValue = Convert.ToString(_LichDayVaHocEO.iCaHoc); }
            catch { ddliCaHoc.SelectedIndex = 0; lbliCaHoc.Text = Messages.Loi_Tai_Du_Lieu; }
            txttNgayDay.Text = Convert.ToString(_LichDayVaHocEO.tNgayDay.ToShortDateString());
            txtiSoTietDay.Text = Convert.ToString(_LichDayVaHocEO.iSoTietDay);
            txtsSinhVienNghi.Text = Convert.ToString(_LichDayVaHocEO.sSinhVienNghi);
            try { ddliTrangThai.SelectedValue = Convert.ToString(_LichDayVaHocEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; lbliTrangThai.Text = Messages.Loi_Tai_Du_Lieu; }
        }

        private LichDayVaHocEO getObject()
        {
            try
            {
                LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                try { _LichDayVaHocEO.FK_sMaPCCT = Convert.ToString(ddlFK_sMaPCCT.SelectedValue); }
                catch { lblFK_sMaPCCT.Text = Messages.Ma_Khong_Hop_Le; }
                try { _LichDayVaHocEO.FK_sMalop = Convert.ToString(ddlFK_sMalop.SelectedValue); }
                catch { lblFK_sMalop.Text = Messages.Ma_Khong_Hop_Le; }
                try { _LichDayVaHocEO.iCaHoc = Convert.ToInt16(ddliCaHoc.SelectedValue); }
                catch { lbliCaHoc.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _LichDayVaHocEO.tNgayDay = Convert.ToDateTime(txttNgayDay.Text); }
                catch { lbltNgayDay.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                try { _LichDayVaHocEO.iSoTietDay = Convert.ToInt16(txtiSoTietDay.Text); }
                catch { lbliSoTietDay.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                _LichDayVaHocEO.sSinhVienNghi = Convert.ToString(txtsSinhVienNghi.Text);
                try { _LichDayVaHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _LichDayVaHocEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_sMaPCCT.DataSource = PhanCongCongTacDAO.PhanCongCongTac_SelectList();
            ddlFK_sMaPCCT.DataTextField = "PK_sMaPCCT";
            ddlFK_sMaPCCT.DataValueField = "PK_sMaPCCT";
            ddlFK_sMaPCCT.DataBind();

            ddlFK_sMalop.DataSource = LopHocDAO.LopHoc_SelectList();
            ddlFK_sMalop.DataTextField = "sTenlop";
            ddlFK_sMalop.DataValueField = "PK_sMalop";
            ddlFK_sMalop.DataBind();

            ddliCaHoc.DataSource = GetListConstants.LichDayVaHoc_iCaHoc_GLC();
            ddliCaHoc.DataTextField = "Value";
            ddliCaHoc.DataValueField = "Key";
            ddliCaHoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.LichDayVaHoc_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblFK_sMaPCCT.Text = "";
            lblFK_sMalop.Text = "";
            lbliCaHoc.Text = "";
            lbltNgayDay.Text = "";
            lbliSoTietDay.Text = "";
            lblsSinhVienNghi.Text = "";
            lbliTrangThai.Text = "";
        }
        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (LichDayVaHocDAO.LichDayVaHoc_Insert(getObject()) == true)
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
                if (LichDayVaHocDAO.LichDayVaHoc_Update(getObject()) == true)
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
                if (LichDayVaHocDAO.LichDayVaHoc_Delete(getObject()) == true)
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
            LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
            BindDataDetail(_LichDayVaHocEO);
        }
        #endregion
    }
}