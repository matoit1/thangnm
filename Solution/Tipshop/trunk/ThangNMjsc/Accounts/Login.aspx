<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ThangNMjsc.Accounts.Login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập - Công ty Cổ phần ThangNMjsc <-> Login - ThangNM Joint Stock Company</title>
    <link href="../favicon.ico" rel="Shortcut Icon" type="image/x-icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="language" content="Vietnamese, English"/>
	<meta name="description" content="Đăng nhập - Công ty Cổ phần ThangNMjsc - Login - ThangNM Joint Stock Company" />
	<meta name="language" content="Vietnamese, English"/>
	<meta name="keywords" content="ThangNMjsc, ThangNM, Admin Control Panel Login, ThangNM Joint Stock Company, Login, Đăng nhập, Công ty Cổ phần ThangNMjsc, thang.991992@gmail.com"/>
    <link rel="author" href="https://plus.google.com/109664385150832451485"/>
    <meta name="copyright" content=" © 2013 Copyright ThangNM ™"/>
    <!-- CSS & JavaScript -->
    <link href="../Css/Login/login_box.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" defaultbutton="lbtnLogin" >
		<div class="login-box">
			<center>
                <a href="../Default.aspx" title="ThangNM Join Stock Company"><img src="../Images/logo.gif" alt="logo ThangNM Joint Stock Company"/></a><br />
                <span style="color:indigo">Công ty Cổ phần ThangNM<br />(ThangNM Join Stock Company)</span><br /><br />
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </center>
            <table>
                <tr>
                    <td>Tài khoản:</td>
                    <td><asp:TextBox ID="txtAccounts_Username" runat="server" class="form-login" title="Tên đăng nhập" value="" size="30" maxlength="2048" ></asp:TextBox><span> *</span></td>
                </tr>
                <tr><td></td><td class="error"><asp:RequiredFieldValidator ID="rfvAccounts_Username" runat="server" ErrorMessage="Chưa nhập Tài khoản" ControlToValidate="txtAccounts_Username" ></asp:RequiredFieldValidator></td></tr>
                <tr>
                    <td>Mật khẩu:</td>
                    <td><asp:TextBox ID="txtAccounts_Password" TextMode="Password" runat="server" class="form-login" title="Mật khẩu" value="" size="30" maxlength="2048" ></asp:TextBox><span> *</span></td>
                </tr>
                <tr><td></td><td class="error"><asp:RequiredFieldValidator ID="rfvAccounts_Password" runat="server" ErrorMessage="Chưa nhập Mật khẩu" ControlToValidate="txtAccounts_Password" ></asp:RequiredFieldValidator></td></tr>
                <tr>
                    <td>Ghi nhớ tài khoản</td>
                    <td><asp:CheckBox ID="chkRememberMe" runat="server"/><a href="../Accounts/ForgotPassword.aspx" style="margin-left:30px;">Quên mật khẩu?</a></td>
                </tr>
            </table><br />
            <asp:LinkButton ID="lbtnLogin" runat="server" CssClass="button3D" onclick="lbtnLogin_Click" style="margin-left:105px; font-size:14px;">Đăng nhập</asp:LinkButton><br /><br />
            <a href="../Accounts/Register.aspx" style="margin-left:222px;">Đăng ký tài khoản mới</a><br />
		</div>
    </form>
</body>
</html>