using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Net;

namespace CongKy.UserControl
{
    public partial class WordUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Byte[] buffer = client.DownloadData(Server.MapPath("~/Upload/do_an.docx"));
            Response.ContentType = "application/msword";
            Response.AddHeader("content-length", buffer.Length.ToString());
            Response.BinaryWrite(buffer);

            
            //readFileContent(Server.MapPath("~/Upload/do_an.docx"));
            //FileInfo file = new FileInfo(Server.MapPath("~/Upload/do_an.docx"));

            //Response.ClearContent();

            //Response.AddHeader("Content-Disposition", "inline;filename=" + file.Name);

            //Response.AddHeader("Content-Length", file.Length.ToString());

            //Response.ContentType = "application/msword";

            //Response.TransmitFile(file.FullName);

            //Response.End();
        }

        private void readFileContent(string path)
        {

            ApplicationClass wordApp = new ApplicationClass();

            object file = path;

            object nullobj = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(

            ref file, ref nullobj, ref nullobj,

            ref nullobj, ref nullobj, ref nullobj,

            ref nullobj, ref nullobj, ref nullobj,

            ref nullobj, ref nullobj, ref nullobj,

            ref nullobj, ref nullobj, ref nullobj, ref nullobj);

            doc.ActiveWindow.Selection.WholeStory();

            doc.ActiveWindow.Selection.Copy();

            string sFileText = doc.Content.Text;

            doc.Close(ref nullobj, ref nullobj, ref nullobj);

            wordApp.Quit(ref nullobj, ref nullobj, ref nullobj);

            Response.Write(sFileText);

        }
    }
}