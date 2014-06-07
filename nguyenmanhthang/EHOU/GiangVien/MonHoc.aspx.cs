using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace EHOU.GiangVien
{
    public partial class MonHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tblSubject_ListUC1.btnAddNew.Visible = false;
            tblSubject_DetailUC1.btnInsert.Visible = false;
            tblSubject_DetailUC1.btnUpdate.Visible = false;
            tblSubject_DetailUC1.btnDelete.Visible = false;
            tblSubject_DetailUC1.btnReset.Visible = false;
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        #region "Raise Event"
        protected void SelectRow_Click(object sender, EventArgs e)
        {
            //tblSubject_DetailUC1.BindDataDetail(tblSubject_ListUC1.PK_sMatblSubject);
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            _tblSubjectEO.PK_sSubject = tblSubject_ListUC1.PK_sSubject;
            _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(_tblSubjectEO);
            tblSubject_DetailUC1.BindDataDetail(_tblSubjectEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            tblSubject_DetailUC1.BindDataDetail(_tblSubjectEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblSubject_ListUC1.BindData();
        }
    }
}