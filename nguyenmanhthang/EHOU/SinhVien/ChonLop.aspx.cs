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

namespace EHOU.SinhVien
{
    public partial class ChonLop : System.Web.UI.Page
    {

        public string MaMonHoc
        {
            get { return (string)ViewState["MaMonHoc"]; }
            set { ViewState["MaMonHoc"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_sSubject"] != null)
                    {
                        MaMonHoc = Request.QueryString["PK_sSubject"];
                        BindDataClass(MaMonHoc);
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
                pnlLopHoc.Visible = true;
                pnlBaiHoc.Visible = false;
                DataSet ds = tblSubjectDAO.Subject_SelectList();
                rbtnlListClass.DataSource = ds.Tables[0];
                rbtnlListClass.DataTextField = "sName";
                rbtnlListClass.DataValueField = "PK_sSubject";
                rbtnlListClass.DataBind();
            }
            catch
            {
            }
        }

        public void BindDataClass(string _PK_sSubject)
        {
            try
            {
                pnlLopHoc.Visible = false;
                pnlBaiHoc.Visible = true;
                MaMonHoc = _PK_sSubject;
                tblDetailEO _tblDetailEO = new tblDetailEO();
                _tblDetailEO.FK_sSubject =_PK_sSubject;
                _tblDetailEO.FK_sStudent = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value)["username"].ToString();
                rbtnlListSubject.DataSource = tblDetailDAO.SelectByFK_sSubject_FK_sStudent(_tblDetailEO);
                rbtnlListSubject.DataTextField = "sTitle";
                rbtnlListSubject.DataValueField = "PK_lCaHoc";
                rbtnlListSubject.DataBind();
            }
            catch
            {
            }
        }

        protected void rbtnlListClass_TextChanged(object sender, EventArgs e)
        {
            BindDataClass(rbtnlListClass.SelectedValue);
        }

        protected void rbtnlListSubject_TextChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/SinhVien/HocTap.aspx?PK_sSubject=" + MaMonHoc + "&lCaHoc=" + rbtnlListSubject.SelectedValue);
        }
    }
}