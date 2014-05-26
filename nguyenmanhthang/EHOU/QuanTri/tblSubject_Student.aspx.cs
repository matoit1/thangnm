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
    public partial class tblSubject_Student : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblSubject_Student_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblSubject_Student_DetailUC1.btnInsert.Visible = false;
            tblSubject_Student_DetailUC1.btnUpdate.Visible = true;
            tblSubject_Student_DetailUC1.btnDelete.Visible = true;
            tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
            _tblSubject_StudentEO.FK_sSubject = tblSubject_Student_ListUC1.FK_sSubject;
            _tblSubject_StudentEO.FK_sStudent = tblSubject_Student_ListUC1.FK_sStudent;
            _tblSubject_StudentEO = tblSubject_StudentDAO.Subject_Student_SelectItem(_tblSubject_StudentEO);
            tblSubject_Student_DetailUC1.BindDataDetail(_tblSubject_StudentEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblSubject_Student_DetailUC1.btnInsert.Visible = true;
            tblSubject_Student_DetailUC1.btnUpdate.Visible = false;
            tblSubject_Student_DetailUC1.btnDelete.Visible = false;
            tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
            tblSubject_Student_DetailUC1.BindDataDetail(_tblSubject_StudentEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblSubject_Student_DetailUC1.ClearMessages();
            tblSubject_Student_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblSubject_Student_ListUC1.BindData();
        }
    }
}