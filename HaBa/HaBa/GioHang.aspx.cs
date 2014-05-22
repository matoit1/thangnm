using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.EntityObject;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries;

namespace HaBa
{
    public partial class GioHang : System.Web.UI.Page
    {
        public DataTable tb = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMsg.Text = "";
                hplLogin.Visible = false;
                hplRegister.Visible = false;
                pnlThanhToan.Visible = false;
                loadPayMethod();
                if (Request.Cookies["HaBa_client"] != null)
                {
                    tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["HaBa_client"].Value;
                    _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                    txtsHoTen.Text = _tblTaiKhoanEO.sHoTen;
                    txtsEmail.Text = _tblTaiKhoanEO.sEmail;
                    txtsDiaChi.Text = _tblTaiKhoanEO.sDiaChi;
                    txtsSoDienThoai.Text = _tblTaiKhoanEO.sSoDienThoai;
                }
                tb = (DataTable)Session["GioHang"];
                if (tb != null)
                {
                    if (tb.Rows.Count > 0)
                    {
                        grvGioHang.DataSource = tb;
                        grvGioHang.DataBind();
                    }
                    lblTongtien.Text = tongtien(tb).ToString();
                }
                txttNgayGiaoHang.Text = DateTime.Now.ToString(Messages.Format_DateTimeMMDDYYYY);
            }
            lblNotify.Text = "";
            if (Session["GioHang"] == null || ((DataTable)Session["GioHang"]).Rows.Count == 0)
            {
                pnlGioHang.Visible = false;
                lblNotify.Text = Messages.tblSanPham_Gio_Hang_Chua_Co_San_Pham_Nao;
            }
            else{
                pnlGioHang.Visible = true;
            }
        }

        public void loadPayMethod()
        {
            ddlFK_iThanhToanID.DataSource = tblThanhToanDAO.ThanhToan_SelectList();
            ddlFK_iThanhToanID.DataTextField = "sTenThanhToan";
            ddlFK_iThanhToanID.DataValueField = "PK_iThanhToanID";
            ddlFK_iThanhToanID.DataBind();
        }

        // Tính tổng số tiền
        public float tongtien(DataTable tb)
        {
            Int64 invoice_Total = 0;
            try
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    invoice_Total = invoice_Total + Int64.Parse(tb.Rows[i]["lThanhTien"].ToString());
                }
            }
            catch { }
            return invoice_Total;
        }

        protected void imgbtnUpdate_Click(object sender, ImageClickEventArgs e)
        {
            tb = (DataTable)Session["GioHang"];
            for (int i = 0; i < grvGioHang.Rows.Count; i++)
            {
                TextBox sl = (TextBox)grvGioHang.Rows[i].FindControl("txtsl");
                int soluong = int.Parse(sl.Text);
                //cập nhật số lượng cho giỏ hàng
                tb.Rows[i]["iSoLuong"] = soluong;
                //lấy đơn giá của hàng từ giỏ hàng về. 
                Int64 g = Int64.Parse(tb.Rows[i]["lGiaBan"].ToString());
                //cập nhật tổng giá cho giỏ hàng.
                tb.Rows[i]["lThanhTien"] = g * soluong;
            }
            //load dữ liệu lại cho Gridview
            grvGioHang.DataSource = tb;
            grvGioHang.DataBind();
            //hiển thị tổng tiền.
            lblTongtien.Text = Convert.ToUInt64(tongtien(tb)).ToString();
        }
        public void updateThanhTien_GioHang(DataTable tb, int row, int sl, Int64 gia)
        {
            //double tt = sl * gia;
            DataRow r = tb.Rows[row];
            r["lThanhTien"] = Int64.Parse(r["lGiaBan"].ToString()) * sl;
        }

        protected void imgbtnPay_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (Request.Cookies["HaBa_client"].Value != null)
                {
                    lblMsg.Text = "";
                    hplLogin.Visible = false;
                    hplRegister.Visible = false;

                    tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["HaBa_client"].Value;
                    _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                    int CategoryID = Convert.ToInt32(Request.QueryString["CategoryID"]);
                    tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
                    _tblHoaDonEO.FK_iTaiKhoanID_Nhan = _tblTaiKhoanEO.PK_iTaiKhoanID;
                    _tblHoaDonEO.FK_iThanhToanID = Convert.ToInt16(ddlFK_iThanhToanID.SelectedValue);
                    _tblHoaDonEO.sHoTen = txtsHoTen.Text;
                    _tblHoaDonEO.sEmail = txtsEmail.Text;
                    _tblHoaDonEO.sDiaChi = txtsDiaChi.Text;
                    _tblHoaDonEO.sSoDienThoai = txtsSoDienThoai.Text;
                    _tblHoaDonEO.sGhiChu = txtsGhiChu.Text;
                    _tblHoaDonEO.tNgayGiaoHang = Convert.ToDateTime(txttNgayGiaoHang.Text);
                    _tblHoaDonEO.PK_lHoaDonID = tblHoaDonDAO.HoaDon_Insert_Get_PK_lHoaDonID_New(_tblHoaDonEO);
                    tb = (DataTable)Session["GioHang"];
                    tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        _tblChiTietHoaDonEO.FK_lHoaDonID = _tblHoaDonEO.PK_lHoaDonID;
                        _tblChiTietHoaDonEO.FK_sSanPhamID = Convert.ToString(tb.Rows[i]["PK_sSanPhamID"]);
                        _tblChiTietHoaDonEO.lGiaBan = Convert.ToInt64(tb.Rows[i]["lGiaBan"]);
                        _tblChiTietHoaDonEO.iSoLuong = Convert.ToInt16(tb.Rows[i]["iSoLuong"]);

                        tblChiTietHoaDonDAO.ChiTietHoaDon_Insert(_tblChiTietHoaDonEO);
                    }
                    lblNotify.Text = Messages.tblSanPham_Dat_Hang_Thanh_Cong;
                    hplPK_lHoaDonID.Text = Messages.tblSanPham_Xem_Lai_Hoa_Don;
                    hplPK_lHoaDonID.NavigateUrl = "~/Client/HoaDon.aspx?PK_lHoaDonID=" + _tblHoaDonEO.PK_lHoaDonID;
                    pnlGioHang.Visible = false;
                    pnlThanhToan.Visible = false;
                    Session["GioHang"] = null;
                }
                else
                {
                    lblMsg.Text = "Bạn có tài khoản chưa? ";
                    hplLogin.Visible = true;
                    hplRegister.Visible = true;
                }
            }
            catch
            {
                lblMsg.Text = "Bạn có tài khoản chưa? ";
                hplLogin.Visible = true;
                hplRegister.Visible = true;
            }
        }

        protected void imgbtnDeleteCart_Click(object sender, ImageClickEventArgs e)
        {
            Session["GioHang"] = null;
            Response.Redirect("~/Default.aspx");
        }

        protected void grvGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int chiso = int.Parse(e.CommandArgument.ToString());
                try
                {
                    DataTable dt = (DataTable)Session["GioHang"];
                    dt.Rows.RemoveAt(chiso);
                    Session["GioHang"] = dt;
                    Response.Redirect("~/GioHang.aspx");
                }
                catch
                {
                    Response.Redirect("~/GioHang.aspx");
                }
            }
        }

        protected void grvGioHang_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                    _tblSanPhamEO.PK_sSanPhamID = Convert.ToString(grvGioHang.DataKeys[e.Row.RowIndex].Values["PK_sSanPhamID"]);
                    HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                    URL1.NavigateUrl = "~/SanPham.aspx?PK_sSanPhamID=" + _tblSanPhamEO.PK_sSanPhamID;
                }
            }
            catch { }
        }

        protected void grvGioHang_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvGioHang.PageIndex = e.NewPageIndex;
        }

        protected void imgbtnBuy_Click(object sender, ImageClickEventArgs e)
        {
            if (pnlThanhToan.Visible == true)
            {
                pnlThanhToan.Visible = false;
            }
            else
            {
                pnlThanhToan.Visible = true;
            }
            CheckNguoiNhan(Convert.ToBoolean(rblCheck.SelectedValue));
        }

        protected void rblCheck_TextChanged(object sender, EventArgs e)
        {
            CheckNguoiNhan(Convert.ToBoolean(rblCheck.SelectedValue));
        }


        public void CheckNguoiNhan(bool isWho)
        {
            try
            {
                txtsHoTen.Enabled = isWho;
                txtsEmail.Enabled = isWho;
                txtsDiaChi.Enabled = isWho;
                txtsSoDienThoai.Enabled = isWho;

                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["HaBa_client"].Value;
                _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                if (isWho == true)
                {
                    txtsHoTen.Text = "";
                    txtsEmail.Text = "";
                    txtsDiaChi.Text = "";
                    txtsSoDienThoai.Text = "";
                }
                else
                {
                    txtsHoTen.Text = _tblTaiKhoanEO.sHoTen;
                    txtsEmail.Text = _tblTaiKhoanEO.sEmail;
                    txtsDiaChi.Text = _tblTaiKhoanEO.sDiaChi;
                    txtsSoDienThoai.Text = _tblTaiKhoanEO.sSoDienThoai;
                }
            }
            catch { }
        }
    }
}