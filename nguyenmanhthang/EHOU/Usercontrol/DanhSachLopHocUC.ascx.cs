using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using System.IO;
using Shared_Libraries;

namespace EHOU.UserControl
{
    public partial class DanhSachLopHocUC : System.Web.UI.UserControl
    {
        public static string path = HttpContext.Current.Request.MapPath("~/Upload/BlackList.txt");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void BindData(SinhVienEO _SinhVienEO){
            cblDanhSachLop.DataSource = SinhVienDAO.SinhVien_SelectByFK_sMaLop(_SinhVienEO);
            cblDanhSachLop.DataTextField = "sHotenSV";
            cblDanhSachLop.DataValueField = "PK_sMaSV";
            cblDanhSachLop.DataBind();
        }

        protected void btnBlackList_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> locList = new List<string>();
                foreach (ListItem item in cblDanhSachLop.Items)
                {
                    if (item.Selected == true)
                    {
                        locList.Add(item.Value);
                        string appendText = item.Value + Environment.NewLine;
                        File.AppendAllText(path, appendText);
                    }
                }
                lblMsg.Text = Messages.ChatRoom_BlackList_Success;
            }
            catch
            {
                lblMsg.Text = Messages.ChatRoom_BlackList_Fail;
            }



            try
            {
                string line;
                List<string> lstAcc = new List<string>();
                System.IO.StreamReader file =
                    new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    lstAcc.Add(line);
                }
                file.Close();
                ddlTextFile.DataSource = lstAcc;
                cblDanhSachLop.DataTextField = "Key";
                cblDanhSachLop.DataValueField = "Value";
                ddlTextFile.DataBind();
                if (lstAcc.Any(s => s.Equals("SV100000")) == true)
                {
                    lblMsg.Text = "Denial !";
                }
                else
                {
                    lblMsg.Text = "OK !";
                }
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}