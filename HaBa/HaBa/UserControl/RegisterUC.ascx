<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterUC.ascx.cs" Inherits="HaBa.UserControl.RegisterUC" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<table>
    <tr>
        <td></td>
        <td><center><h2><asp:Label ID="lblTitle" runat="server" Text="Đăng ký tài khoản - HaBa" ForeColor="Blue"></asp:Label></h2></center></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
        <td></td>
    </tr>
    <tr>
        <td>Tên đăng nhập: </td>
        <td><asp:TextBox ID="txtsTenDangNhap" runat="server" Width="250px"></asp:TextBox></td>
        <td><span style="color: Red;"> * </span><asp:Label ID="lblsTenDangNhap" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td>Mật khẩu: </td>
        <td><asp:TextBox ID="txtsMatKhau" runat="server" Width="250px" TextMode="Password"></asp:TextBox></td>
        <td><span style="color: Red;"> * </span><asp:Label ID="lblsMatKhau" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td>Nhập lại mật khẩu: </td>
        <td><asp:TextBox ID="txtsMatKhau1" runat="server" Width="250px" TextMode="Password"></asp:TextBox></td>
        <td><span style="color: Red;"> * </span><asp:Label ID="lblsMatKhau1" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td>Họ và Tên: </td>
        <td><asp:TextBox ID="txtsHoTen" runat="server" Width="250px"></asp:TextBox></td>
        <td><span style="color: Red;"> * </span><asp:Label ID="lblsHoTen" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td>Địa chỉ Email: </td>
        <td><asp:TextBox ID="txtsEmail" runat="server" Width="250px"></asp:TextBox></td>
        <td><span style="color: Red;"> * </span><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Image ID="imgCaptcha" runat="server" />
                    <asp:ImageButton ID="ibtnChage" runat="server" ImageUrl="~/App_Themes/Images/change.jpg" Height="30px" onclick="ChangeCaptcha_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
        <td><asp:Label ID="Label6" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td>Mã xác nhận: </td>
        <td><asp:TextBox ID="txtsCaptcha" runat="server" Width="250px"></asp:TextBox></td>
        <td><span style="color: Red;"> * </span><asp:Label ID="lblsCaptcha" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnRegister" runat="server" Text="Đăng ký" onclick="btnRegister_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
        </td>
        <td></td>
    </tr>
</table>