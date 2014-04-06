<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PhanCongCongTac_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.PhanCongCongTac_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Môn học"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã phân công công tác: </td>
            <td><asp:TextBox ID="txtPK_sMaPCCT" runat="server" Width="400px" ontextchanged="txtPK_sMaPCCT_TextChanged"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sMaPCCT" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã giảng viên: </td>
            <td><asp:DropDownList ID="ddlFK_sMaGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã môn học: </td>
            <td><asp:DropDownList ID="ddlFK_sMaMonhoc" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaMonhoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày bắt đầu: </td>
            <td><asp:TextBox ID="txttNgayBatDau" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayBatDau" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày kết thúc: </td>
            <td><asp:TextBox ID="txttNgayKetThuc" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayKetThuc" runat="server"></asp:Label></td>
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