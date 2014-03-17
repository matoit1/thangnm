using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using DataAccessObject;

namespace DO_AN_TN.UserControl
{
    public partial class DiemThi_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_sMaSV.DataSource = SinhVienDAO.SinhVien_SelectList();
            ddlFK_sMaSV.DataTextField = "sHotenSV";
            ddlFK_sMaSV.DataValueField = "PK_sMaSV";
            ddlFK_sMaSV.DataBind();

            ddlFK_sMaMonhoc.DataSource = MonHocDAO.MonHoc_SelectList();
            ddlFK_sMaMonhoc.DataTextField = "sTenMonhoc";
            ddlFK_sMaMonhoc.DataValueField = "PK_sMaMonhoc";
            ddlFK_sMaMonhoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.DiemThi_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnExport_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}