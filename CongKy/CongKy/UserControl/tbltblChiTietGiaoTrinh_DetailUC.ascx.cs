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
            txtPK_i.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.PK_iTaiKhoanID);
            txtsTenBaiHoc.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sTenDangNhap);
            txtsMatKhau.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sMatKhau);
            txtsHoTen.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sHoTen);
            txtsEmail.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sEmail);
            txtsDiaChi.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sDiaChi);
            txtsSoDienThoai.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sSoDienThoai);
            if (String.IsNullOrEmpty(_tblTaiKhoanEO.sLinkAvatar) == true) { txtsLinkAvatar.Text = "~/Images/Avatar/Default.jpg"; } else { txtsLinkAvatar.Text = Convert.ToString(_tblTaiKhoanEO.sLinkAvatar); }
            if (_tblTaiKhoanEO.tNgaySinh == DateTime.MinValue) { txttNgaySinh.Text = DateTime.Now.ToString(); } else { txttNgaySinh.Text = Convert.ToString(_tblTaiKhoanEO.tNgaySinh); }
            if (_tblTaiKhoanEO.tNgayDangKy == DateTime.MinValue) { txttNgayDangKy.Text = DateTime.Now.ToString(); } else { txttNgayDangKy.Text = Convert.ToString(_tblTaiKhoanEO.tNgayDangKy); }
            //txtsLinkAvatar.Text = Convert.ToString(_tblTaiKhoanEO.sLinkAvatar);
            //txttNgaySinh.Text = Convert.ToString(_tblTaiKhoanEO.tNgaySinh);
            //txttNgayDangKy.Text = Convert.ToString(_tblTaiKhoanEO.tNgayDangKy);
            try { ddliQuyenHan.SelectedValue = Convert.ToString(_tblTaiKhoanEO.iQuyenHan); }
            catch { ddliQuyenHan.SelectedIndex = 0; }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblTaiKhoanEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblChiTietGiaoTrinhEO getObject()
        {
            try
            {
                tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                _tblChiTietGiaoTrinhEO.PK_iChiTietGiaoTrinhID = Convert.ToInt16(txtPK_iChiTietGiaoTrinhID.Text);
                try { _tblChiTietGiaoTrinhEO.iNhomCon = Convert.ToInt16(ddliNhomCon.SelectedValue); }
                catch { lbliNhomCon.Text = Messages.Ma_Khong_Hop_Le; }
                _tblChiTietGiaoTrinhEO.sTenNhom = Convert.ToString(txtsTenNhom.Text);
                try { _tblChiTietGiaoTrinhEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblChiTietGiaoTrinhEO.iTrangThai = 0; }
                return _tblChiTietGiaoTrinhEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            DataSet ds = tblGiaoTrinhDAO.ChiTietGiaoTrinh_SelectList();
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = 0;
            dr[2] = "Không nằm trong nhóm con nào!";
            ds.Tables[0].Rows.Add(dr);

            ds.Tables[0].Rows.Add();
            ddliNhomCon.DataSource = ds;
            ddliNhomCon.DataTextField = "sTenNhom";
            ddliNhomCon.DataValueField = "PK_iChiTietGiaoTrinhID";
            ddliNhomCon.DataBind();

            ddliTrangThai.DataSource = GetListConstants.ChiTietGiaoTrinh_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
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