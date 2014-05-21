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
    public partial class tblChiTietHoaDon_DetailUC : System.Web.UI.UserControl
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

        public void BindDataDetail(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            try { ddlFK_lHoaDonID.SelectedValue = Convert.ToString(_tblChiTietHoaDonEO.FK_lHoaDonID); }
            catch { ddlFK_lHoaDonID.SelectedIndex = 0; }
            try { ddlFK_sSanPhamID.SelectedValue = Convert.ToString(_tblChiTietHoaDonEO.FK_sSanPhamID); }
            catch { ddlFK_sSanPhamID.SelectedIndex = 0; }
            txtlGiaBan.Text = Convert.ToString(_tblChiTietHoaDonEO.lGiaBan);
            txtiSoLuong.Text = Convert.ToString(_tblChiTietHoaDonEO.iSoLuong);
        }

        private tblChiTietHoaDonEO getObject()
        {
            try
            {
                tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
                try { _tblChiTietHoaDonEO.FK_lHoaDonID = Convert.ToInt64(ddlFK_lHoaDonID.SelectedValue); }
                catch { lblFK_lHoaDonID.Text = Messages.Ma_Khong_Hop_Le; }
                try { _tblChiTietHoaDonEO.FK_sSanPhamID = Convert.ToString(ddlFK_sSanPhamID.SelectedValue); }
                catch { lblFK_sSanPhamID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblChiTietHoaDonEO.FK_sSanPhamID = ""; }
                _tblChiTietHoaDonEO.lGiaBan = Convert.ToInt64(txtlGiaBan.Text);
                _tblChiTietHoaDonEO.iSoLuong = Convert.ToInt16(txtiSoLuong.Text);
                return _tblChiTietHoaDonEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_lHoaDonID.DataSource = tblHoaDonDAO.HoaDon_SelectList();
            ddlFK_lHoaDonID.DataTextField = "PK_lHoaDonID";
            ddlFK_lHoaDonID.DataValueField = "PK_lHoaDonID";
            ddlFK_lHoaDonID.DataBind();

            ddlFK_sSanPhamID.DataSource = tblSanPhamDAO.SanPham_SelectList();
            ddlFK_sSanPhamID.DataTextField = "sTenSanPham";
            ddlFK_sSanPhamID.DataValueField = "PK_sSanPhamID";
            ddlFK_sSanPhamID.DataBind();
        }

        public bool CheckInput()
        {
            Int64 num64;
            Int16 num16;
            if (string.IsNullOrEmpty(txtlGiaBan.Text) == true)
            {
                lbllGiaBan.Text = Messages.Khong_Duoc_De_Trong;
                txtlGiaBan.Focus();
                return false;
            }
            else
            {
                bool isNum = Int64.TryParse(txtlGiaBan.Text, out num64);
                if (isNum == false)
                {
                    lbllGiaBan.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtlGiaBan.Focus();
                    return false;
                }

            }
            if (string.IsNullOrEmpty(txtiSoLuong.Text) == true)
            {
                lbliSoLuong.Text = Messages.Khong_Duoc_De_Trong;
                txtiSoLuong.Focus();
                return false;
            }
            else
            {
                bool isNum = Int16.TryParse(txtiSoLuong.Text, out num16);
                if (isNum == false)
                {
                    lbliSoLuong.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtiSoLuong.Focus();
                    return false;
                }

            }
            return true;
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblFK_lHoaDonID.Text = "";
            lblFK_sSanPhamID.Text = "";
            lbllGiaBan.Text = "";
            lbliSoLuong.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
              if (CheckInput() == true)
               {
                if (tblChiTietHoaDonDAO.ChiTietHoaDon_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Them_That_Bai;
                }
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
              if (CheckInput() == true)
               {
                if (tblChiTietHoaDonDAO.ChiTietHoaDon_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
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
                if (tblChiTietHoaDonDAO.ChiTietHoaDon_Delete(getObject()) == true)
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
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            BindDataDetail(_tblChiTietHoaDonEO);
        }
        #endregion
    }
}