using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace EHOU.QuanTri
{
    public partial class tblMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
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
            tblMaterial_DetailUC1.btnInsert.Visible = false;
            tblMaterial_DetailUC1.btnUpdate.Visible = true;
            tblMaterial_DetailUC1.btnDelete.Visible = true;
            tblMaterialEO _tblMaterialEO = new tblMaterialEO();
            _tblMaterialEO.PK_lMaterial = tblMaterial_ListUC1.PK_lMaterial;
            _tblMaterialEO = tblMaterialDAO.Material_SelectItem(_tblMaterialEO);
            tblMaterial_DetailUC1.BindDataDetail(_tblMaterialEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblMaterial_DetailUC1.btnInsert.Visible = true;
            tblMaterial_DetailUC1.btnUpdate.Visible = false;
            tblMaterial_DetailUC1.btnDelete.Visible = false;
            tblMaterialEO _tblMaterialEO = new tblMaterialEO();
            tblMaterial_DetailUC1.BindDataDetail(_tblMaterialEO);
        }


        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblMaterial_DetailUC1.ClearMessages();
            tblMaterial_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblMaterial_ListUC1.BindData();
        }
    }
}