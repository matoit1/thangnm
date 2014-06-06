using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using Shared_Libraries;
using Shared_Libraries.Constants;

namespace EHOU
{
    public partial class Preview : System.Web.UI.Page
    {
        #region "Properties & Event"
        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }

        private Int32 _PK_iMonHocID;
        public Int32 PK_iMonHocID
        {
            get { return this._PK_iMonHocID; }
            set { _PK_iMonHocID = value; }
        }

        private Int32 _PK_iGiaoTrinhID;
        public Int32 PK_iGiaoTrinhID
        {
            get { return this._PK_iGiaoTrinhID; }
            set { _PK_iGiaoTrinhID = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                //if (Request.Cookies["CongKy_sinhvien"] != null)
                //{
                //    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_sinhvien"].Value;
                //}
                //else
                //{
                //    if (Request.Cookies["CongKy_giangvien"] != null)
                //    {
                //        _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_giangvien"].Value;
                //    }
                //    else
                //    {
                //        if (Request.Cookies["CongKy_quantri"] != null)
                //        {
                //            _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_quantri"].Value;
                //        }
                //    }
                //}
                //if (_tblTaiKhoanEO.sTenDangNhap == null)
                //{
                //    Response.Redirect("~/Loi.aspx?Type=" + ERROR_C.Chua_Dang_Nhap);
                //}
                //else
                //{
                //    _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                //    PK_iTaiKhoanID = _tblTaiKhoanEO.PK_iTaiKhoanID;
                //}
                if (Request.QueryString["PK_lMaterial"] != null)
                {
                    tblMaterialEO _tblMaterialEO = new tblMaterialEO();
                    _tblMaterialEO.PK_lMaterial = Convert.ToInt64(Request.QueryString["PK_lMaterial"]);
                    _tblMaterialEO = tblMaterialDAO.Material_SelectItem(_tblMaterialEO);
                    BindData(_tblMaterialEO);
                    CheckTypeFile(_tblMaterialEO.iType, _tblMaterialEO.sLinkDownload);

                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        public void CheckTypeFile(Int16 type, string sLinkDownload)
        {
            switch (type)
            {
                case tblMaterial_iType_C.Video:
                    pnlPdf.Visible = false;
                    pnlVideo.Visible = true;
                    VideoUC1.sLinkVideo = sLinkDownload;
                    break;
                case tblMaterial_iType_C.Pdf:
                    pnlPdf.Visible = true;
                    pnlVideo.Visible = false;
                    PdfUC1.sLinkEbook = sLinkDownload;
                    break;
                default: lblMsg.Text = Messages.Dinh_Dang_File_Khong_Ho_Tro_Xem_Truoc;
                    pnlPdf.Visible = false;
                    pnlVideo.Visible = false;
                    break;
            }
        }

        public void BindData(tblMaterialEO _tblMaterialEO)
        {
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            tblAccountEO _tblAccountEO = new tblAccountEO();

            _tblSubjectEO.PK_sSubject = _tblMaterialEO.FK_sSubject;
            _tblAccountEO.PK_sUsername = _tblMaterialEO.FK_sUsername;

            _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(_tblSubjectEO);
            _tblAccountEO = tblAccountDAO.Account_SelectItem(_tblAccountEO);

            lblPK_lMaterial.Text = _tblMaterialEO.PK_lMaterial.ToString();
            lblFK_sSubject.Text = _tblSubjectEO.sName;
            lblFK_sUsername.Text = _tblAccountEO.sName + " - " + _tblAccountEO.PK_sUsername;
            lblsDescription.Text = _tblMaterialEO.sDescription;
            lbltLastUpdate.Text = _tblMaterialEO.tLastUpdate.ToString();
            lbliSize.Text = _tblMaterialEO.iSize.ToString() + " (Bytes)";
            lbliType.Text = GetTextConstants.tblMaterial_iType_GTC(_tblMaterialEO.iType);
            lbliStatus.Text = GetTextConstants.tblMessage_iStatus_GTC(_tblMaterialEO.iStatus);
            hplsLinkDownload.NavigateUrl ="DownloadFile.ashx?PK_lMaterial=" + _tblMaterialEO.PK_lMaterial;
        }

    }
}