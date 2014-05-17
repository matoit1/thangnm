using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.DataAccessObject;

namespace HaBa.Admin
{
    public partial class SanPham : System.Web.UI.Page
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
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            _tblSanPhamEO.PK_lSanPhamID = tblSanPham_ListUC1.PK_lSanPhamID;
            _tblSanPhamEO = tblSanPhamDAO.SanPham_SelectItem(_tblSanPhamEO);
            tblSanPham_DetailUC1.BindDataDetail(_tblSanPhamEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            tblSanPham_DetailUC1.BindDataDetail(_tblSanPhamEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblSanPham_ListUC1.BindData();
        }
    }
}