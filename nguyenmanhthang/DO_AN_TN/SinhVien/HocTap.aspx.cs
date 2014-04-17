using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;

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
                            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                            GiangVienEO _GiangVienEO = new GiangVienEO();
                            _LopHocEO.PK_sMalop = Request.QueryString["PK_sMalop"];
                            _PhanCongCongTacEO.PK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                            Thong_Tin_Lop_HocUC1.BinData(LopHocDAO.LopHoc_SelectItem(_LopHocEO), PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO));
                            _GiangVienEO.PK_sMaGV = (PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO).FK_sMaGV);
                            sTendangnhapGV = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO).sTendangnhapGV;
                            Hoc_LieuUC1.BindData_HocLieu(sTendangnhapGV);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void tSync_Tick(object sender, EventArgs e)
        {
            Hoc_LieuUC1.BindData_HocLieu(sTendangnhapGV);
        }
    }
}