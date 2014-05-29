using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Text;
using System.IO;
using CongKy.SharedLibraries;

namespace CongKy.UserControl
{
    public partial class UploadFileUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler Refresh;
        public string linkfilevideo;
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
                        filename = userPostedFile.FileName.Replace(",", "_");
                        userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(filename));
                        linkfilevideo = linkfilevideo + "," + "../Upload/" + sTendangnhapGV + "/" + sTypeUpload + Path.GetFileName(filename);
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