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
    public partial class TLichDayVaHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
            _LichDayVaHocEO.FK_sMaPCCT = LichDayVaHoc_ListUC1.FK_sMaPCCT;
            _LichDayVaHocEO.FK_sMalop = LichDayVaHoc_ListUC1.FK_sMalop;
            _LichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(_LichDayVaHocEO);
            LichDayVaHoc_DetailUC1.BindDataDetail(_LichDayVaHocEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
            LichDayVaHoc_DetailUC1.BindDataDetail(_LichDayVaHocEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            LichDayVaHoc_ListUC1.BindData();
        }
    }
}