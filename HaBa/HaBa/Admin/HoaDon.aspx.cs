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
    public partial class HoaDon : System.Web.UI.Page
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
            tblHoaDon_DetailUC1.btnInsert.Visible = false;
            tblHoaDon_DetailUC1.btnUpdate.Visible = true;
            tblHoaDon_DetailUC1.btnDelete.Visible = true;
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            _tblHoaDonEO.PK_lHoaDonID = tblHoaDon_ListUC1.PK_lHoaDonID;
            _tblHoaDonEO = tblHoaDonDAO.HoaDon_SelectItem(_tblHoaDonEO);
            tblHoaDon_DetailUC1.BindDataDetail(_tblHoaDonEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblHoaDon_DetailUC1.btnInsert.Visible = true;
            tblHoaDon_DetailUC1.btnUpdate.Visible = false;
            tblHoaDon_DetailUC1.btnDelete.Visible = false;
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            tblHoaDon_DetailUC1.BindDataDetail(_tblHoaDonEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblHoaDon_ListUC1.BindData();
        }
    }
}