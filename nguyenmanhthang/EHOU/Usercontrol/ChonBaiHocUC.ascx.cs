using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using System.Data;

namespace EHOU.Usercontrol
{
    public partial class ChonBaiHocUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler GoPart;
        public tblPartEO objtblPartEO
        {
            get { return (tblPartEO)ViewState["objtblPartEO"]; }
            set { ViewState["objtblPartEO"] = value; }
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

        public void BindData(tblPartEO _tblPartEO)
        {
            objtblPartEO = _tblPartEO;
            DataSet ds = tblPartDAO.Part_SelectByFK_sSubject(_tblPartEO);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (string.IsNullOrEmpty(dr["tDateTimeStart"].ToString()))
                {
                    dr["tDateTimeStart"] = DateTime.MinValue;
                }
                if (string.IsNullOrEmpty(dr["tDateTimeEnd"].ToString()))
                {
                    dr["tDateTimeEnd"] = DateTime.MinValue;
                }
                dr["sTitle"] = dr["sTitle"] + " thời gian từ: " + dr["tDateTimeStart"] + " đến " + dr["tDateTimeEnd"];
            }
            rbtnlListPart.DataSource = ds;
            rbtnlListPart.DataTextField = "sTitle";
            rbtnlListPart.DataValueField = "PK_iPart";
            rbtnlListPart.DataBind();
        }

        protected void rbtnlListPart_TextChanged(object sender, EventArgs e)
        {
            objtblPartEO.PK_iPart = Convert.ToInt16(rbtnlListPart.SelectedValue);
            if (GoPart != null)
            {
                GoPart(this, EventArgs.Empty);
            }
        }
    }
}