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
    public partial class tblMessage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblMessage_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblMessage_DetailUC1.btnInsert.Visible = false;
            tblMessage_DetailUC1.btnUpdate.Visible = true;
            tblMessage_DetailUC1.btnDelete.Visible = true;
            tblMessageEO _tblMessageEO = new tblMessageEO();
            _tblMessageEO.PK_lMessage = tblMessage_ListUC1.PK_lMessage;
            _tblMessageEO = tblMessageDAO.Message_SelectItem(_tblMessageEO);
            tblMessage_DetailUC1.BindDataDetail(_tblMessageEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblMessage_DetailUC1.btnInsert.Visible = true;
            tblMessage_DetailUC1.btnUpdate.Visible = false;
            tblMessage_DetailUC1.btnDelete.Visible = false;
            tblMessageEO _tblMessageEO = new tblMessageEO();
            tblMessage_DetailUC1.BindDataDetail(_tblMessageEO);
        }


        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblMessage_DetailUC1.ClearMessages();
            tblMessage_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblMessage_ListUC1.BindData();
        }
    }
}