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
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadFile_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("~/Upload/" + sTendangnhapGV + "/");
            HttpFileCollection uploadedFiles = Request.Files;
            lblMsg.Text = "";
            try
            {
                for (int i = 0; i < uploadedFiles.Count; i++)
                {
                    HttpPostedFile userPostedFile = uploadedFiles[i];
                    if (userPostedFile.ContentLength > 0)
                    {
                        userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(userPostedFile.FileName));
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