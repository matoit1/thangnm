<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CauHoi_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.CauHoi_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Câu hỏi"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã giảng viên: </td>
            <td><asp:DropDownList ID="ddlFK_sMaGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã câu hỏi: </td>
            <td><asp:TextBox ID="txtPK_iCauhoi_ID" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iCauhoi_ID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Câu hỏi: </td>
            <td><asp:TextBox ID="txtsCauhoi_Cauhoi" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCauhoi_Cauhoi" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Đáp án A: </td>
            <td><asp:TextBox ID="txtsCauhoi_A" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCauhoi_A" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Đáp án B: </td>
            <td><asp:TextBox ID="txtsCauhoi_B" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCauhoi_B" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Đáp án C: </td>
            <td><asp:TextBox ID="txtsCauhoi_C" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCauhoi_C" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Đáp án D: </td>
            <td><asp:TextBox ID="txtsCauhoi_D" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCauhoi_D" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Câu trả lời đúng: </td>
            <td>
                <asp:DropDownList ID="ddliCauhoi_Dung" runat="server" Width="405px">
                    <asp:ListItem Value="1">Đáp án A</asp:ListItem>
                    <asp:ListItem Value="2">Đáp án B</asp:ListItem>
                    <asp:ListItem Value="3">Đáp án C</asp:ListItem>
                    <asp:ListItem Value="4">Đáp án D</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td><asp:Label ID="lbliCauhoi_Dung" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Bộ câu hỏi: </td>
            <td><asp:DropDownList ID="ddlsBoCauHoi" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblsBoCauHoi" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày tạo: </td>
            <td><asp:TextBox ID="txttNgayTao" runat="server" Width= "400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayTao" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cập nhật: </td>
            <td><asp:TextBox ID="txttNgayCapNhat" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapNhat" runat="server"></asp:Label></td>
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
                <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" />
                <asp:Button ID="btnRefresh" runat="server" Text="Refresh" onclick="btnRefresh_Click" />
                <asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" />
                <asp:Button ID="btnExport" runat="server" Text="Export" onclick="btnExport_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>