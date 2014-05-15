﻿using System;
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

                            tblMessageEO _tblMessageEO = new tblMessageEO();
                            _tblMessageEO.FK_sRoom = _tblSubjectEO.PK_sSubject;
                            _tblMessageEO.FK_sUsername = _tblSubjectEO.FK_sTeacher;
                            _tblMessageEO.iStatus = 1;
                            ChatUC1.objtblMessageEO = _tblMessageEO;
                            ChatUC1.objtblSubjectEO = _tblSubjectEO;
                            ChatUC1.iTypeUser = Messages.ChatRoom_TypeUser_GiangVien;

                            //SinhVienEO _SinhVienEO = new SinhVienEO();
                            //_SinhVienEO.FK_sMaLop = _tblSubjectEO.PK_sSubject;
                            //DanhSachLopHocUC1.BindData(_SinhVienEO);

                            //Kiểm tra trạng thái buổi học Online / Offline
                            switch (_tblSubjectEO.iStatus)
                            {
                                case LichDayVaHoc_iTrangThai_C.Hoc: vLiveStream.ActiveViewIndex = 0;
                                                                            UploadFileUC1.Visible = true; 
                                                                            UploadFileUC2.Visible = true; break;
                                case LichDayVaHoc_iTrangThai_C.Day_Offline: vLiveStream.ActiveViewIndex = 1;
                                                                            VideoUC1.sLinkVideo = _tblSubjectEO.sLinkVideo;
                                                                            UploadFileUC1.Visible = true;
                                                                            UploadFileUC2.Visible = true; break;
                                case LichDayVaHoc_iTrangThai_C.Hoc_Bu: vLiveStream.ActiveViewIndex = 0;
                                                                            UploadFileUC1.Visible = true; 
                                                                            UploadFileUC2.Visible = true; break;
                                case LichDayVaHoc_iTrangThai_C.Nghi: vLiveStream.ActiveViewIndex = 2;
                                                                            lblNotify.Text = Messages.Buoi_Hoc_Hom_Nay_Duoc_Nghi;
                                                                            UploadFileUC1.Visible = false; 
                                                                            UploadFileUC2.Visible = false; break;
                                default: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Chua_Den_Thoi_Gian_Hoc; break;
                            }
                            Thong_Tin_Lop_HocUC1.BinData(_tblSubjectEO);
                    }
                }
                LoadInfo();
            }
            catch(Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void LoadInfo(){
            try
            {
                UploadFileUC1.sTendangnhapGV = Session["account_gv"].ToString();
                UploadFileUC1.sTypeUpload = Messages.Ebook;
                UploadFileUC1.lblTitle.Text = Messages.Upload_Hoc_Lieu;

                UploadFileUC2.sTendangnhapGV = Session["account_gv"].ToString();
                UploadFileUC2.sTypeUpload = Messages.Video;
                UploadFileUC2.lblTitle.Text = Messages.UpLoad_Video_Giang_Day;
                Hoc_LieuUC1.BindData_HocLieu(Session["account_gv"].ToString());
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void Refresh1_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        protected void Refresh2_Click(object sender, EventArgs e)
        {
            LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
            _LichDayVaHocEO.FK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
            _LichDayVaHocEO.FK_sMalop = Request.QueryString["PK_sMalop"];
            _LichDayVaHocEO.iCaHoc = Convert.ToInt16(Request.QueryString["iCaHoc"]);
            _LichDayVaHocEO.sLinkVideo = UploadFileUC2.linkfilevideo.Substring(1);
            LichDayVaHocDAO.LichDayVaHoc_Update_sSinhVienNghi_sSinhVienChan_sLinkVideo(_LichDayVaHocEO);
            Response.Redirect(Request.Url.ToString());
        }
    }
}