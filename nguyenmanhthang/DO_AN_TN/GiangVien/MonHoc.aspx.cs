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
    public partial class MonHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MonHoc_ListUC1.btnAddNew.Visible = false;
            MonHoc_ListUC1.btnDeleteList.Visible = false;
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
            MonHocEO _MonHocEO = new MonHocEO();
            _MonHocEO.PK_sMaMonhoc = MonHoc_ListUC1.PK_sMaMonhoc;
            _MonHocEO = MonHocDAO.MonHoc_SelectItem(_MonHocEO);
            MonHoc_DetailUC1.BindDataDetail(_MonHocEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            MonHocEO _MonHocEO = new MonHocEO();
            MonHoc_DetailUC1.BindDataDetail(_MonHocEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            MonHoc_ListUC1.BindData();
        }
    }
}