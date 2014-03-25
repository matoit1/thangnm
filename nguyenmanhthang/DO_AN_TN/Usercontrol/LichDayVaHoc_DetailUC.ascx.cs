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
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(LichDayVaHocEO _LichDayVaHocEO)
        {
            ddlFK_sMaPCCT.SelectedValue = Convert.ToString(_LichDayVaHocEO.FK_sMaPCCT);
            ddlFK_sMalop.SelectedValue = Convert.ToString(_LichDayVaHocEO.FK_sMalop);
            try { ddliCaHoc.SelectedValue = Convert.ToString(_LichDayVaHocEO.iCaHoc); }
            catch { ddliCaHoc.SelectedIndex = 0; }
            txttNgayDay.Text = Convert.ToString(_LichDayVaHocEO.tNgayDay);
            txtiSoTietDay.Text = Convert.ToString(_LichDayVaHocEO.iSoTietDay);
            txtsSinhVienNghi.Text = Convert.ToString(_LichDayVaHocEO.sSinhVienNghi);
            try { ddliTrangThai.SelectedValue = _LichDayVaHocEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
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
            LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
            BindDataDetail(_LichDayVaHocEO);
        }
        #endregion

        private LichDayVaHocEO getObject()
        {
            try
            {
                LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                _LichDayVaHocEO.FK_sMaPCCT = ddlFK_sMaPCCT.SelectedValue;
                _LichDayVaHocEO.FK_sMalop = ddlFK_sMalop.SelectedValue;
                _LichDayVaHocEO.iCaHoc = Convert.ToInt16(ddliCaHoc.SelectedValue);
                _LichDayVaHocEO.tNgayDay = Convert.ToDateTime(txttNgayDay.Text);
                _LichDayVaHocEO.iSoTietDay = Convert.ToInt16(txtiSoTietDay.Text);
                _LichDayVaHocEO.sSinhVienNghi = txtsSinhVienNghi.Text;
                _LichDayVaHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
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
    }
}