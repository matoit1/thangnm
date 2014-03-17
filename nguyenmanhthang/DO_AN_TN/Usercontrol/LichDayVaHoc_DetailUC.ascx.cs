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
            ddlFK_sMaPCCT.DataSource = PhanCongCongTacDAO.PhanCongCongTac_SelectList();
            ddlFK_sMaPCCT.DataTextField = "PK_sMaPCCT";
            ddlFK_sMaPCCT.DataValueField = "PK_sMaPCCT";
            ddlFK_sMaPCCT.DataBind();

            ddlFK_sMalop.DataSource = LopHocDAO.LopHoc_SelectList();
            ddlFK_sMalop.DataTextField = "PK_sMalop";
            ddlFK_sMalop.DataValueField = "sTenlop";
            ddlFK_sMalop.DataBind();

            ddliCaHoc.DataSource = GetListConstants.LichDayVaHoc_iCaHoc_GLC();
            ddliCaHoc.DataTextField = "Value";
            ddliCaHoc.DataValueField = "Key";
            ddliCaHoc.DataBind();

            ddliTrangThai.DataSource = GetListConstants.LichDayVaHoc_iTrangThai_GLC();
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