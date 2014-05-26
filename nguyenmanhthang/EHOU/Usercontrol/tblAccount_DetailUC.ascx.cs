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
            //txtscreenName.Text = _JObject["screenName"].ToString();
            //txtusername.Text = _JObject["username"].ToString();
            //txtpassword.Text = "******";
            //txtemail.Text = _JObject["email"].ToString();
            //rbtnmale.Checked = Convert.ToBoolean(_JObject["male"]);
            //ddliType.SelectedValue = _JObject["type"].ToString();
        }

        public void loadDataToDropDownList()
        {
            ddliType.DataSource = GetListConstants.tblAccount_iType_GLC();
            ddliType.DataTextField = "Value";
            ddliType.DataValueField = "Key";
            ddliType.DataBind();
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            //lblscreenName.Text = "";
            //lblusername.Text = "";
            //lblpassword.Text = "";
            //lblemail.Text = "";
            //lblmale.Text = "";
            //lbliType.Text = "";
        }
    }
}