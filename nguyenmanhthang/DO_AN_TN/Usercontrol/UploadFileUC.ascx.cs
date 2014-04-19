using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Text;
using Shared_Libraries;
using System.IO;

namespace DO_AN_TN.UserControl
{
    public partial class UploadFileUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler Refresh;

        public string sTendangnhapGV
        {
            get { return (string)ViewState["sTendangnhapGV"]; }
            set { ViewState["sTendangnhapGV"] = value; }
        }
        public string sTypeUpload
        {
            get { return (string)ViewState["sTypeUpload"]; }
            set { ViewState["sTypeUpload"] = value; }
        }
        public string sPrefixFileName
        {
            get { return (string)ViewState["sPrefixFileName"]; }
            set { ViewState["sPrefixFileName"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadFile_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("~/Upload/" + sTendangnhapGV + "/"+sTypeUpload);
            string filename ="";
            
            HttpFileCollection uploadedFiles = Request.Files;
            lblMsg.Text = "";
            try
            {
                
                for (int i = 0; i < uploadedFiles.Count; i++)
                {
                    HttpPostedFile userPostedFile = uploadedFiles[i];
                    if (userPostedFile.ContentLength > 0)
                    {
                        switch (sTypeUpload) {
                            case Messages.Ebook: filename = sPrefixFileName + userPostedFile.FileName; break;
                            case Messages.Video: filename = sPrefixFileName + userPostedFile.FileName; break;
                            case Messages.Example: filename = sPrefixFileName + userPostedFile.FileName; break;
                            default: filename = userPostedFile.FileName; break;
                        }
                        userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(filename));
                    }
                }
                lblMsg.Text = Messages.Tai_Len_Thanh_Cong;
                if (Refresh != null)
                {
                    Refresh(this, EventArgs.Empty);
                }
            }
            catch (Exception Ex)
            {
                lblMsg.Text += Messages.Loi + Ex.Message;
            }
        }
    }
}