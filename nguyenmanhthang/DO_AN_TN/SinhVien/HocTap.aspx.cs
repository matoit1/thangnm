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
                            _LopHocEO.PK_sMalop = Request.QueryString["PK_sMalop"];
                            _PhanCongCongTacEO.PK_sMaPCCT = Request.QueryString["FK_sMaPCCT"];
                            Thong_Tin_Lop_HocUC1.BinData(LopHocDAO.LopHoc_SelectItem(_LopHocEO), PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO));

                            

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}