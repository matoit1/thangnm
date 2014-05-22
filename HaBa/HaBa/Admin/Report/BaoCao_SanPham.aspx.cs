using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using HaBa.App_Data;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries;
using System.Collections;
using HaBa.EntityObject;

namespace HaBa.Admin.Report
{
    public partial class BaoCao_SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                pnlSearch.Visible = true;
                pnlReport.Visible = false;

                DataSet ds = tblNhomSanPhamDAO.NhomSanPham_SelectList();
                DataRow DefaultGroup = ds.Tables[0].NewRow();
                DefaultGroup["PK_iNhomSanPhamID"] = 0;
                DefaultGroup["sTenNhom"] = "Tất cả";
                ds.Tables[0].Rows.InsertAt(DefaultGroup,0);
                ddlFK_iNhomSanPhamID.DataSource = ds;
                ddlFK_iNhomSanPhamID.DataTextField = "sTenNhom";
                ddlFK_iNhomSanPhamID.DataValueField = "PK_iNhomSanPhamID";
                ddlFK_iNhomSanPhamID.DataBind();

                SortedList output = new SortedList();
                output = GetListConstants.SanPham_iTrangThai_GLC();
                output.Add(Convert.ToInt16(0), "Tất cả");
                ddliTrangThai.DataSource = output;
                ddliTrangThai.DataTextField = "Value";
                ddliTrangThai.DataValueField = "Key";
                ddliTrangThai.DataBind();
            }
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblFK_iNhomSanPhamID.Text = "";
            lbliTrangThai.Text = "";
        }

        protected void btnBaoCao_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (pnlSearch.Visible == true)
            {
                pnlSearch.Visible = false;
            }
            else
            {
                pnlSearch.Visible = true;
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlReport.Visible = true;
            try
            {
                ReportDocument crystalReport = new ReportDocument();
                crystalReport.Load(Server.MapPath("~/Admin/Report/SanPhamRP.rpt"));
                DataSet dsHaBa = new DataSet();
                DataTable dttblSanPham = new DataTable();
                tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                _tblSanPhamEO.FK_iNhomSanPhamID = Convert.ToInt16(ddlFK_iNhomSanPhamID.SelectedValue);
                _tblSanPhamEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                dttblSanPham = tblSanPhamDAO.SanPham_SelectListByFK_iNhomSanPhamID_iTrangThai(_tblSanPhamEO).Tables[0];
                dttblSanPham.Columns.Add(new DataColumn("FK_iNhomSanPhamID_Text", Type.GetType("System.String")));
                dttblSanPham.Columns.Add(new DataColumn("iDoTuoi_Text", Type.GetType("System.String")));
                dttblSanPham.Columns.Add(new DataColumn("iGioiTinh_Text", Type.GetType("System.String")));
                dttblSanPham.Columns.Add(new DataColumn("iTrangThai_Text", Type.GetType("System.String")));
                foreach (DataRow dr in dttblSanPham.Rows)
                {
                    dr["FK_iNhomSanPhamID_Text"] = tblNhomSanPhamDAO.NhomSanPham_SelectItem_By_PK_iNhomSanPhamID(Convert.ToInt16(dr["FK_iNhomSanPhamID"])).sTenNhom;
                    dr["iDoTuoi_Text"] = GetTextConstants.SanPham_iDoTuoi_GTC(Convert.ToInt16(dr["iDoTuoi"]));
                    dr["iGioiTinh_Text"] = GetTextConstants.SanPham_iGioiTinh_GTC(Convert.ToInt16(dr["iGioiTinh"]));
                    dr["iTrangThai_Text"] = GetTextConstants.SanPham_iTrangThai_GTC(Convert.ToInt16(dr["iTrangThai"]));
                }
                dttblSanPham.TableName = "tblSanPham";
                dsHaBa.Tables.Add(dttblSanPham.Copy());
                crystalReport.SetDataSource(dsHaBa);
                crvSanPham.ReportSource = crystalReport;
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}