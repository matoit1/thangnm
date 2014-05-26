using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using EntityObject;
using DataAccessObject;
using System.Data;
using Shared_Libraries.Constants;

namespace EHOU.SinhVien
{
    public partial class ChonLopHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_sSubject"] != null)
                    {
                        BindDataPart(Request.QueryString["PK_sSubject"]);
                    }
                    else
                    {
                        BindDataSubject();
                    }
                }
            }
            catch { }
        }

        public void BindDataSubject()
        {
            try
            {
                pnlMonHoc.Visible = true;
                pnlBaiHoc.Visible = false;
                tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
                _tblSubject_StudentEO.FK_sStudent = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString();
                ChonMonHocUC1.BindData(_tblSubject_StudentEO, null, tblAccount_iType_C.Sinh_Vien);
            }
            catch
            {
            }
        }

        public void BindDataPart(string _PK_sSubject)
        {
            try
            {
                pnlMonHoc.Visible = false;
                pnlBaiHoc.Visible = true;
                tblPartEO _tblPartEO = new tblPartEO();
                _tblPartEO.FK_sSubject = _PK_sSubject;
                ChonBaiHocUC1.BindData(_tblPartEO);
            }
            catch
            {
            }
        }

        protected void GoSubject_Click(object sender, EventArgs e)
        {
            BindDataPart(ChonMonHocUC1.PK_sSubject);
        }

        protected void GoPart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SinhVien/HocTap.aspx?PK_sSubject=" + ChonMonHocUC1.PK_sSubject + "&PK_iPart=" + ChonBaiHocUC1.PK_iPart);
        }

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            pnlMonHoc.Visible = true;
            pnlBaiHoc.Visible = false;
        }
    }
}