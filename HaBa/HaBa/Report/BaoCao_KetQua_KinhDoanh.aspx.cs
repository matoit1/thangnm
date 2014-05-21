using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries;
using HaBa.EntityObject;

namespace HaBa.Report
{
    public partial class BaoCao_KetQua_KinhDoanh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                    ReportDocument crystalReport = new ReportDocument();
                    crystalReport.Load(Server.MapPath("~/Report/KetQua_KinhDoanhRP.rpt"));
                    DataSet dsHaBa = new DataSet();
                    DataTable dttblHoaDon = new DataTable();
                    dttblHoaDon = tblHoaDonDAO.HoaDon_SelectList().Tables[0];
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
                    dsHaBa.Tables.Add(dttblHoaDon.Copy());
                    crystalReport.SetDataSource(dsHaBa);
                    crvKetQuaKinhDoanh.ReportSource = crystalReport;
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }

        public static Int64 getlTriGia(Int64 PK_lHoaDonID)
        {
            Int64 lTriGia = 0;
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblChiTietHoaDonEO.FK_lHoaDonID = PK_lHoaDonID;
            DataTable dt = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectByFK_lHoaDonID(_tblChiTietHoaDonEO).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                lTriGia = lTriGia + (Convert.ToInt64(dr["lGiaBan"]) * Convert.ToInt16(dr["iSoLuong"]));
            }
            return lTriGia;
        }
    }
}