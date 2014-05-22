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

namespace HaBa.Report
{
    public partial class BaoCao_TaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlSearch.Visible = true;
                pnlReport.Visible = false;

                SortedList output = new SortedList();
                output = GetListConstants.TaiKhoan_iQuyenHan_GLC();
                output.Add(Convert.ToInt16(0), "Tất cả");
                ddliQuyenHan.DataSource = output;
                ddliQuyenHan.DataTextField = "Value";
                ddliQuyenHan.DataValueField = "Key";
                ddliQuyenHan.DataBind();

                output = GetListConstants.TaiKhoan_iTrangThai_GLC();
                output.Add(Convert.ToInt16(0), "Tất cả");
                ddliTrangThai.DataSource = output;
                ddliTrangThai.DataTextField = "Value";
                ddliTrangThai.DataValueField = "Key";
                ddliTrangThai.DataBind();


            }
        }

        protected void btnBaoCao_Click(object sender, EventArgs e)
        {
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
                crystalReport.Load(Server.MapPath("~/Report/TaiKhoanRP.rpt"));
                DataSet dsHaBa = new DataSet();
                DataTable dttblTaiKhoan = new DataTable();
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.iQuyenHan = Convert.ToInt16(ddliQuyenHan.SelectedValue);
                _tblTaiKhoanEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                dttblTaiKhoan = tblTaiKhoanDAO.TaiKhoan_SelectListByiQuyenHan_iTrangThai(_tblTaiKhoanEO).Tables[0];
                dttblTaiKhoan.Columns.Add(new DataColumn("iQuyenHan_Text", Type.GetType("System.String")));
                dttblTaiKhoan.Columns.Add(new DataColumn("iTrangThai_Text", Type.GetType("System.String")));
                foreach (DataRow dr in dttblTaiKhoan.Rows)
                {
                    dr["iQuyenHan_Text"] = GetTextConstants.TaiKhoan_iTrangThai_GTC(Convert.ToInt16(dr["iQuyenHan"]));
                    dr["iTrangThai_Text"] = GetTextConstants.TaiKhoan_iTrangThai_GTC(Convert.ToInt16(dr["iTrangThai"]));
                }
                dttblTaiKhoan.TableName = "tblTaiKhoan";
                dsHaBa.Tables.Add(dttblTaiKhoan.Copy());
                crystalReport.SetDataSource(dsHaBa);
                crvTaiKhoan.ReportSource = crystalReport;
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}