using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Shared_Libraries;

namespace EHOU.UserControl
{
    public partial class Hoc_LieuUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public string sTendangnhapGV
        {
            get { return (string)ViewState["sTendangnhapGV"]; }
            set { ViewState["sTendangnhapGV"] = value; }
        }

        List<String> CheckedNodes = new List<String>();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                //Load_HocLieu();
            }
        }

        public void BindData_HocLieu(string _sTendangnhapGV)
        {
            sTendangnhapGV = _sTendangnhapGV;
            string[] lstFile = Directory.GetFiles(Server.MapPath("~/Upload/" + _sTendangnhapGV + "/" + Messages.Ebook));
            trvFileUpload.Nodes.Clear();
            foreach (string FileName in lstFile)
            {
                FileInfo fInfo = new FileInfo(FileName);
                TreeNode trNode = new TreeNode(fInfo.Name, fInfo.Name);
                trNode.SelectAction = TreeNodeSelectAction.Select;
                trNode.NavigateUrl = "~/Upload/" + _sTendangnhapGV + "/" + Messages.Ebook + fInfo.Name;
                trNode.PopulateOnDemand = true;
                trvFileUpload.Nodes.Add(trNode);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string root = Server.MapPath("~/Upload/" + sTendangnhapGV + "/" + Messages.Ebook);
                for (int i = 0; i < CheckedNodes.Count; i++)
                {
                    if ((File.Exists(root + CheckedNodes[i])) == true)
                    {
                        File.Delete(root + CheckedNodes[i]);
                    }
                }
                BindData_HocLieu(sTendangnhapGV);
                lblMsg.Text = Messages.Xoa_Thanh_Cong;
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnPermit_Click(object sender, EventArgs e)
        {

        }

        protected void trvFileUpload_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            if (e.Node.Checked)
            {
                CheckedNodes.Add(e.Node.Value);
            }
            else
            {
                CheckedNodes.Remove(e.Node.Value);
            }
        }
    }
}