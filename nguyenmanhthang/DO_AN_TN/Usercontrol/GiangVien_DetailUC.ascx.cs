using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class GiangVien_DetailUC : System.Web.UI.UserControl
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
            ddlbGioitinhGV.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlbGioitinhGV.DataTextField = "Value";
            ddlbGioitinhGV.DataValueField = "Key";
            ddlbGioitinhGV.DataBind();

            ddlbHonNhanGV.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlbHonNhanGV.DataTextField = "Value";
            ddlbHonNhanGV.DataValueField = "Key";
            ddlbHonNhanGV.DataBind();

            ddlbiChucVuGV.DataSource = GetListConstants.GiangVien_iChucVuGV_GLC();
            ddlbiChucVuGV.DataTextField = "Value";
            ddlbiChucVuGV.DataValueField = "Key";
            ddlbiChucVuGV.DataBind();

            ddliHocViGV.DataSource = GetListConstants.GiangVien_iHocViGV_GLC();
            ddliHocViGV.DataTextField = "Value";
            ddliHocViGV.DataValueField = "Key";
            ddliHocViGV.DataBind();

            ddlbCongChucGV.DataSource = GetListConstants.GiangVien_bCongChucGV_GLC();
            ddlbCongChucGV.DataTextField = "Value";
            ddlbCongChucGV.DataValueField = "Key";
            ddlbCongChucGV.DataBind();

            ddliTrangThaiGV.DataSource = GetListConstants.GiangVien_iTrangThaiGV_GLC();
            ddliTrangThaiGV.DataTextField = "Value";
            ddliTrangThaiGV.DataValueField = "Key";
            ddliTrangThaiGV.DataBind();
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