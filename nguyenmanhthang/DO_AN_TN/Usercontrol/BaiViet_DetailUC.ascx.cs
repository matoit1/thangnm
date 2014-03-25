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
            ddlFK_sMaGV.SelectedValue = _BaiVietEO.FK_sMaGV;
            txtPK_lMaBaiViet.Text = Convert.ToString(_BaiVietEO.PK_lMaBaiViet);
            txtsTieuDe.Text = _BaiVietEO.sTieuDe;
            txtsLinkAnh.Text = _BaiVietEO.sLinkAnh;
            txtsTag.Text = _BaiVietEO.sTag;
            txtsNoiDung.Text = _BaiVietEO.sNoiDung;
            txtiLuotXem.Text = Convert.ToString(_BaiVietEO.iLuotXem);
            txttNgayViet.Text = Convert.ToString(_BaiVietEO.tNgayViet);
            try { txttNgayCapNhat.Text = Convert.ToString(_BaiVietEO.tNgayCapNhat); }
            catch { txttNgayCapNhat.Text = ""; }
            try { ddliTrangThai.SelectedValue = _BaiVietEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
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
            BaiVietEO _BaiVietEO = new BaiVietEO();
            BindDataDetail(_BaiVietEO);
        }
        #endregion

        private BaiVietEO getObject()
        {
            try
            {
                BaiVietEO _BaiVietEO = new BaiVietEO();
                _BaiVietEO.FK_sMaGV = ddlFK_sMaGV.SelectedValue;
                _BaiVietEO.PK_lMaBaiViet = Convert.ToInt64(txtPK_lMaBaiViet.Text);
                _BaiVietEO.sTieuDe = txtsTieuDe.Text;
                _BaiVietEO.sLinkAnh = txtsLinkAnh.Text;
                _BaiVietEO.sTag = txtsTag.Text;
                _BaiVietEO.sNoiDung = txtsNoiDung.Text;
                _BaiVietEO.iLuotXem = Convert.ToInt16(txtiLuotXem.Text);
                _BaiVietEO.tNgayViet = Convert.ToDateTime(txttNgayViet.Text);
                _BaiVietEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text);
                _BaiVietEO.sMoTa = txtsMoTa.Text;
                _BaiVietEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                return _BaiVietEO;
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

            ddliTrangThai.DataSource = GetListConstants.BaiViet_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }
    }
}