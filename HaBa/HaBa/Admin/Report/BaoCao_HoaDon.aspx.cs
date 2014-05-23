using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using HaBa.EntityObject;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;

namespace HaBa.Admin.Report
{
    public partial class BaoCao_HoaDon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ClearMessages();
                    if (Request.QueryString["PK_lHoaDonID"] != null)
                    {
                        pnlSearch.Visible = false;
                        pnlReport.Visible = true;
                        if (CheckInput(Request.QueryString["PK_lHoaDonID"]))
                        {
                            ShowReport(Convert.ToInt64(Request.QueryString["PK_lHoaDonID"]));
                        }
                    }
                    else
                    {
                        pnlSearch.Visible = true;
                        pnlReport.Visible = false;
                    }
                }
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_lHoaDonID.Text = "";
        }

        public void ShowReport(Int64 PK_lHoaDonID)
        {
            try
            {
                ReportDocument crystalReport = new ReportDocument();
                crystalReport.Load(Server.MapPath("~/Admin/Report/HoaDonRP.rpt"));
                tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
                _tblHoaDonEO.PK_lHoaDonID = PK_lHoaDonID;
                _tblChiTietHoaDonEO.FK_lHoaDonID = PK_lHoaDonID;
                DataSet dsHaBa = new DataSet();
                DataTable dttblHoaDon = new DataTable();
                DataTable dttblChiTietHoaDon = new DataTable();
                dttblHoaDon = tblHoaDonDAO.HoaDon_SelectItemByPK_lHoaDonID(_tblHoaDonEO).Tables[0];
                dttblChiTietHoaDon = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectListByFK_lHoaDonID(_tblChiTietHoaDonEO).Tables[0];
                dttblHoaDon.Columns.Add(new DataColumn("FK_iTaiKhoanID_Giao_Text", Type.GetType("System.String")));
                dttblHoaDon.Columns.Add(new DataColumn("FK_iTaiKhoanID_Nhan_Text", Type.GetType("System.String")));
                dttblHoaDon.Columns.Add(new DataColumn("FK_iThanhToanID_Text", Type.GetType("System.String")));
                dttblHoaDon.Columns.Add(new DataColumn("iTrangThai_Text", Type.GetType("System.String")));
                dttblHoaDon.Columns.Add(new DataColumn("lTriGia", Type.GetType("System.Int64")));
                foreach (DataRow dr in dttblHoaDon.Rows)
                {
                    dr["FK_iTaiKhoanID_Giao_Text"] = tblTaiKhoanDAO.TaiKhoan_SelectItemByPK_iTaiKhoanID(Convert.ToInt32(dr["FK_iTaiKhoanID_Giao"])).sHoTen;
                    dr["FK_iTaiKhoanID_Nhan_Text"] = tblTaiKhoanDAO.TaiKhoan_SelectItemByPK_iTaiKhoanID(Convert.ToInt32(dr["FK_iTaiKhoanID_Nhan"])).sHoTen;
                    dr["FK_iThanhToanID_Text"] = tblThanhToanDAO.ThanhToan_SelectItemByPK_iThanhToanID(Convert.ToInt16(dr["FK_iThanhToanID"])).sTenThanhToan;
                    dr["iTrangThai_Text"] = GetTextConstants.HoaDon_iTrangThai_GTC(Convert.ToInt16(dr["iTrangThai"]));
                    dr["lTriGia"] = getlTriGia(Convert.ToInt64(dr["PK_lHoaDonID"]));
                }
                dttblHoaDon.TableName = "tblHoaDon";
                dttblChiTietHoaDon.TableName = "tblChiTietHoaDon";
                dsHaBa.Tables.Add(dttblHoaDon.Copy());
                dsHaBa.Tables.Add(dttblChiTietHoaDon.Copy());
                crystalReport.SetDataSource(dsHaBa);
                crvHoaDon.ReportSource = crystalReport;
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }

        public static Int64 getlTriGia(Int64 PK_lHoaDonID)
        {
            Int64 lTriGia = 0;
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblChiTietHoaDonEO.FK_lHoaDonID = PK_lHoaDonID;
            DataTable dt = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectListByFK_lHoaDonID(_tblChiTietHoaDonEO).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                lTriGia = lTriGia + (Convert.ToInt64(dr["lGiaBan"]) * Convert.ToInt16(dr["iSoLuong"]));
            }
            return lTriGia;
        }

        protected void btnBaoCao_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (pnlSearch.Visible == true)
            {
                pnlSearch.Visible = false;
                btnBaoCao.Text = "Hiện tìm kiếm";
            }
            else
            {
                pnlSearch.Visible = true;
                btnBaoCao.Text = "Ẩn tìm kiếm";
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (CheckInput(txtPK_lHoaDonID.Text))
            {
                pnlSearch.Visible = false;
                pnlReport.Visible = true;
                ShowReport(Convert.ToInt64(txtPK_lHoaDonID.Text));
            }
        }

        public bool CheckInput(string Input)
        {
            Int64 num64;
            if (string.IsNullOrEmpty(Input) == true)
            {
                lblMsg.Text = Messages.Khong_Duoc_De_Trong;
                return false;
            }
            else
            {
                bool isNum = Int64.TryParse(Input, out num64);
                if (isNum == false)
                {
                    lblMsg.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    return false;
                }
            }
            return true;
        }
    }
}