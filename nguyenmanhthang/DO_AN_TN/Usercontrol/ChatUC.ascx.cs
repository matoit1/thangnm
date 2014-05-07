using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Shared_Libraries.ChatLIB;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class ChatUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        //public event EventHandler ViewDetail;
        public static int indexrow =10;
        public TinNhanEO objTinNhanEO
        {
            get { return (TinNhanEO)ViewState["objTinNhanEO"]; }
            set { ViewState["objTinNhanEO"] = value; }
        }
        public int iType
        {
            get { return (int)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptDialog.DataSource = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                rptDialog.DataBind();
                tAutoUpdateMessage.Interval = 5000;
            }
        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            try
            {
                lblMsg.Text = string.Empty;
                objTinNhanEO.sNoidung = Convert.ToString(txtsNoidung.Text);
                if (string.IsNullOrEmpty(txtsNoidung.Text) == false)
                {
                    if (TinNhanDAO.TinNhan_Insert(objTinNhanEO) == false)
                    {
                        lblMsg.Text = Messages.ChatRoom_Fail;
                    }
                    else
                    {
                        txtsNoidung.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void tAutoUpdateMessage_Tick(object sender, EventArgs e)
        {
            rptDialog.DataSource = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
            rptDialog.DataBind();
        }

        public string GetRowColor(object obj)
        {
            string color = "white";
            if (!string.IsNullOrEmpty(obj.ToString()))
            {
                int status =Convert.ToInt32(obj) % 2;
                switch (status)
                {
                    case 0:
                        color = "#0000FF "; break;
                    case 1:
                        color = "#FF0000"; break;
                    default:
                        color = "#CC66FF"; break;
                }
            }
            return color;
        }
    }
}