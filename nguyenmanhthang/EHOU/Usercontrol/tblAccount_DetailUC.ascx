<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblAccount_DetailUC.ascx.cs" Inherits="EHOU.Usercontrol.tblAccount_DetailUC" %>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Giảng viên"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Họ và tên: </td>
            <td><asp:TextBox ID="txtscreenName" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblscreenName" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên đăng nhập: </td>
            <td><asp:TextBox ID="txtusername" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblusername" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mật khẩu: </td>
            <td><asp:TextBox ID="txtpassword" runat="server" Width="400px" TextMode="Password"></asp:TextBox></td>
            <td><asp:Label ID="lblpassword" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtemail" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblemail" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Giới tính: </td>
            <td>
                <asp:RadioButton ID="rbtnmale" runat="server" Text="Nam" GroupName="gt" />
                <asp:RadioButton ID="rbtnfemale" runat="server" Text="Nữ"  GroupName="gt"/>
            </td>
            <td><asp:Label ID="lblmale" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Quyền hạn: </td>
            <td><asp:DropDownList ID="ddliType" runat="server" Width="405px" Enabled ="false"></asp:DropDownList></td>
            <td><asp:Label ID="lbliType" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <%--<asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />--%>
            </td>
            <td></td>
        </tr>
        
    </table>
</div>