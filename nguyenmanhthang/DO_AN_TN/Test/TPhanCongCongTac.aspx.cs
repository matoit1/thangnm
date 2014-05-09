using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.Test
{
    public partial class TPhanCongCongTac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
                PhanCongCongTac_ListUC1.BindData(_PhanCongCongTacEO);
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        #region "Raise Event"
        protected void SelectRow_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
            _PhanCongCongTacEO.PK_sMaPCCT = PhanCongCongTac_ListUC1.PK_sMaPCCT;
            _PhanCongCongTacEO = PhanCongCongTacDAO.PhanCongCongTac_SelectItem(_PhanCongCongTacEO);
            PhanCongCongTac_DetailUC1.BindDataDetail(_PhanCongCongTacEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            PhanCongCongTacEO _PhanCongCongTacEO = new PhanCongCongTacEO();
            PhanCongCongTac_DetailUC1.BindDataDetail(_PhanCongCongTacEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            PhanCongCongTac_ListUC1.BindData(PhanCongCongTac_ListUC1.objPhanCongCongTacEO);
        }
    }
}