using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class SinhVien_DetailUC : System.Web.UI.UserControl
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
            ddlbGioitinhSV.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlbGioitinhSV.DataTextField = "Value";
            ddlbGioitinhSV.DataValueField = "Key";
            ddlbGioitinhSV.DataBind();

            ddlbHonNhanSV.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlbHonNhanSV.DataTextField = "Value";
            ddlbHonNhanSV.DataValueField = "Key";
            ddlbHonNhanSV.DataBind();

            ddliQuanHeVoiNguoiLienHeSV.DataSource = GetListConstants.SinhVien_iQuanHeVoiNguoiLienHeSV_GLC();
            ddliQuanHeVoiNguoiLienHeSV.DataTextField = "Value";
            ddliQuanHeVoiNguoiLienHeSV.DataValueField = "Key";
            ddliQuanHeVoiNguoiLienHeSV.DataBind();

            ddlbKetnapDoanSV.DataSource = GetListConstants.SinhVien_bKetnapDoanSV_GLC();
            ddlbKetnapDoanSV.DataTextField = "Value";
            ddlbKetnapDoanSV.DataValueField = "Key";
            ddlbKetnapDoanSV.DataBind();

            ddliTrangThaiSV.DataSource = GetListConstants.SinhVien_iTrangThaiSV_GLC();
            ddliTrangThaiSV.DataTextField = "Value";
            ddliTrangThaiSV.DataValueField = "Key";
            ddliTrangThaiSV.DataBind();
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