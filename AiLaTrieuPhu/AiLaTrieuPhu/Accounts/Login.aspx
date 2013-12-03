<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AiLaTrieuPhu.Accounts.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="lbtnLogin" >
		<div style="width: 380px; margin: 0 auto 0 auto; border: 1px double #000080">
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            <table>
                <tr>
                    <td>Tài khoản:</td>
                    <td><asp:TextBox ID="txttaikhoan_tentaikhoan" runat="server" class="form-login" title="Tên đăng nhập" value="" size="30" maxlength="2048" ></asp:TextBox><span> *</span></td>
                </tr>
                <tr><td></td><td class="error"><asp:RequiredFieldValidator ID="rfvtaikhoan_tentaikhoan" runat="server" ErrorMessage="Chưa nhập Tài khoản" ControlToValidate="txttaikhoan_tentaikhoan" ></asp:RequiredFieldValidator></td></tr>
                <tr>
                    <td>Mật khẩu:</td>
                    <td><asp:TextBox ID="txttaikhoan_matkhau" TextMode="Password" runat="server" class="form-login" title="Mật khẩu" value="" size="30" maxlength="2048" ></asp:TextBox><span> *</span></td>
                </tr>
                <tr><td></td><td class="error"><asp:RequiredFieldValidator ID="rfvtaikhoan_matkhau" runat="server" ErrorMessage="Chưa nhập Mật khẩu" ControlToValidate="txttaikhoan_matkhau" ></asp:RequiredFieldValidator></td></tr>
                <tr>
                    <td>Ghi nhớ tài khoản</td>
                    <td><asp:CheckBox ID="chkRememberMe" runat="server"/><a href="" style="margin-left:30px;">Quên mật khẩu?</a></td>
                </tr>
                <tr><td></td>
                <td> <asp:Button ID="lbtnLogin" runat="server" Text="Đăng nhập" onclick="lbtnLogin_Click" /></td>
                   
                </tr>
            </table>
		</div>
    </form>
</body>
</html>