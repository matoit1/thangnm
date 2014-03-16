using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class LichDayVaHoc_DetailUC : System.Web.UI.UserControl
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
            ddlFK_sMaPCCT.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlFK_sMaPCCT.DataTextField = "Value";
            ddlFK_sMaPCCT.DataValueField = "Key";
            ddlFK_sMaPCCT.DataBind();

            ddlFK_sMalop.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlFK_sMalop.DataTextField = "Value";
            ddlFK_sMalop.DataValueField = "Key";
            ddlFK_sMalop.DataBind();

            ddliCaHoc.DataSource = GetListConstants.LichDayVaHoc_iCaHoc_GLC();
            ddliCaHoc.DataTextField = "Value";
            ddliCaHoc.DataValueField = "Key";
            ddliCaHoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.LichDayVaHoc_iCaHoc_GLC();
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