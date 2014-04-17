using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.GiangVien
{
    public partial class GiangDay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
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
                catch
                {
                }
                LoadInfo();
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
    }
}