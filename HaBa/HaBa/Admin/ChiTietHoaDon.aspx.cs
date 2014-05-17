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
    public partial class ChiTietHoaDon : System.Web.UI.Page
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
            tblChiTietHoaDon_DetailUC1.btnInsert.Visible = false;
            tblChiTietHoaDon_DetailUC1.btnUpdate.Visible = true;
            tblChiTietHoaDon_DetailUC1.btnDelete.Visible = true;
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblChiTietHoaDonEO.FK_lHoaDonID = tblChiTietHoaDon_ListUC1.FK_lHoaDonID;
            _tblChiTietHoaDonEO.FK_lSanPhamID = tblChiTietHoaDon_ListUC1.FK_lSanPhamID;
            _tblChiTietHoaDonEO = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectItem(_tblChiTietHoaDonEO);
            tblChiTietHoaDon_DetailUC1.BindDataDetail(_tblChiTietHoaDonEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblChiTietHoaDon_DetailUC1.btnInsert.Visible = true;
            tblChiTietHoaDon_DetailUC1.btnUpdate.Visible = false;
            tblChiTietHoaDon_DetailUC1.btnDelete.Visible = false;
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            tblChiTietHoaDon_DetailUC1.BindDataDetail(_tblChiTietHoaDonEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblChiTietHoaDon_ListUC1.BindData();
        }
    }
}