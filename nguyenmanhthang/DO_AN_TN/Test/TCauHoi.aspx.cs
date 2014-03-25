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
    public partial class TCauHoi : System.Web.UI.Page
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
            CauHoiEO _CauHoiEO = new CauHoiEO();
            _CauHoiEO.PK_lCauhoi_ID = CauHoi_ListUC1.PK_lCauhoi_ID;
            _CauHoiEO = CauHoiDAO.CauHoi_SelectItem(_CauHoiEO);
            CauHoi_DetailUC1.BindDataDetail(_CauHoiEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            CauHoiEO _CauHoiEO = new CauHoiEO();
            CauHoi_DetailUC1.BindDataDetail(_CauHoiEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            CauHoi_ListUC1.BindData();
        }
    }
}