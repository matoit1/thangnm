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
    public partial class NhomSanPham : System.Web.UI.Page
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
            tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
            _tblNhomSanPhamEO.PK_iNhomSanPhamID = tblNhomSanPham_ListUC1.PK_iNhomSanPhamID;
            _tblNhomSanPhamEO = tblNhomSanPhamDAO.NhomSanPham_SelectItem(_tblNhomSanPhamEO);
            tblNhomSanPham_DetailUC1.BindDataDetail(_tblNhomSanPhamEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
            tblNhomSanPham_DetailUC1.BindDataDetail(_tblNhomSanPhamEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblNhomSanPham_ListUC1.BindData();
        }
    }
}