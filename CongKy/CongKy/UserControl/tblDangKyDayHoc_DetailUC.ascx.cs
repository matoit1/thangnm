using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.DataAccessObject;
using CongKy.SharedLibraries;

namespace CongKy.UserControl
{
    public partial class tblDangKyDayHoc_DetailUC : System.Web.UI.UserControl
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
            //loadCKEditor();
        }

        public void BindDataDetail(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            txtFK_iTaiKhoanID.Text = Convert.ToString(_tblDangKyDayHocEO.FK_iTaiKhoanID);
            txtFK_iMonHocID.Text = Convert.ToString(_tblDangKyDayHocEO.FK_iMonHocID);
            if (_tblDangKyDayHocEO.tNgayDangKy == DateTime.MinValue) { txttNgayDangKy.Text = DateTime.Now.ToString(); } else { txttNgayDangKy.Text = Convert.ToString(_tblDangKyDayHocEO.tNgayDangKy); }
            try { ddliTrangThai.SelectedValue = Convert.ToString(_tblDangKyDayHocEO.iTrangThai); }
            catch { ddliTrangThai.SelectedIndex = 0; }
            
        }

        private tblDangKyDayHocEO getObject()
        {
            try
            {
                tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
                try { _tblDangKyDayHocEO.FK_iTaiKhoanID = Convert.ToInt32(txtFK_iTaiKhoanID.Text); }
                catch { lblFK_iTaiKhoanID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblDangKyDayHocEO.FK_iTaiKhoanID = 0; }
                try { _tblDangKyDayHocEO.FK_iMonHocID = Convert.ToInt32(txtFK_iMonHocID.Text); }
                catch { lblFK_iMonHocID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblDangKyDayHocEO.FK_iMonHocID = 0; }
                _tblDangKyDayHocEO.tNgayDangKy = Convert.ToDateTime(txttNgayDangKy.Text);
                try { _tblDangKyDayHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblDangKyDayHocEO.iTrangThai = 0; }
                return _tblDangKyDayHocEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliTrangThai.DataSource = GetListConstants.DangKyDayHoc_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }


        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblFK_iTaiKhoanID.Text = "";
            lblFK_iMonHocID.Text = "";
            lbltNgayDangKy.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblDangKyDayHocDAO.DangKyDayHoc_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                    ClearMessages();
                    tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
                    BindDataDetail(_tblDangKyDayHocEO);
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
            lblMsg.Text = "";
            try
            {
              
                if (tblDangKyDayHocDAO.DangKyDayHoc_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                    ClearMessages();
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
            lblMsg.Text = "";
            try
            {
                //tblChiTietGiaoTrinhEO _tblChiTietHoaDonEO = new tblChiTietGiaoTrinhEO();
                //_tblChiTietHoaDonEO.FK_sSanPhamID = getObject().PK_sSanPhamID;
                //if (tblChiTietGiaoTrinhDAO.ChiTietHoaDon_CheckExists_FK_sSanPhamID(_tblChiTietHoaDonEO) == false)
                //{
                    if (tblDangKyDayHocDAO.DangKyDayHoc_Delete(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Xoa_Thanh_Cong;
                        ClearMessages();
                        tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
                        BindDataDetail(_tblDangKyDayHocEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Xoa_That_Bai;
                    }
                }
            //    else
            //    {
            //        lblMsg.Text = Messages.Ma_San_Pham_Da_Dung_Trong_Chi_Tiet_Hoa_Don;
            //    }
            //}
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
            BindDataDetail(_tblDangKyDayHocEO);
        }
        #endregion

        #region "Config CKEditor"
        //protected void loadCKEditor()
        //{
        //    txtsThongTin.config.toolbar = new object[] { 
        //      new object[] { "Save", "NewPage", "Preview", "-", "Templates" },
        //        new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt" },
        //        new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
			
        //        "/",
        //        new object[] { "Bold", "Italic", "Underline", "Strike" },
        //        new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv" },
        //        new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
        //        new object[] { "BidiLtr", "BidiRtl" },
        //        new object[] { "Link", "Unlink", "Anchor" },
        //        new object[] { "Image"},
        //        "/"
        //    };
        //}
        #endregion
    }
}