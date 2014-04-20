using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN.UserControl
{
    public partial class VideoUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public string sLinkVideo
        {
            get { return (string)ViewState["sLinkVideo"]; }
            set { ViewState["sLinkVideo"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadInfo(string sLinkVideo)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
            }
        }
    }
}