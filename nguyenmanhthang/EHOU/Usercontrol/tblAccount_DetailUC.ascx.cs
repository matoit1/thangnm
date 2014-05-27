using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using Newtonsoft.Json.Linq;
using EntityObject;

namespace EHOU.Usercontrol
{
    public partial class tblAccount_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
                //BindDataDetail(Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value));
            }
        }

        public void BindDataDetail(tblAccountEO _tblAccountEO)
        {
            txtPK_sUsername.Text = _tblAccountEO.PK_sUsername;
            txtsPassword.Text = _tblAccountEO.sPassword;
            txtsName.Text = _tblAccountEO.sName;
            txtsEmail.Text = _tblAccountEO.sEmail;
            ddliType.SelectedValue = Convert.ToString(_tblAccountEO.iType);
            ddliStatus.SelectedValue = Convert.ToString(_tblAccountEO.iStatus);
        }

        public void loadDataToDropDownList()
        {
            ddliType.DataSource = GetListConstants.tblAccount_iType_GLC();
            ddliType.DataTextField = "Value";
            ddliType.DataValueField = "Key";
            ddliType.DataBind();

            ddliStatus.DataSource = GetListConstants.tblAccount_iStatus_GLC();
            ddliStatus.DataTextField = "Value";
            ddliStatus.DataValueField = "Key";
            ddliStatus.DataBind();
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_sUsername.Text = "";
            lblsPassword.Text = "";
            lblsName.Text = "";
            lblsEmail.Text = "";
            lbliType.Text = "";
            lbliStatus.Text = "";
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}