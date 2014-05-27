using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EHOU.DataAccessObject;
using EntityObject;
using DataAccessObject;

namespace EHOU.QuanTri
{
    public partial class tblPart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblPart_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblPart_DetailUC1.btnInsert.Visible = false;
            tblPart_DetailUC1.btnUpdate.Visible = true;
            tblPart_DetailUC1.btnDelete.Visible = true;
            tblPart_DetailUC1.txtPK_iPart.Enabled = false;
            tblPartEO _tblPartEO = new tblPartEO();
            _tblPartEO.PK_iPart = tblPart_ListUC1.PK_iPart;
            _tblPartEO.FK_sSubject = tblPart_ListUC1.FK_sSubject;
            _tblPartEO = tblPartDAO.Part_SelectItem(_tblPartEO);
            tblPart_DetailUC1.BindDataDetail(_tblPartEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblPart_DetailUC1.btnInsert.Visible = true;
            tblPart_DetailUC1.btnUpdate.Visible = false;
            tblPart_DetailUC1.btnDelete.Visible = false;
            tblPart_DetailUC1.txtPK_iPart.Enabled = true;
            tblPartEO _tblPartEO = new tblPartEO();
            tblPart_DetailUC1.BindDataDetail(_tblPartEO);
        }


        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblPart_DetailUC1.ClearMessages();
            tblPart_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblPart_ListUC1.BindData();
        }
    }
}