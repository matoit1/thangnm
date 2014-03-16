using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class PhanCongCongTac_DetailUC : System.Web.UI.UserControl
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
            ddlFK_sMaGV.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlFK_sMaGV.DataTextField = "Value";
            ddlFK_sMaGV.DataValueField = "Key";
            ddlFK_sMaGV.DataBind();

            ddlFK_sMaMonhoc.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlFK_sMaMonhoc.DataTextField = "Value";
            ddlFK_sMaMonhoc.DataValueField = "Key";
            ddlFK_sMaMonhoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.SinhVien_iTrangThaiSV_GLC();
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