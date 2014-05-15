using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace EHOU.UserControl
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
            try
            {
                switch (Path.GetExtension(sLinkVideo.ToUpper()))
                {
                    case ".FLV": mtvVideo.ActiveViewIndex = 0; break;
                    case ".MP4": mtvVideo.ActiveViewIndex = 0; break;
                    case ".OGG": mtvVideo.ActiveViewIndex = 1; break;
                    case ".WEBM": mtvVideo.ActiveViewIndex = 1; break;
                    case ".F4V": mtvVideo.ActiveViewIndex = 1; break;
                    case ".MKV": mtvVideo.ActiveViewIndex = 1; break;
                    case ".AVI": mtvVideo.ActiveViewIndex = 2; break;
                    case ".3G2": mtvVideo.ActiveViewIndex = 2; break;
                    case ".MOV": mtvVideo.ActiveViewIndex = 2; break;
                    case ".MPG": mtvVideo.ActiveViewIndex = 2; break;
                    case ".WMV": mtvVideo.ActiveViewIndex = 2; break;
                    default: mtvVideo.ActiveViewIndex = 3; break;
                }
            }
            catch { }
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