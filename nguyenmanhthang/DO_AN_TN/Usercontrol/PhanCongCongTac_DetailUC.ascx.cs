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
    public partial class PhanCongCongTac_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            txtPK_sMaPCCT.Text = Convert.ToString(_PhanCongCongTacEO.PK_sMaPCCT);
            ddlFK_sMaGV.Text = Convert.ToString(_PhanCongCongTacEO.FK_sMaGV);
            ddlFK_sMaMonhoc.Text = Convert.ToString(_PhanCongCongTacEO.FK_sMaMonhoc);
            txttNgayBatDau.Text = Convert.ToString(_PhanCongCongTacEO.tNgayBatDau);
            txttNgayKetThuc.Text = Convert.ToString(_PhanCongCongTacEO.tNgayKetThuc);
            try { ddliTrangThai.SelectedValue = _PhanCongCongTacEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
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
            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
            BindDataDetail(_PhanCongCongTacEO);
        }
        #endregion

        private PhanCongCongTacEO getObject()
        {
            try
            {
                PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                _PhanCongCongTacEO.PK_sMaPCCT = txtPK_sMaPCCT.Text;
                _PhanCongCongTacEO.FK_sMaGV = ddlFK_sMaGV.SelectedValue;
                _PhanCongCongTacEO.FK_sMaMonhoc = ddlFK_sMaMonhoc.SelectedValue;
                _PhanCongCongTacEO.tNgayBatDau = Convert.ToDateTime(txttNgayBatDau.Text);
                _PhanCongCongTacEO.tNgayKetThuc = Convert.ToDateTime(txttNgayKetThuc.Text);
                _PhanCongCongTacEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
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
    }
}