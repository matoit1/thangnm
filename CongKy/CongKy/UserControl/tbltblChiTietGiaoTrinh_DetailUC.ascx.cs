using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.SharedLibraries;
using CongKy.DataAccessObject;
using System.Data;

namespace CongKy.UserControl
{
    public partial class tblChiTietGiaoTrinh_DetailUC : System.Web.UI.UserControl
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

        public void BindDataDetail(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            txtPK_iGiaoTrinhID.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID);
            txtsTenBaiHoc.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sTenBaiHoc);
            txtsThongTin.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sThongTin);
            txtsLinkDownload.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sLinkDownload);
            try { ddliType.SelectedValue = Convert.ToString(_tblChiTietGiaoTrinhEO.iType); }
            catch { ddliType.SelectedIndex = 0; }
            if (_tblChiTietGiaoTrinhEO.tNgayCapNhat == DateTime.MinValue) { txttNgayCapNhat.Text = DateTime.Now.ToString(); } else { txttNgayCapNhat.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.tNgayCapNhat); }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblChiTietGiaoTrinhEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblChiTietGiaoTrinhEO getObject()
        {
            try
            {
                tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                try { _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID = Convert.ToInt32(txtPK_iGiaoTrinhID.Text); }
                catch { lblPK_iGiaoTrinhID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID = 0; }
                _tblChiTietGiaoTrinhEO.sTenBaiHoc = Convert.ToString(txtsTenBaiHoc.Text);
                _tblChiTietGiaoTrinhEO.sThongTin = Convert.ToString(txtsThongTin.Text);
                _tblChiTietGiaoTrinhEO.sLinkDownload = Convert.ToString(txtsLinkDownload.Text);
                try { _tblChiTietGiaoTrinhEO.iType = Convert.ToInt16(ddliType.SelectedValue); }
                catch { lbliType.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                _tblChiTietGiaoTrinhEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text);
                try { _tblChiTietGiaoTrinhEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _tblChiTietGiaoTrinhEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliType.DataSource = GetListConstants.ChiTietGiaoTrinh_iType_GLC();
            ddliType.DataTextField = "Values";
            ddliType.DataValueField = "Values";
            ddliType.DataBind();

            ddliTrangThai.DataSource = GetListConstants.ChiTietGiaoTrinh_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Values";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtsTenNhom.Text) == true)
            {
                lblsTenNhom.Text = Messages.Khong_Duoc_De_Trong;
                txtsTenNhom.Focus();
                return false;
            }
            return true;
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_iChiTietGiaoTrinhID.Text = "";
            lbliNhomCon.Text = "";
            lblsTenNhom.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
              if (CheckInput() == true)
               {
                if (tblGiaoTrinhDAO.ChiTietGiaoTrinh_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                    ClearMessages();
                    tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                    BindDataDetail(_tblChiTietGiaoTrinhEO);
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
            lblMsg.Text = "";
            try
            {
              if (CheckInput() == true)
               {
                if (tblGiaoTrinhDAO.ChiTietGiaoTrinh_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                    ClearMessages();
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
            lblMsg.Text = "";
            try
            {
                tblMonHocEO _tblSanPhamEO = new tblMonHocEO();
                _tblSanPhamEO.FK_iChiTietGiaoTrinhID = getObject().PK_iChiTietGiaoTrinhID;
                if (tblMonHocDAO.SanPham_CheckExists_FK_iChiTietGiaoTrinhID(_tblSanPhamEO) == false)
                {
                    if (tblGiaoTrinhDAO.ChiTietGiaoTrinh_Delete(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Xoa_Thanh_Cong;
                        ClearMessages();
                        tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                        BindDataDetail(_tblChiTietGiaoTrinhEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Xoa_That_Bai;
                    }
                }
                else
                {
                    lblMsg.Text = Messages.Ma_Nhom_San_Pham_Da_Dung_Trong_San_Pham;
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
            lblMsg.Text = "";
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            BindDataDetail(_tblChiTietGiaoTrinhEO);
        }
        #endregion
    }
}