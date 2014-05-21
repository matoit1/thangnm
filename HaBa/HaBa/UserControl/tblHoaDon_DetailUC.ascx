<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblHoaDon_DetailUC.ascx.cs" Inherits="HaBa.UserControl.tblHoaDon_DetailUC" %>
<link href="../App_Themes/calendar.css" rel="stylesheet" type="text/css"/>  
<script src="../Scripts/calendar1.js" type="text/javascript"></script>  
<script src="../Scripts/calendar2.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $(".startdate").datepicker({ dateFormat: "mm/dd/yy" }).val()
        $(".enddate").datepicker({ dateFormat: "mm/dd/yy" }).val()
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
            <td>Nhân viên: </td>
            <td><asp:DropDownList ID="ddlFK_iTaiKhoanID_Giao" runat="server" Width="405px" 
                    TabIndex="1"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iTaiKhoanID_Giao" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Khách Hàng: </td>
            <td><asp:DropDownList ID="ddlFK_iTaiKhoanID_Nhan" runat="server" Width="405px" 
                    TabIndex="2"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iTaiKhoanID_Nhan" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Hình thức thanh toán: </td>
            <td><asp:DropDownList ID="ddlFK_iThanhToanID" runat="server" Width="405px" 
                    TabIndex="3"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iThanhToanID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ tên người nhận: </td>
            <td><asp:TextBox ID="txtsHoTen" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="4"></asp:TextBox></td>
            <td><asp:Label ID="lblsHoTen" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtsEmail" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ: </td>
            <td><asp:TextBox ID="txtsDiaChi" runat="server" Width="400px" MaxLength="500" 
                    TabIndex="6"></asp:TextBox></td>
            <td><asp:Label ID="lblsDiaChi" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số điện thoại: </td>
            <td><asp:TextBox ID="txtsSoDienThoai" runat="server" Width="400px" MaxLength="13" 
                    TabIndex="7"></asp:TextBox></td>
            <td><asp:Label ID="lblsSoDienThoai" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ghi chú: </td>
            <td><asp:TextBox ID="txtsGhiChu" runat="server" Width="400px" MaxLength="500" 
                    TabIndex="8"></asp:TextBox></td>
            <td><asp:Label ID="lblsGhiChu" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày đặt hàng: </td>
            <td><asp:TextBox ID="txttNgayDatHang" runat="server" Width="400px" 
                    CssClass="startdate" Enabled="false" TabIndex="9"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayDatHang" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày giao hàng: </td>
            <td><asp:TextBox ID="txttNgayGiaoHang" runat="server" Width="400px" 
                    CssClass="startdate" Enabled="false" TabIndex="10"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayGiaoHang" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px" TabIndex="11"></asp:DropDownList></td>
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
                <asp:Button ID="btnInsert" runat="server" Text="Insert" 
                    onclick="btnInsert_Click" TabIndex="12" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="13" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="14" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="15" />
            </td>
            <td></td>
        </tr>
    </table>
</div>