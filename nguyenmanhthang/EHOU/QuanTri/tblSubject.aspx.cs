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
    public partial class tblSubject : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblSubject_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblSubject_DetailUC1.btnInsert.Visible = false;
            tblSubject_DetailUC1.btnUpdate.Visible = true;
            tblSubject_DetailUC1.btnDelete.Visible = true;
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            _tblSubjectEO.PK_sSubject = tblSubject_ListUC1.PK_sSubject;
            _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(_tblSubjectEO);
            tblSubject_DetailUC1.BindDataDetail(_tblSubjectEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblSubject_DetailUC1.btnInsert.Visible = true;
            tblSubject_DetailUC1.btnUpdate.Visible = false;
            tblSubject_DetailUC1.btnDelete.Visible = false;
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            tblSubject_DetailUC1.BindDataDetail(_tblSubjectEO);
        }


        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblSubject_DetailUC1.ClearMessages();
            tblSubject_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblSubject_ListUC1.BindData();
        }
    }
}