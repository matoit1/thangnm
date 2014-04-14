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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("~/Upload/" + Request.Cookies["giangvien"].Value + "/");
            HttpFileCollection uploadedFiles = Request.Files;
            Span1.Text = string.Empty;

            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                HttpPostedFile userPostedFile = uploadedFiles[i];
                try
                {
                    if (userPostedFile.ContentLength > 0)
                    {
                        userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(userPostedFile.FileName));
                    }
                }
                catch (Exception Ex)
                {
                    Span1.Text += "Error: <br>" + Ex.Message;
                }
            }
        }

        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        //    HttpFileCollection fulFile = Request.Files;
        //    string link =Server.MapPath("~/Upload/" + Request.Cookies["giangvien"].Value+"/");
        //    try
        //    {
        //        foreach (String key in fulFile.Keys){
        //            HttpPostedFile flfile  = fulFile[key];
        //            flfile.SaveAs(link + flfile.FileName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblMsg.Text = ex.Message;
        //    }
        //}
    }
}