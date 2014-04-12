using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace DO_AN_TN.UserControl
{
    public partial class Hoc_LieuUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_HocLieu();
        }

        private void Load_HocLieu()
        {
            string[] lstFile = Directory.GetFiles(Server.MapPath("~/Upload/"), "*.docx");

            trvFileBackup.Nodes.Clear();
            foreach (string FileName in lstFile)
            {
                FileInfo fInfo = new FileInfo(FileName);

                TreeNode trNood = new TreeNode(fInfo.Name, fInfo.Name);

                trvFileBackup.Nodes.Add(trNood);
            }
        }
    }
}