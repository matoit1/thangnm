using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.DataAccessObject;
using System.Data;

namespace HaBa.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            DataSet ds = tblTaiKhoanDAO.ThongKeThongTin();
            lblTongTaiKhoan.Text = ds.Tables[0].Rows[0]["TongTaiKhoan"].ToString();
            lblTongTaiKhoanQuanTri.Text = ds.Tables[0].Rows[0]["TongTaiKhoanQuanTri"].ToString();
            lblTongTaiKhoanNhanVien.Text = ds.Tables[0].Rows[0]["TongTaiKhoanNhanVien"].ToString();
            lblTongTaiKhoanKhachHang.Text = ds.Tables[0].Rows[0]["TongTaiKhoanKhachHang"].ToString();
            lblTongNhomSanPham.Text = ds.Tables[0].Rows[0]["TongNhomSanPham"].ToString();
            lblTongNhomSanPhamMo.Text = ds.Tables[0].Rows[0]["TongNhomSanPhamMo"].ToString();
            lblTongNhomSanPhamKhoa.Text = ds.Tables[0].Rows[0]["TongNhomSanPhamKhoa"].ToString();
            lblTongSanPham.Text = ds.Tables[0].Rows[0]["TongSanPham"].ToString();
            lblTongSanPhamMo.Text = ds.Tables[0].Rows[0]["TongSanPhamMo"].ToString();
            lblTongSanPhamHetHang.Text = ds.Tables[0].Rows[0]["TongSanPhamHetHang"].ToString();
            lblTongSanPhamKhoa.Text = ds.Tables[0].Rows[0]["TongSanPhamKhoa"].ToString();
            lblTongHoaDon.Text = ds.Tables[0].Rows[0]["TongHoaDon"].ToString();
            lblTongHoaDonChuaKiemTra.Text = ds.Tables[0].Rows[0]["TongHoaDonChuaKiemTra"].ToString();
            lblTongHoaDonChuaGiaoHang.Text = ds.Tables[0].Rows[0]["TongHoaDonChuaGiaoHang"].ToString();
            lblTongHoaDonDaGiaoHang.Text = ds.Tables[0].Rows[0]["TongHoaDonDaGiaoHang"].ToString();
            lblTongHoaDonDaHuy.Text = ds.Tables[0].Rows[0]["TongHoaDonDaHuy"].ToString();
            lblTongThanhToan.Text = ds.Tables[0].Rows[0]["TongThanhToan"].ToString();
            lblTongThanhToanMo.Text = ds.Tables[0].Rows[0]["TongThanhToanMo"].ToString();
            lblTongThanhToanXemXet.Text = ds.Tables[0].Rows[0]["TongThanhToanXemXet"].ToString();
            lblTongThanhToanKhoa.Text = ds.Tables[0].Rows[0]["TongThanhToanKhoa"].ToString();
        }
    }
}