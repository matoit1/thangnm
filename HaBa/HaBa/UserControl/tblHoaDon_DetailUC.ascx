<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblHoaDon_DetailUC.ascx.cs" Inherits="HaBa.UserControl.tblHoaDon_DetailUC" %>
<link href="../App_Themes/calendar.css" rel="stylesheet" type="text/css"/>  
<script src="../Scripts/calendar1.js" type="text/javascript"></script>  
<script src="../Scripts/calendar2.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
    });
</script>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin hóa đơn" CssClass="form_tittle"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã hóa đơn: </td>
            <td><asp:TextBox ID="txtPK_lHoaDonID" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_lHoaDonID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã tài khoản giao: </td>
            <td><asp:DropDownList ID="ddlFK_iTaiKhoanID_Giao" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iTaiKhoanID_Giao" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã tài khoản nhận: </td>
            <td><asp:DropDownList ID="ddlFK_iTaiKhoanID_Nhan" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iTaiKhoanID_Nhan" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã thanh toán: </td>
            <td><asp:DropDownList ID="ddlFK_iThanhToanID" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iThanhToanID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ tên người nhận: </td>
            <td><asp:TextBox ID="txtsHoTen" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsHoTen" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtsEmail" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ: </td>
            <td><asp:TextBox ID="txtsDiaChi" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsDiaChi" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số điện thoại: </td>
            <td><asp:TextBox ID="txtsSoDienThoai" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsSoDienThoai" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ghi chú: </td>
            <td><asp:TextBox ID="txtsGhiChu" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsGhiChu" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày đặt hàng: </td>
            <td><asp:TextBox ID="txttNgayDatHang" runat="server" Width="400px" CssClass="startdate" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayDatHang" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày giao hàng: </td>
            <td><asp:TextBox ID="txttNgayGiaoHang" runat="server" Width="400px" CssClass="startdate" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayGiaoHang" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
    </table>
</div>