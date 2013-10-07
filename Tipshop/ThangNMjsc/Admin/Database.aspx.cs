using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessObject;
using System.IO;

namespace ThangNMjsc.Admin
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DanhSachFileDaBackup();
            multiViewDatabase.SetActiveView(viewBackup);
        }

        protected void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string LinkBackup;
                if (radioSaveClient.Checked == false)
                {
                    LinkBackup = Server.MapPath(txtPath.Text + "/Tipshop_" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy")) + ".bak");
                }
                else
                {
                    LinkBackup = txtPath.Text + "Tipshop_" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy")) + ".bak";
                }
                string sqlBackup = "BACKUP DATABASE [Tipshop] TO DISK='" + LinkBackup + "'";
                SqlConnection conn = Connect.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlBackup, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Sao lưu Dữ liệu thành công!!!')</script>");
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('ERROR: Sao lưu Dữ liệu không thành công, Vui lòng kiểm tra lại.')</script>");
                return;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('ERROR: Sao lưu Dữ liệu không thành công, Vui lòng kiểm tra lại.')</script>");
            }
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\backupTipshop.bak";
                string sqlRestore = "Use master Restore Database [Tipshop] from disk='" + path + "'";
                SqlConnection conn = Connect.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlRestore, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Khôi phục Dữ liệu thành công!!!')</script>");
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('ERROR: Khôi phục Dữ liệu không thành công, Vui lòng kiểm tra lại.')</script>");
                return;
            }
            catch (Exception ex)
            { }
        }

        private void DanhSachFileDaBackup()
        {
            string[] lstFile = Directory.GetFiles(Server.MapPath("~/BackupDatabase/"), "*.bak");

            trvFileBackup.Nodes.Clear();
            foreach (string FileName in lstFile)
            {
                FileInfo fInfo = new FileInfo(FileName);

                TreeNode trNood = new TreeNode(fInfo.Name, fInfo.Name);

                trvFileBackup.Nodes.Add(trNood);
            }
        }

        protected void btnTab1_Click(object sender, EventArgs e)
        {
            multiViewDatabase.SetActiveView(viewBackup);
        }

        protected void btnTab2_Click(object sender, EventArgs e)
        {
            multiViewDatabase.SetActiveView(viewRestore);
        }

        protected void radioSaveClient_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Text = "D:\\";
        }

        protected void radioSaveServer_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Text = "~/BackupDatabase";
        }
    }
}