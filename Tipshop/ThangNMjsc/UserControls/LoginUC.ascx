<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUC.ascx.cs" Inherits="ThangNMjsc.UserControls.LoginUC" %>
<div style="border: 2px ridge red; margin: 5px 5px 5px 5px; padding: 5px 5px 5px 5px; width: 224px; height: 220px;">
<table>
    <tr><td></td>
        <td><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
    </tr>
    <tr><td>Tài khoản:</td>
        <td><asp:TextBox ID="txtAccounts_Username" runat="server"></asp:TextBox></td>
    </tr>
    <tr><td></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="chưa nhập tài khoản" ControlToValidate="txtAccounts_Username"></asp:RequiredFieldValidator></td>
    </tr>
    <tr><td>Mật khẩu:</td>
        <td><asp:TextBox ID="txtAccounts_Password" runat="server" TextMode="Password"></asp:TextBox></td>
    </tr>
    <tr><td></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="chưa nhập mật khẩu" ControlToValidate="txtAccounts_Password"></asp:RequiredFieldValidator></td>
    </tr>
    <tr><td colspan="2"><asp:CheckBox ID="chkRememberMe" runat="server" Text="Ghi nhớ tài khoản"/></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" 
                onclick="btnLogin_Click" /></td>
    </tr>
</table>
<hr />
<asp:HyperLink ID="hplForgotPassword" runat="server" NavigateUrl="~/Accounts/ForgotPassword.aspx">Quên mật khẩu/ tài khoản?</asp:HyperLink>
<asp:HyperLink ID="hplRegister" runat="server" NavigateUrl="~/Accounts/Register.aspx">Tạo tài khoản mới.</asp:HyperLink>
</div>
<div style="clear:both"></div>