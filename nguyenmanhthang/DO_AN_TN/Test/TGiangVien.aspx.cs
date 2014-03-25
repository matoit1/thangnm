using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;

namespace DO_AN_TN.Test
{
    public partial class TGiangVien : System.Web.UI.Page
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
            GiangVienEO _GiangVienEO = new GiangVienEO();
            _GiangVienEO.PK_sMaGV = GiangVien_ListUC1.PK_sMaGV;
            _GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);
            GiangVien_DetailUC1.BindDataDetail(_GiangVienEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            GiangVienEO _GiangVienEO = new GiangVienEO();
            GiangVien_DetailUC1.BindDataDetail(_GiangVienEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            GiangVien_ListUC1.BindData();
        }
    }
}