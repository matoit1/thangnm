<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MonHoc_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.MonHoc_DetailUC" %>
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
            <td>Mã môn học: </td>
            <td><asp:TextBox ID="txtPK_sMaMonhoc" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sMaMonhoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên môn học: </td>
            <td><asp:TextBox ID="txtsTenMonhoc" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenMonhoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số trình: </td>
            <td><asp:TextBox ID="txtiSotrinh" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliSotrinh" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số tiết dạy: </td>
            <td><asp:TextBox ID="txtiSotietday" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliSotietday" runat="server"></asp:Label></td>
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