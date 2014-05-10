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

namespace DO_AN_TN.SinhVien
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
                    if (Request.QueryString["PK_sMalop"] != null)
                    {
                        if (Request.QueryString["FK_sMaPCCT"] != null)
                        {
                            LopHocEO _LopHocEO = new LopHocEO();
                            _LopHocEO.PK_sMalop = Request.QueryString["PK_sMalop"];
                            _LopHocEO = LopHocDAO.LopHoc_SelectItem(_LopHocEO);

                            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                            _PhanCongCongTacEO.PK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                            _PhanCongCongTacEO = PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO);

                            GiangVienEO _GiangVienEO = new GiangVienEO();
                            _GiangVienEO.PK_sMaGV = _PhanCongCongTacEO.FK_sMaGV;
                            _GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);

                            LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                            _LichDayVaHocEO.FK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                            _LichDayVaHocEO.FK_sMalop = Request.QueryString["PK_sMalop"];
                            _LichDayVaHocEO.iCaHoc = Convert.ToInt16(Request.QueryString["iCaHoc"]);
                            _LichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(_LichDayVaHocEO);

                            SinhVienEO _SinhVienEO = new SinhVienEO();
                            _SinhVienEO.sTendangnhapSV = Request.Cookies["sinhvien"].Value;
                            _SinhVienEO = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO);
                            TinNhanEO _TinNhanEO = new TinNhanEO();
                            _TinNhanEO.FK_sPhongChat = _LichDayVaHocEO.FK_sMalop;
                            _TinNhanEO.FK_sNguoiGui = _SinhVienEO.PK_sMaSV;
                            _TinNhanEO.iTrangThai = 1;
                            ChatUC1.objTinNhanEO = _TinNhanEO;
                            ChatUC1.objLichDayVaHocEO = _LichDayVaHocEO;
                            ChatUC1.iTypeUser = Messages.ChatRoom_TypeUser_SinhVien;

                            sTendangnhapGV = _GiangVienEO.sTendangnhapGV;
                            Hoc_LieuUC1.BindData_HocLieu(sTendangnhapGV);

                            //Kiểm tra trạng thái buổi học Online / Offline
                            switch (_LichDayVaHocEO.iTrangThai)
                            {
                                case LichDayVaHoc_iTrangThai_C.Hoc: vLiveStream.ActiveViewIndex =0; break;
                                case LichDayVaHoc_iTrangThai_C.Day_Offline: vLiveStream.ActiveViewIndex = 1; VideoUC1.sLinkVideo = _LichDayVaHocEO.sLinkVideo; break;
                                case LichDayVaHoc_iTrangThai_C.Hoc_Bu: vLiveStream.ActiveViewIndex = 0; break;
                                case LichDayVaHoc_iTrangThai_C.Nghi: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Buoi_Hoc_Hom_Nay_Duoc_Nghi; break;
                                default: vLiveStream.ActiveViewIndex = 2; lblNotify.Text = Messages.Chua_Den_Thoi_Gian_Hoc; break;
                            }
                            Thong_Tin_Lop_HocUC1.BinData(_GiangVienEO, _LopHocEO, _PhanCongCongTacEO, _LichDayVaHocEO);
                        }
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