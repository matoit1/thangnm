<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HaBa.Admin.Default" MasterPageFile="~/ShareInterface/AdminSI.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
<%--    <script type="text/javascript">
        window.location.href = "../Admin/ThongTinCaNhan.aspx"
	</script>--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div class="sortable row-fluid">
		<a class="quick-button span2">
			<i class="icon-user"></i>
			<p>Tổng Tài khoản</p>
			<span class="notification green"><asp:Label ID="lblTongTaiKhoan" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-user"></i>
			<p>Tài khoản Quản trị</p>
			<span class="notification green"><asp:Label ID="lblTongTaiKhoanQuanTri" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-user"></i>
			<p>Tài khoản Nhân viên</p>
			<span class="notification green"><asp:Label ID="lblTongTaiKhoanNhanVien" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-user"></i>
			<p>Tài khoản Khách hàng</p>
			<span class="notification green"><asp:Label ID="lblTongTaiKhoanKhachHang" runat="server"></asp:Label></span>
		</a>
    </div><hr /><br /><br />
    <div class="sortable row-fluid">
		<a class="quick-button span2">
			<i class="icon-tags"></i>
			<p>Tổng Nhóm sản phẩm</p>
			<span class="notification green"><asp:Label ID="lblTongNhomSanPham" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-tags"></i>
			<p>Nhóm sản phẩm Mở</p>
			<span class="notification"><asp:Label ID="lblTongNhomSanPhamMo" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-tags"></i>
			<p>Nhóm sản phẩm Khóa</p>
			<span class="notification red"><asp:Label ID="lblTongNhomSanPhamKhoa" runat="server"></asp:Label></span>
		</a>
    </div><hr /><br /><br />
    <div class="sortable row-fluid">
		<a class="quick-button span2">
			<i class="icon-tag"></i>
			<p>Tổng Sản phẩm</p>
			<span class="notification green"><asp:Label ID="lblTongSanPham" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-tag"></i>
			<p>Sản phẩm Mở</p>
			<span class="notification"><asp:Label ID="lblTongSanPhamMo" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-tag"></i>
			<p>Sản phẩm Hết hàng</p>
			<span class="notification yellow"><asp:Label ID="lblTongSanPhamHetHang" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-tag"></i>
			<p>Sản phẩm Khóa</p>
			<span class="notification red"><asp:Label ID="lblTongSanPhamKhoa" runat="server"></asp:Label></span>
		</a>
    </div><hr /><br /><br />
    <div class="sortable row-fluid">
		<a class="quick-button span2">
			<i class="icon-file"></i>
			<p>Hóa đơn</p>
			<span class="notification green"><asp:Label ID="lblTongHoaDon" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-file"></i>
			<p>Hóa đơn Chưa kiểm tra</p>
			<span class="notification"><asp:Label ID="lblTongHoaDonChuaKiemTra" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-file"></i>
			<p>Hóa đơn Chưa giao hàng</p>
			<span class="notification yellow"><asp:Label ID="lblTongHoaDonChuaGiaoHang" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-file"></i>
			<p>Hóa đơn Đã giao hàng</p>
			<span class="notification"><asp:Label ID="lblTongHoaDonDaGiaoHang" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-file"></i>
			<p>Hóa đơn Đã hủy</p>
			<span class="notification red"><asp:Label ID="lblTongHoaDonDaHuy" runat="server"></asp:Label></span>
		</a>
    </div><hr /><br /><br />
    <div class="sortable row-fluid">
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Thanh toán</p>
			<span class="notification green"><asp:Label ID="lblTongThanhToan" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Thanh toán Mở</p>
			<span class="notification"><asp:Label ID="lblTongThanhToanMo" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Thanh toán Xem xét</p>
			<span class="notification yellow"><asp:Label ID="lblTongThanhToanXemXet" runat="server"></asp:Label></span>
		</a>
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Thanh toán Khóa</p>
			<span class="notification red"><asp:Label ID="lblTongThanhToanKhoa" runat="server"></asp:Label></span>
		</a>
    </div><hr /><br /><br />
    <div class="sortable row-fluid">
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Báo cáo Sản phẩm</p>
		</a>
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Báo cáo Khách hàng</p>
		</a>
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>Báo cáo Kết quả Kinh doanh</p>
		</a>
		<a class="quick-button span2">
			<i class="icon-plane"></i>
			<p>In hóa đơn</p>
		</a>
    </div><hr /><br /><br />
</asp:Content>