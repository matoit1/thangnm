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
    public partial class DiemThi_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(DiemThiEO _DiemThiEO)
        {
            try { ddlFK_sMaSV.SelectedValue = Convert.ToString(_DiemThiEO.FK_sMaSV); }
            catch { lblFK_sMaSV.Text = Messages.Ma_Khong_Hop_Le; }
            try { ddlFK_sMaMonhoc.SelectedValue = Convert.ToString(_DiemThiEO.FK_sMaMonhoc); }
            catch { ddlFK_sMaMonhoc.SelectedIndex = 0; }
            txtPK_iSolanhoc.Text = Convert.ToString(_DiemThiEO.PK_iSolanhoc);
            txtfDiemchuyencan.Text = Convert.ToString(_DiemThiEO.fDiemchuyencan);
            txtfDiemgiuaky.Text = Convert.ToString(_DiemThiEO.fDiemgiuaky);
            txtfDiemthilan1.Text = Convert.ToString(_DiemThiEO.fDiemthilan1);
            txtfDiemthilan2.Text = Convert.ToString(_DiemThiEO.fDiemthilan2);
            try { ddliTrangThai.SelectedValue = _DiemThiEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (DiemThiDAO.DiemThi_Insert(getObject()) == true)
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
                if (DiemThiDAO.DiemThi_Update(getObject()) == true)
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
                if (DiemThiDAO.DiemThi_Delete(getObject()) == true)
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
            DiemThiEO _DiemThiEO = new DiemThiEO();
            BindDataDetail(_DiemThiEO);
        }
        #endregion

        private DiemThiEO getObject()
        {
            try
            {
                DiemThiEO _DiemThiEO = new DiemThiEO();
                try { _DiemThiEO.FK_sMaSV = Convert.ToString(ddlFK_sMaSV.SelectedValue); }
                catch { lblFK_sMaSV.Text = Messages.Ma_Khong_Hop_Le; }
                try { _DiemThiEO.FK_sMaMonhoc = Convert.ToString(ddlFK_sMaMonhoc.SelectedValue); }
                catch { lblFK_sMaMonhoc.Text = Messages.Ma_Khong_Hop_Le; }
                try { _DiemThiEO.PK_iSolanhoc = Convert.ToInt16(txtPK_iSolanhoc.Text); }
                catch { lblPK_iSolanhoc.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _DiemThiEO.fDiemchuyencan = Convert.ToSingle(txtfDiemchuyencan.Text);}
                catch { lblfDiemchuyencan.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _DiemThiEO.fDiemgiuaky = Convert.ToSingle(txtfDiemgiuaky.Text);}
                catch { lblfDiemgiuaky.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                try { _DiemThiEO.fDiemthilan1 = Convert.ToSingle(txtfDiemthilan1.Text);}
                catch { lblfDiemthilan1.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _DiemThiEO.fDiemthilan2 = Convert.ToSingle(txtfDiemthilan2.Text);}
                catch { lblfDiemthilan2.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _DiemThiEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _DiemThiEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_sMaSV.DataSource = SinhVienDAO.SinhVien_SelectList();
            ddlFK_sMaSV.DataTextField = "sHotenSV";
            ddlFK_sMaSV.DataValueField = "PK_sMaSV";
            ddlFK_sMaSV.DataBind();

            ddlFK_sMaMonhoc.DataSource = MonHocDAO.MonHoc_SelectList();
            ddlFK_sMaMonhoc.DataTextField = "sTenMonhoc";
            ddlFK_sMaMonhoc.DataValueField = "PK_sMaMonhoc";
            ddlFK_sMaMonhoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.DiemThi_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }
    }
}