using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuteWebUI;

namespace DO_AN_TN
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void InsertMsg(string msg)
        {
            ListBoxEvents.Items.Insert(0, msg);
            ListBoxEvents.SelectedIndex = 0;
        }

        void Attachments1_AttachmentAdded(object sender, AttachmentItemEventArgs args)
        {
            InsertMsg(args.Item.FileName + " has been uploaded.");
        }

        void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            InsertMsg("Attachments1.DeleteAllAttachments();");
            Attachments1.DeleteAllAttachments();
        }
        void ButtonTellme_Click(object sender, EventArgs e)
        {
            ListBoxEvents.Items.Clear();
            foreach (AttachmentItem item in Attachments1.Items)
            {
                InsertMsg(item.FileName + ", " + item.FileSize + " bytes.");

                //Copies the uploaded file to a new location.
                //item.CopyTo("c:\\temp\\"+item.FileName);
                //You can also open the uploaded file's data stream.
                //System.IO.Stream data = item.OpenStream();
            }
        }
    }
}