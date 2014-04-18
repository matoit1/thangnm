using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace DO_AN_TN.GiangVien
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
                    if (Request.QueryString["PK_sMalop"] != null)
                    {
                        if (Request.QueryString["FK_sMaPCCT"] != null)
                        {
                            LopHocEO _LopHocEO = new LopHocEO();
                            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                            GiangVienEO _GiangVienEO = new GiangVienEO();
                            _LopHocEO.PK_sMalop = Request.QueryString["PK_sMalop"];
                            _PhanCongCongTacEO.PK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                            Thong_Tin_Lop_HocUC1.BinData(LopHocDAO.LopHoc_SelectItem(_LopHocEO), PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO));
                        }
                    }
                }
                LoadInfo();
            }
            catch
            {
            }
            try
            {
                if (Request.QueryString["state"] != null)
                {
                    tClock.Enabled = true;
                    tClock.Interval = 50000000;
                }
            }
            catch
            {
            }
            try
            {
                if (Common.CaHocHienTai() == Convert.ToInt16(Request.QueryString["iCaHoc"]))
                {
                    ASM_ServerUC1.Visible = true;
                    ChatUC1.Visible = true;
                    Thong_Tin_Lop_HocUC1.Visible = true;
                    Hoc_LieuUC1.Visible = true;
                    UploadFileUC1.Visible = true;
                    lblTitle.Text = "";
                }
                else
                {
                    ASM_ServerUC1.Visible = false;
                    ChatUC1.Visible = false;
                    Thong_Tin_Lop_HocUC1.Visible = false;
                    Hoc_LieuUC1.Visible = false;
                    UploadFileUC1.Visible = false;
                    lblTitle.Text = Messages.Chua_Den_Thoi_Gian_Hoc;
                }
            }
            catch (Exception ex)
            {
                ASM_ServerUC1.Visible = false;
                ChatUC1.Visible = false;
                Thong_Tin_Lop_HocUC1.Visible = false;
                Hoc_LieuUC1.Visible = false;
                UploadFileUC1.Visible = false;
                lblMsg.Text = ex.Message;
            }
        }

        private void LoadInfo(){
            try
            {
                UploadFileUC1.sTendangnhapGV = Request.Cookies["giangvien"].Value;
                Hoc_LieuUC1.BindData_HocLieu(Request.Cookies["giangvien"].Value);
            }
            catch
            {
            }
        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        protected void tClock_Tick(object sender, EventArgs e)
        {
            btnClock.Text = DateTime.Now.ToLongTimeString().ToString();
            current = Common.CaHocHienTai();
            lblCaHoc.Text = "Ca học: " + current.ToString();
            try
            {
                if (current == Convert.ToInt16(Request.QueryString["iCaHoc"]))
                {
                    Response.Redirect(Request.Url.ToString()+"&state=1");
                }
            }
            catch(Exception ex) {
                lblMsg.Text = ex.Message;
            }
        }
    }
}