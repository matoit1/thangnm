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
    public partial class TSinhVien : System.Web.UI.Page
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
            SinhVienEO _SinhVienEO = new SinhVienEO();
            _SinhVienEO.PK_sMaSV = SinhVien_ListUC1.PK_sMaSV;
            _SinhVienEO = SinhVienDAO.SinhVien_SelectItem(_SinhVienEO);
            SinhVien_DetailUC1.BindDataDetail(_SinhVienEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            SinhVienEO _SinhVienEO = new SinhVienEO();
            SinhVien_DetailUC1.BindDataDetail(_SinhVienEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            SinhVien_ListUC1.BindData();
        }
    }
}