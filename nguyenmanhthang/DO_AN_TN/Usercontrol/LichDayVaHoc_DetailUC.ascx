<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LichDayVaHoc_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.LichDayVaHoc_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Lịch dạy và học"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã phân công công tác: </td>
            <td><asp:DropDownList ID="ddlFK_sMaPCCT" runat="server" Width="405px" 
                    ontextchanged="ddlFK_sMaPCCT_TextChanged"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaPCCT" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã lớp: </td>
            <td><asp:DropDownList ID="ddlFK_sMalop" runat="server" Width="405px" 
                    ontextchanged="ddlFK_sMalop_TextChanged"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMalop" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ca học: </td>
            <td><asp:DropDownList ID="ddliCaHoc" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lbliCaHoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày dạy: </td>
            <td><asp:TextBox ID="txttNgayDay" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayDay" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số tiết dạy: </td>
            <td><asp:TextBox ID="txtiSoTietDay" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliSoTietDay" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Sinh viên nghỉ: </td>
            <td><asp:TextBox ID="txtsSinhVienNghi" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsSinhVienNghi" runat="server"></asp:Label></td>
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