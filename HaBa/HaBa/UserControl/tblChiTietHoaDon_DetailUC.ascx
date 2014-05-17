<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblChiTietHoaDon_DetailUC.ascx.cs" Inherits="HaBa.UserControl.tblChiTietHoaDon_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin chi tiết hóa đơn" CssClass="form_tittle"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã hóa đơn: </td>
            <td><asp:DropDownList ID="ddlFK_lHoaDonID" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_lHoaDonID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã sản phẩm: </td>
            <td><asp:DropDownList ID="ddlFK_sSanPhamID" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sSanPhamID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Giá bán: </td>
            <td><asp:TextBox ID="txtlGiaBan" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbllGiaBan" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số lượng: </td>
            <td><asp:TextBox ID="txtiSoLuong" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliSoLuong" runat="server"></asp:Label></td>
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