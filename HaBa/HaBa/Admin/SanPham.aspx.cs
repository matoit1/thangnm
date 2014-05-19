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
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblSanPham_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblSanPham_DetailUC1.btnInsert.Visible = false;
            tblSanPham_DetailUC1.btnUpdate.Visible = true;
            tblSanPham_DetailUC1.btnDelete.Visible = true;
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            _tblSanPhamEO.PK_sSanPhamID = tblSanPham_ListUC1.PK_sSanPhamID;
            _tblSanPhamEO = tblSanPhamDAO.SanPham_SelectItem(_tblSanPhamEO);
            tblSanPham_DetailUC1.BindDataDetail(_tblSanPhamEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblSanPham_DetailUC1.btnInsert.Visible = true;
            tblSanPham_DetailUC1.btnUpdate.Visible = false;
            tblSanPham_DetailUC1.btnDelete.Visible = false;
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