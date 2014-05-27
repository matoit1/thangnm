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
                    if (Request.QueryString["PK_sSubject"] != null && Request.QueryString["PK_iPart"] != null)
                    {
                        tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                        _tblSubjectEO.PK_sSubject = Request.QueryString["PK_sSubject"];
                        _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(_tblSubjectEO);
                        sTendangnhapGV = _tblSubjectEO.FK_sTeacher;

                        tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
                        _tblSubject_StudentEO.FK_sSubject = _tblSubjectEO.PK_sSubject;
                        _tblSubject_StudentEO.FK_sStudent = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString();
                        //_tblSubject_StudentEO.PK_lCaHoc = Convert.ToInt64(Request.QueryString["PK_iPart"].ToString());
                        if (tblSubject_StudentDAO.Subject_Student_CheckExists(_tblSubject_StudentEO) != true)
                        {
                            Response.Redirect("~/Access_Denied.aspx");
                        }
                        tblMessageEO _tblMessageEO = new tblMessageEO();
                        _tblMessageEO.FK_sRoom = _tblSubjectEO.PK_sSubject;
                        _tblMessageEO.FK_sUsername = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString();
                        _tblMessageEO.iStatus = 1;

                        //sTendangnhapGV = _GiangVienEO.sTendangnhapGV;
                        Hoc_LieuUC1.BindData_HocLieu(_tblSubjectEO.FK_sTeacher);
                        tblPartEO _tblPartEO = new tblPartEO();
                        _tblPartEO.PK_iPart = Convert.ToInt16(Request.QueryString["PK_iPart"]);
                        _tblPartEO.FK_sSubject = _tblSubjectEO.PK_sSubject;
                        _tblPartEO = tblPartDAO.Part_SelectItem(_tblPartEO);

                        ChatUC1.objtblMessageEO = _tblMessageEO;
                        ChatUC1.objtblPartEO = _tblPartEO;
                        ChatUC1.iTypeUser = tblAccount_iType_C.Sinh_Vien;
                        DanhSachLopHocUC1.BindData(_tblSubject_StudentEO);

                        //Kiểm tra trạng thái buổi học Online / Offline
                        switch (_tblSubjectEO.iStatus)
                        {
                            case tblPart_iStatus_C.Hoc: vLiveStream.ActiveViewIndex =0; break;
                            case tblPart_iStatus_C.Day_Offline: vLiveStream.ActiveViewIndex = 1; VideoUC1.sLinkVideo = _tblPartEO.sLinkVideo; break;
                            case tblPart_iStatus_C.Hoc_Bu: vLiveStream.ActiveViewIndex = 0; break;
                            case tblPart_iStatus_C.Nghi: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Buoi_Hoc_Hom_Nay_Duoc_Nghi; break;
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