using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using Shared_Libraries.Constants;
using Shared_Libraries;

namespace EHOU.SinhVien
{
    public partial class HocTap : System.Web.UI.Page
    {
        #region "Properties & Event"
        public string sTendangnhapGV
        {
            get { return (string)ViewState["sTendangnhapGV"]; }
            set { ViewState["sTendangnhapGV"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Hoc_LieuUC1.btnDelete.Visible = false;
                Hoc_LieuUC1.btnPermit.Visible = false;
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_sSubject"] != null && Request.QueryString["lCaHoc"] != null)
                    {
                        //LopHocEO _LopHocEO = new LopHocEO();
                        //_LopHocEO.PK_sMalop = Request.QueryString["PK_sMalop"];
                        //_LopHocEO = LopHocDAO.LopHoc_SelectItem(_LopHocEO);

                        //PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                        //_PhanCongCongTacEO.PK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                        //_PhanCongCongTacEO = PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO);

                        //GiangVienEO _GiangVienEO = new GiangVienEO();
                        //_GiangVienEO.PK_sMaGV = _PhanCongCongTacEO.FK_sMaGV;
                        //_GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);

                        tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                        _tblSubjectEO.PK_sSubject = Request.QueryString["PK_sSubject"];
                        _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(_tblSubjectEO);
                        sTendangnhapGV = _tblSubjectEO.FK_sTeacher;

                        tblDetailEO _tblDetailEO = new tblDetailEO();
                        _tblDetailEO.FK_sSubject = _tblSubjectEO.PK_sSubject;
                        _tblDetailEO.FK_sStudent = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString();
                        _tblDetailEO.PK_lCaHoc = Convert.ToInt64(Request.QueryString["lCaHoc"].ToString());
                        if (tblDetailDAO.Detail_CheckExists(_tblDetailEO) !=true)
                        {
                            Response.Redirect("~/Access_Denied.aspx");
                        }
                        //SinhVienEO _SinhVienEO = new SinhVienEO();
                        //_SinhVienEO.sTendangnhapSV = Request.Cookies["sinhvien"].Value;
                        //_SinhVienEO = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO);
                        tblMessageEO _tblMessageEO = new tblMessageEO();
                        _tblMessageEO.FK_sRoom = _tblSubjectEO.PK_sSubject;
                        _tblMessageEO.FK_sUsername = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString();
                        _tblMessageEO.iStatus = 1;
                        ChatUC1.objtblMessageEO = _tblMessageEO;
                        ChatUC1.objtblSubjectEO = _tblSubjectEO;
                        ChatUC1.iTypeUser = Messages.ChatRoom_TypeUser_SinhVien;

                        //sTendangnhapGV = _GiangVienEO.sTendangnhapGV;
                        Hoc_LieuUC1.BindData_HocLieu(_tblSubjectEO.FK_sTeacher);

                        //DanhSachLopHocUC1.BindData(_SinhVienEO);

                        //Kiểm tra trạng thái buổi học Online / Offline
                        switch (_tblSubjectEO.iStatus)
                        {
                            case LichDayVaHoc_iTrangThai_C.Hoc: vLiveStream.ActiveViewIndex =0; break;
                            case LichDayVaHoc_iTrangThai_C.Day_Offline: vLiveStream.ActiveViewIndex = 1; VideoUC1.sLinkVideo = _tblSubjectEO.sLinkVideo; break;
                            case LichDayVaHoc_iTrangThai_C.Hoc_Bu: vLiveStream.ActiveViewIndex = 0; break;
                            case LichDayVaHoc_iTrangThai_C.Nghi: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Buoi_Hoc_Hom_Nay_Duoc_Nghi; break;
                            default: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Chua_Den_Thoi_Gian_Hoc; break;
                        }
                        Thong_Tin_Lop_HocUC1.BinData(_tblSubjectEO);
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void tSync_Tick(object sender, EventArgs e)
        {
            Hoc_LieuUC1.BindData_HocLieu(sTendangnhapGV);
            //ChatUC1.tAutoUpdateMessage_Tick(sender, e);
        }
    }
}