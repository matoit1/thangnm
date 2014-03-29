using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class BaiViet_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(BaiVietEO _BaiVietEO)
        {
            try { ddlFK_sMaGV.SelectedValue = Convert.ToString(_BaiVietEO.FK_sMaGV); }
            catch { ddlFK_sMaGV.SelectedIndex = 0; }
            txtPK_lMaBaiViet.Text = Convert.ToString(_BaiVietEO.PK_lMaBaiViet);
            txtsTieuDe.Text = Convert.ToString(_BaiVietEO.sTieuDe);
            txtsLinkAnh.Text = Convert.ToString(_BaiVietEO.sLinkAnh);
            txtsTag.Text = Convert.ToString(_BaiVietEO.sTag);
            txtsNoiDung.Text = Convert.ToString(_BaiVietEO.sNoiDung);
            txtiLuotXem.Text = Convert.ToString(_BaiVietEO.iLuotXem);
            try { txttNgayViet.Text = Convert.ToString(_BaiVietEO.tNgayViet.ToShortDateString()); }
            catch { txttNgayViet.Text = ""; }
            try { txttNgayCapNhat.Text = Convert.ToString(_BaiVietEO.tNgayCapNhat.ToShortDateString()); }
            catch { txttNgayCapNhat.Text = ""; }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_BaiVietEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private BaiVietEO getObject()
        {
            try
            {
                BaiVietEO _BaiVietEO = new BaiVietEO();
                try { _BaiVietEO.FK_sMaGV = Convert.ToString(ddlFK_sMaGV.SelectedValue); }
                catch { lblFK_sMaGV.Text = Messages.Ma_Khong_Hop_Le; }
                try { _BaiVietEO.PK_lMaBaiViet = Convert.ToInt64(txtPK_lMaBaiViet.Text); }
                catch { lblPK_lMaBaiViet.Text = Messages.Khong_Dung_Dinh_Dang_So; _BaiVietEO.PK_lMaBaiViet = 0; }
                _BaiVietEO.sTieuDe = Convert.ToString(txtsTieuDe.Text);
                _BaiVietEO.sLinkAnh = Convert.ToString(txtsLinkAnh.Text);
                _BaiVietEO.sTag = Convert.ToString(txtsTag.Text);
                _BaiVietEO.sNoiDung = Convert.ToString(txtsNoiDung.Text);
                try { _BaiVietEO.iLuotXem = Convert.ToInt16(txtiLuotXem.Text); }
                catch { lbliLuotXem.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try { _BaiVietEO.tNgayViet = Convert.ToDateTime(txttNgayViet.Text); }
                catch { lbltNgayViet.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                try { _BaiVietEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text); }
                catch { lbltNgayCapNhat.Text = Messages.Khong_Dung_Dinh_Dang_Ngay; }
                _BaiVietEO.sMoTa = Convert.ToString(txtsMoTa.Text);
                try { _BaiVietEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _BaiVietEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblFK_sMaGV.Text = "";
            lblPK_lMaBaiViet.Text = "";
            lblsTieuDe.Text = "";
            lblsLinkAnh.Text = "";
            lblsTag.Text = "";
            lblsNoiDung.Text = "";
            lbliLuotXem.Text = "";
            lbltNgayViet.Text = "";
            lbltNgayCapNhat.Text = "";
            lblsMoTa.Text = "";
            lbliTrangThai.Text = "";
        }

        public void loadDataToDropDownList()
        {
            ddlFK_sMaGV.DataSource = GiangVienDAO.GiangVien_SelectList();
            ddlFK_sMaGV.DataTextField = "sHoTenGV";
            ddlFK_sMaGV.DataValueField = "PK_sMaGV";
            ddlFK_sMaGV.DataBind();

            ddliTrangThai.DataSource = GetListConstants.BaiViet_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (BaiVietDAO.BaiViet_Insert(getObject()) == true)
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
                if (BaiVietDAO.BaiViet_Update(getObject()) == true)
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
                if (BaiVietDAO.BaiViet_Delete(getObject()) == true)
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
            BaiVietEO _BaiVietEO = new BaiVietEO();
            BindDataDetail(_BaiVietEO);
        }
        #endregion
    }
}