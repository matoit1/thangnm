using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;
using Shared_Libraries.Constants;

namespace EHOU.GiangVien
{
    public partial class GiangDay : System.Web.UI.Page
    {
        #region "Properties & Event"
        public Int16 current
        {
            get { return (Int16)ViewState["current"]; }
            set { ViewState["current"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_sSubject"] != null)
                    {
                        //LopHocEO _LopHocEO = new LopHocEO();
                    //        _LopHocEO.PK_sMalop = Request.QueryString["PK_sMalop"];
                    //        _LopHocEO = LopHocDAO.LopHoc_SelectItem(_LopHocEO);

                    //        PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                    //        _PhanCongCongTacEO.PK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                    //        _PhanCongCongTacEO = PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO);

                    //        GiangVienEO _GiangVienEO = new GiangVienEO();
                    //        _GiangVienEO.PK_sMaGV = _PhanCongCongTacEO.FK_sMaGV;
                    //        _GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);

                        tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                        _tblSubjectEO.PK_sSubject = Request.QueryString["PK_sSubject"];
                        _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(_tblSubjectEO);
                        if (Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString() != _tblSubjectEO.FK_sTeacher)
                        {
                            Response.Redirect("~/Access_Denied.aspx");
                        }

                            tblMessageEO _tblMessageEO = new tblMessageEO();
                            _tblMessageEO.FK_sRoom = _tblSubjectEO.PK_sSubject;
                            _tblMessageEO.FK_sUsername = _tblSubjectEO.FK_sTeacher;
                            _tblMessageEO.iStatus = 1;


                            tblPartEO _tblPartEO = new tblPartEO();
                            _tblPartEO.PK_iPart = Convert.ToInt16(Request.QueryString["PK_iPart"]);
                            _tblPartEO.FK_sSubject = _tblSubjectEO.PK_sSubject;
                            _tblPartEO = tblPartDAO.Part_SelectItem(_tblPartEO);

                            ChatUC1.objtblMessageEO = _tblMessageEO;
                            ChatUC1.objtblPartEO = _tblPartEO;
                            ChatUC1.iTypeUser = tblAccount_iType_C.Giang_Vien;

                            tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
                            _tblSubject_StudentEO.FK_sSubject = _tblSubjectEO.PK_sSubject;
                            DanhSachLopHocUC1.BindData(_tblSubject_StudentEO);

                            //Kiểm tra trạng thái buổi học Online / Offline
                            switch (_tblPartEO.iStatus)
                            {
                                case tblPart_iStatus_C.Hoc: vLiveStream.ActiveViewIndex = 0;
                                                                            UploadFileUC1.Visible = true; 
                                                                            UploadFileUC2.Visible = true; break;
                                case tblPart_iStatus_C.Day_Offline: vLiveStream.ActiveViewIndex = 1;
                                                                            VideoUC1.sLinkVideo = _tblPartEO.sLinkVideo;
                                                                            UploadFileUC1.Visible = true;
                                                                            UploadFileUC2.Visible = true; break;
                                case tblPart_iStatus_C.Hoc_Bu: vLiveStream.ActiveViewIndex = 0;
                                                                            UploadFileUC1.Visible = true; 
                                                                            UploadFileUC2.Visible = true; break;
                                case tblPart_iStatus_C.Nghi: vLiveStream.ActiveViewIndex = 2;
                                                                            lblNotify.Text = Messages.Buoi_Hoc_Hom_Nay_Duoc_Nghi;
                                                                            UploadFileUC1.Visible = false; 
                                                                            UploadFileUC2.Visible = false; break;
                                default: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Chua_Den_Thoi_Gian_Hoc; break;
                            }
                            Thong_Tin_Lop_HocUC1.BinData(_tblSubjectEO, _tblPartEO);
                            LoadInfo(_tblSubjectEO, _tblPartEO);
                    }
                }
            }
            catch(Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void LoadInfo(tblSubjectEO _tblSubjectEO, tblPartEO _tblPartEO)
        {
            try
            {
                UploadFileUC1.objtblSubjectEO = _tblSubjectEO;
                UploadFileUC1.objtblPartEO = _tblPartEO;
                UploadFileUC1.iTypeUpload = 1;
                UploadFileUC1.lblTitle.Text = Messages.Upload_Hoc_Lieu;

                UploadFileUC2.objtblSubjectEO = _tblSubjectEO;
                UploadFileUC2.objtblPartEO = _tblPartEO;
                UploadFileUC2.iTypeUpload = 2;
                UploadFileUC2.lblTitle.Text = Messages.UpLoad_Video_Giang_Day;

                Hoc_LieuUC1.BindData_HocLieu(_tblSubjectEO.PK_sSubject);
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void Refresh1_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.ToString());
        }

        protected void Refresh2_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.ToString());
        }
    }
}