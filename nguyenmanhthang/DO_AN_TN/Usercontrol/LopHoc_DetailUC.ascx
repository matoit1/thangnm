<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LopHoc_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.LopHoc_DetailUC" %>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Lớp học"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã lớp học: </td>
            <td><asp:TextBox ID="txtPK_sMalop" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sMalop" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên lớp học: </td>
            <td><asp:TextBox ID="txtsTenlop" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenlop" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Năm vào trường: </td>
            <td><asp:TextBox ID="txtiNamvaotruong" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliNamvaotruong" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Sĩ số: </td>
            <td><asp:TextBox ID="txtiSiso" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliSiso" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số năm đào tạo: </td>
            <td><asp:TextBox ID="txtiSoNamDaoTao" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliSoNamDaoTao" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:TextBox ID="txtiTrangThai" runat="server" Width="400px"></asp:TextBox></td>
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
                <asp:Button ID="btnExport" runat="server" Text="Export" 
                    onclick="btnExport_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>