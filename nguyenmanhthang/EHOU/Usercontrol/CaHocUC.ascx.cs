using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;

namespace EHOU.Usercontrol
{
    public partial class CaHocUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler GoClass;
        public string FK_sSubject
        {
            get { return (string)ViewState["FK_sSubject"]; }
            set { ViewState["FK_sSubject"] = value; }
        }
        public string FK_sStudent
        {
            get { return (string)ViewState["FK_sStudent"]; }
            set { ViewState["FK_sStudent"] = value; }
        }
        public Int64 lCaHoc
        {
            get { return (Int64)ViewState["lCaHoc"]; }
            set { ViewState["lCaHoc"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    tblDetailEO _tblDetailEO = new tblDetailEO();
                    _tblDetailEO.FK_sSubject = FK_sSubject;
                    _tblDetailEO.FK_sStudent = FK_sStudent;
                    rbtnlListClass.DataSource = tblDetailDAO.SelectByFK_sSubject_FK_sStudent(_tblDetailEO);
                    rbtnlListClass.DataTextField = "sTitle";
                    rbtnlListClass.DataValueField = "PK_lCaHoc";
                    rbtnlListClass.DataBind();
                }
            }
            catch { }
        }

        protected void rbtnlListClass_TextChanged(object sender, EventArgs e)
        {
            lCaHoc = Convert.ToInt64(rbtnlListClass.SelectedValue);
            if (GoClass != null)
            {
                GoClass(this, EventArgs.Empty);
            }
        }
    }
}