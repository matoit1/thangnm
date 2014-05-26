using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using Shared_Libraries.Constants;

namespace EHOU.Usercontrol
{
    public partial class ChonMonHocUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler GoSubject;
        public string PK_sSubject
        {
            get { return (string)ViewState["PK_sSubject"]; }
            set { ViewState["PK_sSubject"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    
                }
            }
            catch { }
        }

        public void BindData(tblSubject_StudentEO _tblSubject_StudentEO,tblSubjectEO _tblSubjectEO, Int16 iType)
        {
            switch (iType)
            {
                case tblAccount_iType_C.Sinh_Vien: 
                                                    rbtnlListSubject.DataSource = tblSubject_StudentDAO.SelectByFK_sStudent(_tblSubject_StudentEO);
                                                    rbtnlListSubject.DataTextField = "sName";
                                                    rbtnlListSubject.DataValueField = "FK_sSubject";
                                                    rbtnlListSubject.DataBind();
                                                    break;
                case tblAccount_iType_C.Giang_Vien:
                                                    rbtnlListSubject.DataSource = tblSubjectDAO.Subject_SelectByFK_sTeacher(_tblSubjectEO);
                                                    rbtnlListSubject.DataTextField = "sName";
                                                    rbtnlListSubject.DataValueField = "PK_sSubject";
                                                    rbtnlListSubject.DataBind();
                                                    break;
            }
            
        }

        protected void rbtnlListSubject_TextChanged(object sender, EventArgs e)
        {
            PK_sSubject = rbtnlListSubject.SelectedValue;
            if (GoSubject != null)
            {
                GoSubject(this, EventArgs.Empty);
            }
        }
    }
}