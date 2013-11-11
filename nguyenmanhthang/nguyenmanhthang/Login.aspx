<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="nguyenmanhthang.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Thông tin đăng nhập</legend>
        <table>
            <tr>
                <td colspan="2"><asp:Label ID="lblMsgError" runat="server" Text="Label"></asp:Label></td>                
            </tr>
            <tr>
                <td>Tên đăng nhập</td><td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Mật khẩu</td><td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" /></td>
            </tr>
        </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
