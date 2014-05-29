using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using CongKy.DataAccessObject;

namespace CongKy.QuanTri
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DanhSachFileDaBackup();
            }
            catch { }
        }

        protected void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string LinkBackup;
                if (radioSaveClient.Checked == false)
                {
                    LinkBackup = Server.MapPath(txtPath.Text + "/CongKy__" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy__HH-mm-ss")) + ".bak");
                }
                else
                {
                    LinkBackup = txtPath.Text + "CongKy__" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy__HH-mm-ss")) + ".bak";
                }
                string sqlBackup = "BACKUP DATABASE [CongKy] TO DISK='" + LinkBackup + "'";
                SqlConnection conn = ConnectionDAO.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlBackup, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Sao lưu Dữ liệu thành công!!!')</script>");
            }
            catch
            {
                Response.Write("<script>alert('ERROR: Sao lưu Dữ liệu không thành công, Vui lòng kiểm tra lại Kết nối và Đường dẫn.')</script>");
                return;
            }
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string path = "D:\\backupCongKy.bak";
            //    string sqlRestore = "Use master Restore Database [CongKy] from disk='" + path + "'";
            //    SqlConnection conn = ConnectionDAO.getConnection();
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sqlRestore, conn);
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    Response.Write("<script>alert('Khôi phục Dữ liệu thành công!!!')</script>");
            //}
            //catch
            //{
            //    Response.Write("<script>alert('ERROR: Sao lưu Dữ liệu không thành công, Vui lòng kiểm tra lại Kết nối và Đường dẫn.')</script>");
            //    return;
            //}
        }

        private void DanhSachFileDaBackup()
        {
            string[] lstFile = Directory.GetFiles(Server.MapPath("~/App_Data/"), "*.bak");

            trvFileBackup.Nodes.Clear();
            foreach (string FileName in lstFile)
            {
                FileInfo fInfo = new FileInfo(FileName);

                TreeNode trNood = new TreeNode(fInfo.Name, fInfo.Name);

                trvFileBackup.Nodes.Add(trNood);
            }
        }

        protected void radioSaveClient_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Text = "D:\\";
        }

        protected void radioSaveServer_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Text = "~/App_Data/";
        }
    }
}