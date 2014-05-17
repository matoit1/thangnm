using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;

namespace HaBa.UserControl
{
    public partial class tblNhomSanPham_DetailUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public Int16 iType
        {
            get { return (Int16)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            txtPK_iNhomSanPhamID.Text = Convert.ToString(_tblNhomSanPhamEO.PK_iNhomSanPhamID);
            try { ddliNhomCon.SelectedValue = Convert.ToString(_tblNhomSanPhamEO.iNhomCon); }
            catch { ddliNhomCon.SelectedIndex = 0; }
            txtsTenNhom.Text = Convert.ToString(_tblNhomSanPhamEO.sTenNhom);
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblNhomSanPhamEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblNhomSanPhamEO getObject()
        {
            try
            {
                tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
                _tblNhomSanPhamEO.PK_iNhomSanPhamID = Convert.ToInt16(txtPK_iNhomSanPhamID.Text);
                try { _tblNhomSanPhamEO.iNhomCon = Convert.ToInt16(ddliNhomCon.SelectedValue); }
                catch { lbliNhomCon.Text = Messages.Ma_Khong_Hop_Le; }
                _tblNhomSanPhamEO.sTenNhom = Convert.ToString(txtsTenNhom.Text);
                try { _tblNhomSanPhamEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblNhomSanPhamEO.iTrangThai = 0; }
                return _tblNhomSanPhamEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliNhomCon.DataSource = tblHoaDonDAO.HoaDon_SelectList();
            ddliNhomCon.DataTextField = "FK_iTaiKhoanID_Nhan";
            ddliNhomCon.DataValueField = "PK_lHoaDonID";
            ddliNhomCon.DataBind();

            ddliTrangThai.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddliTrangThai.DataTextField = "sTenSanPham";
            ddliTrangThai.DataValueField = "PK_lSanPhamID";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_iNhomSanPhamID.Text = "";
            lbliNhomCon.Text = "";
            lblsTenNhom.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblNhomSanPhamDAO.NhomSanPham_Insert(getObject()) == true)
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
                if (tblNhomSanPhamDAO.NhomSanPham_Update(getObject()) == true)
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
                if (tblNhomSanPhamDAO.NhomSanPham_Delete(getObject()) == true)
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
            tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
            BindDataDetail(_tblNhomSanPhamEO);
        }
        #endregion
    }
}