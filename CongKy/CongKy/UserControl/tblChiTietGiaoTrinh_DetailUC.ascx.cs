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
using CongKy.SharedLibraries.Constants;
using System.IO;

namespace CongKy.UserControl
{
    public partial class tblChiTietGiaoTrinh_DetailUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public Int16 _iType;
        public Int16 iType
        {
            get { return this._iType; }
            set { _iType = value; }
        }

        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }

        private string _LinkDownload;
        public string LinkDownload
        {
            get { return this._LinkDownload; }
            set { _LinkDownload = value; }
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

        public void BindDataDetail(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO, tblMonHocEO _tblMonHocEO)
        {
            txtPK_iGiaoTrinhID.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID);
            try { ddlFK_iMonHocID.SelectedValue = Convert.ToString(_tblMonHocEO.PK_iMonHocID); }
            catch { ddlFK_iMonHocID.SelectedIndex = 0; }
            txtsTenBaiHoc.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sTenBaiHoc);
            txtsThongTin.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sThongTin);
            //txtsLinkDownload.Text = Convert.ToString(_tblChiTietGiaoTrinhEO.sLinkDownload);
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
                _tblChiTietGiaoTrinhEO.sLinkDownload = LinkDownload;
                
                //try { _tblChiTietGiaoTrinhEO.iType = Convert.ToInt16(ddliType.SelectedValue); }
                //catch { lbliType.Text = Messages.Khong_Dung_Dinh_Dang_So; }
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
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            _tblMonHocEO.iTrangThai = MonHoc_iTrangThai_C.Mo;
            _tblTaiKhoanEO.PK_iTaiKhoanID = PK_iTaiKhoanID;
            ddlFK_iMonHocID.DataSource = tblMonHocDAO.MonHoc_SelectListByFK_iTaiKhoanID(_tblMonHocEO, _tblTaiKhoanEO); ;
            ddlFK_iMonHocID.DataTextField = "sTenMonHoc";
            ddlFK_iMonHocID.DataValueField = "PK_iMonHocID";
            ddlFK_iMonHocID.DataBind();

            ddliType.DataSource = GetListConstants.ChiTietGiaoTrinh_iType_GLC();
            ddliType.DataTextField = "Value";
            ddliType.DataValueField = "Key";
            ddliType.DataBind();

            ddliTrangThai.DataSource = GetListConstants.ChiTietGiaoTrinh_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtsTenBaiHoc.Text) == true)
            {
                lblsTenBaiHoc.Text = Messages.Khong_Duoc_De_Trong;
                txtsTenBaiHoc.Focus();
                return false;
            }
            return true;
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_iGiaoTrinhID.Text = "";
            lblsTenBaiHoc.Text = "";
            lblsThongTin.Text = "";
            lbliType.Text = "";
            lbltNgayCapNhat.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (UploadFile() == true)
            {
                tblMonHocEO _tblMonHocEO = new tblMonHocEO();
                _tblMonHocEO.PK_iMonHocID = Convert.ToInt32(ddlFK_iMonHocID.SelectedValue);
                ClearMessages();
                lblMsg.Text = "";
                try
                {
                    if (CheckInput() == true)
                    {
                        if (tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_Insert(getObject(), _tblMonHocEO) == true)
                        {
                            lblMsg.Text = Messages.Them_Thanh_Cong;
                            ClearMessages();
                            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                            _tblMonHocEO = new tblMonHocEO();
                            BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
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
            else
            {
                lblMsg.Text = Messages.Tai_Len_That_Bai;
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
                   if (tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_Update(getObject()) == true)
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
                    if (tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_Delete(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Xoa_Thanh_Cong;
                        ClearMessages();
                        tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                        tblMonHocEO _tblMonHocEO = new tblMonHocEO();
                        BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
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
            lblMsg.Text = "";
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
        }
        #endregion

        public void Permit_Access()
        {
            txtPK_iGiaoTrinhID.Visible = false;
            lblPK_iGiaoTrinhID.Visible = false;
            lblPK_iGiaoTrinhID_Title.Visible = false;

            ddliType.Visible = false;
            lbliType.Visible = false;
            lbliType_Title.Visible = false;

            txttNgayCapNhat.Visible = false;
            lbltNgayCapNhat.Visible = false;
            lbltNgayCapNhat_Title.Visible = false;

            ddliTrangThai.Visible = false;
            lbliTrangThai.Visible = false;
            lbliTrangThai_Title.Visible = false;

            btnInsert.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnReset.Visible = false;
        }

        protected bool UploadFile()
        {
            string sPath = "../Upload/";
            try
            {
                string RootUpload = Server.MapPath("~/Upload/");
                switch (checktypefile(fuFile.PostedFile.FileName))
                {
                    case ChiTietGiaoTrinh_iType_C.Video: sPath = sPath + "Video/"; RootUpload = RootUpload + "Video/"; break;
                    case ChiTietGiaoTrinh_iType_C.Pdf: sPath = sPath + "Ebook/"; RootUpload = RootUpload + "Ebook/"; break;
                    default: sPath = sPath + "Other/"; RootUpload = RootUpload + "Other/"; break;
                }
                sPath = sPath + fuFile.PostedFile.FileName;
                fuFile.PostedFile.SaveAs( RootUpload + fuFile.PostedFile.FileName);
                LinkDownload = sPath;
                return true;
            }
            catch { return false; }
        }

        public Int16 checktypefile(string filename)
        {
            Int16 output=0;
            switch (Path.GetExtension(filename.ToUpper()))
            {
                case ".FLV":
                case ".MP4":
                case ".OGG":
                case ".WEBM":
                case ".F4V":
                case ".MKV":
                case ".AVI":
                case ".3G2":
                case ".MOV":
                case ".MPG":
                case ".WMV": output = ChiTietGiaoTrinh_iType_C.Video; break;
                case ".PDF": output = ChiTietGiaoTrinh_iType_C.Pdf; break;
                default: output = ChiTietGiaoTrinh_iType_C.Other; break;
            }
            iType = output;
            return output;
        }
    }
}