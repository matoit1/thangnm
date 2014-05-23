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
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblHoaDon_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
                }
            }
            catch
            {
            }
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
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblHoaDonEO.PK_lHoaDonID = tblHoaDon_ListUC1.PK_lHoaDonID;
            _tblChiTietHoaDonEO.FK_lHoaDonID = tblHoaDon_ListUC1.PK_lHoaDonID;
            _tblHoaDonEO = tblHoaDonDAO.HoaDon_SelectItem(_tblHoaDonEO);
            tblHoaDon_DetailUC1.BindDataDetail(_tblHoaDonEO);
            tblChiTietHoaDon_ListUC1.BindData(_tblChiTietHoaDonEO);
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


        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
            tabMain.ActiveTabIndex = 1;
        }

        protected void ViewDetailChiTietHoaDon_Click(object sender, EventArgs e)
        {
            mtvChiTietHoaDon.SetActiveView(vDetailChiTietHoaDon);
            tblChiTietHoaDon_DetailUC1.btnInsert.Visible = false;
            tblChiTietHoaDon_DetailUC1.btnUpdate.Visible = true;
            tblChiTietHoaDon_DetailUC1.btnDelete.Visible = true;
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblChiTietHoaDonEO.FK_lHoaDonID = tblChiTietHoaDon_ListUC1.FK_lHoaDonID;
            _tblChiTietHoaDonEO.FK_sSanPhamID = tblChiTietHoaDon_ListUC1.FK_sSanPhamID;
            _tblChiTietHoaDonEO = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectItem(_tblChiTietHoaDonEO);
            tblChiTietHoaDon_DetailUC1.BindDataDetail(_tblChiTietHoaDonEO);
            tabMain.ActiveTabIndex = 1;
        }

        protected void AddNewChiTietHoaDon_Click(object sender, EventArgs e)
        {
            mtvChiTietHoaDon.SetActiveView(vDetailChiTietHoaDon);
            tblHoaDon_DetailUC1.btnInsert.Visible = true;
            tblHoaDon_DetailUC1.btnUpdate.Visible = false;
            tblHoaDon_DetailUC1.btnDelete.Visible = false;
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            tblChiTietHoaDon_DetailUC1.BindDataDetail(_tblChiTietHoaDonEO);
            tabMain.ActiveTabIndex = 1;
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblHoaDon_ListUC1.BindData();
            tabMain.ActiveTabIndex = 1;
        }

        protected void lbtnBackChiTietHoaDon_Click(object sender, EventArgs e)
        {
            mtvChiTietHoaDon.SetActiveView(vListChiTietHoaDon);
            tblChiTietHoaDon_ListUC1.BindData(tblChiTietHoaDon_ListUC1.objtblChiTietHoaDonEO);
            //tabMain.ActiveTabIndex = tabindex;
            tabMain.ActiveTab.TabIndex = Convert.ToInt16(tabMain.ActiveTabIndex);
        }
    }
}