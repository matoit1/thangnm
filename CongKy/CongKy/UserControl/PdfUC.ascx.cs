using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongKy.UserControl
{
    public partial class PdfUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public string sLinkEbook
        {
            get { return (string)ViewState["sLinkEbook"]; }
            set { ViewState["sLinkEbook"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}