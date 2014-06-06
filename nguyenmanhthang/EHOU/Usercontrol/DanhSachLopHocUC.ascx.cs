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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void BindData(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            cblDanhSachLop.DataSource = tblSubject_StudentDAO.Subject_Student_SelectByFK_sSubject(_tblSubject_StudentEO);
            cblDanhSachLop.DataTextField = "sName";
            cblDanhSachLop.DataValueField = "FK_sStudent";
            cblDanhSachLop.DataBind();
        }
    }
}