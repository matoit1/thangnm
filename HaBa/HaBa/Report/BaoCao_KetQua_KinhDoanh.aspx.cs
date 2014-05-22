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
using System.Collections;

namespace HaBa.Report
{
    public partial class BaoCao_KetQua_KinhDoanh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlSearch.Visible = true;
                pnlReport.Visible = false;
                ddlThang.SelectedValue = DateTime.Now.Month.ToString();
                txtNam.Text = DateTime.Now.Year.ToString();

                SortedList output = new SortedList();
                output = GetListConstants.HoaDon_iTrangThai_GLC();
                output.Add(Convert.ToInt16(0), "Tất cả");
                ddliTrangThai.DataSource = output;
                ddliTrangThai.DataTextField = "Value";
                ddliTrangThai.DataValueField = "Key";
                ddliTrangThai.DataBind();
            }
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

        protected void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (pnlSearch.Visible == true)
            {
                pnlSearch.Visible = false;
            }
            else{
                pnlSearch.Visible = true;
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlReport.Visible = true;
            try
            {
                if (CheckInput() == true)
                {
                    ReportDocument crystalReport = new ReportDocument();
                    crystalReport.Load(Server.MapPath("~/Report/KetQua_KinhDoanhRP.rpt"));
                    DataSet dsHaBa = new DataSet();
                    DataTable dttblHoaDon = new DataTable();
                    dttblHoaDon = tblHoaDonDAO.HoaDon_SelectListByiTrangThai_ThangNam(Convert.ToInt16(ddliTrangThai.SelectedValue), Convert.ToInt16(ddlThang.SelectedValue),Convert.ToInt16(txtNam.Text)).Tables[0];
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
                    crystalReport.SetParameterValue("pThangNam", ddlThang.SelectedValue + "/" + txtNam.Text);
                    crvKetQuaKinhDoanh.ReportSource = crystalReport;
                }
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }

        public bool CheckInput()
        {
            Int16 num16;
            if (string.IsNullOrEmpty(txtNam.Text) == true)
            {
                lblNam.Text = Messages.Truong_Bat_Buoc;
                txtNam.Focus();
                return false;
            }
            else
            {
                bool isNum = Int16.TryParse(txtNam.Text, out num16);
                if (isNum == false)
                {
                    lblNam.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtNam.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}