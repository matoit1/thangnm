<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PhanCongCongTac_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.PhanCongCongTac_DetailUC" %>
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
            <td><asp:TextBox ID="txtPK_sMaPCCT" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sMaPCCT" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã giảng viên: </td>
            <td><asp:TextBox ID="txtFK_sMaGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblFK_sMaGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã môn học: </td>
            <td><asp:TextBox ID="txtFK_sMaMonhoc" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblFK_sMaMonhoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày bắt đầu: </td>
            <td><asp:TextBox ID="txttNgayBatDau" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayBatDau" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày kết thúc: </td>
            <td><asp:TextBox ID="txttNgayKetThuc" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayKetThuc" runat="server"></asp:Label></td>
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
                <asp:Button ID="btnExport" runat="server" Text="Export" onclick="btnExport_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>