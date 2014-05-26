<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblAccount_DetailUC.ascx.cs" Inherits="EHOU.Usercontrol.tblAccount_DetailUC" %>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Tài khoản"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Tên đăng nhập: </td>
            <td><asp:TextBox ID="txtPK_sUsername" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sUsername" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mật khẩu: </td>
            <td><asp:TextBox ID="txtsPassword" runat="server" Width="400px" TextMode="Password"></asp:TextBox></td>
            <td><asp:Label ID="lblsPassword" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ và tên: </td>
            <td><asp:TextBox ID="txtsName" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsName" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtsEmail" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Loại tài khoản: </td>
            <td><asp:DropDownList ID="ddliType" runat="server" Width="405px" Enabled ="false"></asp:DropDownList></td>
            <td><asp:Label ID="lbliType" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliStatus" runat="server" Width="405px" Enabled ="false"></asp:DropDownList></td>
            <td><asp:Label ID="lbliStatus" runat="server"></asp:Label></td>
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
                <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>