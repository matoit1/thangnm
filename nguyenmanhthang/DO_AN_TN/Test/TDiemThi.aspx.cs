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
    public partial class TDiemThi : System.Web.UI.Page
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
            DiemThiEO _DiemThiEO = new DiemThiEO();
            _DiemThiEO.FK_sMaSV = DiemThi_ListUC1.FK_sMaSV;
            _DiemThiEO.FK_sMaMonhoc = DiemThi_ListUC1.FK_sMaMonhoc;
            _DiemThiEO.PK_iSolanhoc = DiemThi_ListUC1.PK_iSolanhoc;
            _DiemThiEO = DiemThiDAO.DiemThi_SelectItem(_DiemThiEO);
            DiemThi_DetailUC1.BindDataDetail(_DiemThiEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            DiemThiEO _DiemThiEO = new DiemThiEO();
            DiemThi_DetailUC1.BindDataDetail(_DiemThiEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            DiemThi_ListUC1.BindData();
        }
    }
}