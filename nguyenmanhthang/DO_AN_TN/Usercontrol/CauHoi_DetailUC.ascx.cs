using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using Shared_Libraries;
using EntityObject;
using System.Data.SqlTypes;

namespace DO_AN_TN.UserControl
{
    public partial class CauHoi_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(CauHoiEO _CauHoiEO)
        {
            try { ddlFK_sMaGV.SelectedValue = Convert.ToString(_CauHoiEO.FK_sMaGV); }
            catch { ddlFK_sMaGV.SelectedIndex = 0; }
            txtPK_lCauhoi_ID.Text = Convert.ToString(_CauHoiEO.PK_lCauhoi_ID);
            txtsCauhoi_Cauhoi.Text = Convert.ToString(_CauHoiEO.sCauhoi_Cauhoi);
            txtsCauhoi_A.Text = Convert.ToString(_CauHoiEO.sCauhoi_A);
            txtsCauhoi_B.Text = Convert.ToString(_CauHoiEO.sCauhoi_B);
            txtsCauhoi_C.Text = Convert.ToString(_CauHoiEO.sCauhoi_C);
            txtsCauhoi_D.Text = Convert.ToString(_CauHoiEO.sCauhoi_D);
            try { ddliCauhoi_Dung.SelectedValue = Convert.ToString(_CauHoiEO.iCauhoi_Dung); }
            catch { ddliCauhoi_Dung.SelectedIndex = 0; }
            txtsBoCauHoi.Text = Convert.ToString(_CauHoiEO.sBoCauHoi);
            try { txttNgayTao.Text = Convert.ToString(_CauHoiEO.tNgayTao.ToShortDateString()); }
            catch { txttNgayTao.Text = ""; }
            try { txttNgayCapNhat.Text = Convert.ToString(_CauHoiEO.tNgayCapNhat.ToShortDateString()); }
            catch { txttNgayCapNhat.Text = ""; }
            try { ddliTrangThai.SelectedValue = _CauHoiEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private CauHoiEO getObject()
        {
            try
            {
                CauHoiEO _CauHoiEO = new CauHoiEO();
                try { _CauHoiEO.FK_sMaGV = Convert.ToString(ddlFK_sMaGV.SelectedValue); }
                catch { lblFK_sMaGV.Text = Messages.Ma_Khong_Hop_Le; }
                try { _CauHoiEO.PK_lCauhoi_ID = Convert.ToInt64(txtPK_lCauhoi_ID.Text); }
                catch { lblPK_lCauhoi_ID.Text = Messages.Khong_Dung_Dinh_Dang_So; _CauHoiEO.PK_lCauhoi_ID = 0; }
                _CauHoiEO.sCauhoi_Cauhoi = Convert.ToString(txtsCauhoi_Cauhoi.Text);
                _CauHoiEO.sCauhoi_A = Convert.ToString(txtsCauhoi_A.Text);
                _CauHoiEO.sCauhoi_B = Convert.ToString(txtsCauhoi_B.Text);
                _CauHoiEO.sCauhoi_C = Convert.ToString(txtsCauhoi_C.Text);
                _CauHoiEO.sCauhoi_D = Convert.ToString(txtsCauhoi_D.Text);
                try { _CauHoiEO.iCauhoi_Dung = Convert.ToInt16(ddliCauhoi_Dung.SelectedValue); }
                catch { lbliCauhoi_Dung.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                _CauHoiEO.sBoCauHoi = Convert.ToString(txtsBoCauHoi.Text);
                try{_CauHoiEO.tNgayTao = Convert.ToDateTime(txttNgayTao.Text);}
                catch{lbltNgayTao.Text = Messages.Khong_Dung_Dinh_Dang_Ngay;}
                try{_CauHoiEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text);}
                catch{lbltNgayCapNhat.Text = Messages.Khong_Dung_Dinh_Dang_Ngay;}
                try { _CauHoiEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _CauHoiEO;
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

            ddliTrangThai.DataSource = GetListConstants.CauHoi_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblFK_sMaGV.Text = "";
            lblPK_lCauhoi_ID.Text = "";
            lblsCauhoi_Cauhoi.Text = "";
            lblsCauhoi_A.Text = "";
            lblsCauhoi_B.Text = "";
            lblsCauhoi_C.Text = "";
            lblsCauhoi_D.Text = "";
            lbliCauhoi_Dung.Text = "";
            lblsBoCauHoi.Text = "";
            lbltNgayTao.Text = "";
            lbltNgayCapNhat.Text = "";
            lbliTrangThai.Text = "";
        }

#region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (CauHoiDAO.CauHoi_Insert(getObject()) == true)
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
                if (CauHoiDAO.CauHoi_Update(getObject()) == true)
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
                if (CauHoiDAO.CauHoi_Delete(getObject()) == true)
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
            CauHoiEO _CauHoiEO = new CauHoiEO();
            BindDataDetail(_CauHoiEO);
        }
#endregion;
    }
}