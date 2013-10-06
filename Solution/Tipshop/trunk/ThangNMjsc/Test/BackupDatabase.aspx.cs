using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessObject;

namespace ThangNMjsc.Admin
{
    public partial class BackupDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\backupUITGPP.bak";
                string sqlRestore = "Use master Restore Database [UITGPP] from disk='" + path + "'";
                SqlConnection conn = Connect.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlRestore, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Database da duoc restore ");
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message, "Restore Database");
                return;
            }
            catch (Exception ex)
            {}
        }

        protected void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlBackup = "BACKUP DATABASE [UITGPP] TO DISK='D:\\backupUITGPP.bak'";
                SqlConnection conn = Connect.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlBackup, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Đã backup cơ sở dữ liệu");
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message, "Backup Database");
                return;
            }
            catch (Exception ex)
            {}
        }
    }
}