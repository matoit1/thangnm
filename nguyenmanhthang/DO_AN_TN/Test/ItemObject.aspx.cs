using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using Shared_Libraries;

namespace DO_AN_TN.Test
{
    public partial class ItemObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["Accounts_Username"].ToString() != null){
                    ErrorEO _ErrorEO = new ErrorEO();
                    _ErrorEO.PK_lErrorID = Convert.ToInt64(Request.QueryString["Accounts_Username"]);
                    ErrorEO result =  ErrorDAO.Error_SelectItem(_ErrorEO);
                    txtPK_lErrorID.Text = result.PK_lErrorID.ToString();
                    txtsLink.Text = result.sLink;
                    txtsIP.Text = result.sIP;
                    txtsBrowser.Text = result.sBrowser;
                    txtiCodes.Text = result.iCodes.ToString();
                    txttTime.Text = result.tTime.ToString();
                    txttTimeCheck.Text = result.tTimeCheck.ToString();
                    txtiStatus.Text = result.iStatus.ToString();
                }
            }
            LichDayVaHocEO obj = new LichDayVaHocEO();
            obj.FK_sMaPCCT = "1";
            obj.FK_sMalop = "1";
            DataSet2Object.LichDayVaHocEO(LichDayVaHocDAO.LichDayVaHoc_SelectItem(obj));
        }
    }
}