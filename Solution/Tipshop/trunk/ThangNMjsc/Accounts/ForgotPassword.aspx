<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="ThangNMjsc.Accounts.ForgotPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Quên mật khẩu - Công ty Cổ phần ThangNMjsc <-> Forgot Password - ThangNM Joint Stock Company</title>
    <link href="../favicon.ico" rel="Shortcut Icon" type="image/x-icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="language" content="Vietnamese, English"/>
	<meta name="description" content="Quên mật khẩu - Công ty Cổ phần ThangNMjsc - Forgot Password - ThangNM Joint Stock Company" />
	<meta name="language" content="Vietnamese, English"/>
	<meta name="keywords" content="ThangNMjsc, ThangNM, ThangNM Joint Stock Company, Forgot Password, Quên mật khẩu, Công ty Cổ phần ThangNMjsc, thang.991992@gmail.com"/>
    <link rel="author" href="https://plus.google.com/109664385150832451485"/>
    <meta name="copyright" content=" © 2013 Copyright ThangNM ™"/>
    <!-- CSS & JavaScript -->
    <link href="../Css/Login/login_box.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
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
                    <td>Email đăng ký:</td>
                    <td><asp:TextBox ID="txtAccounts_Email" runat="server" class="form-login" title="Email" value="" size="30" maxlength="2048" ></asp:TextBox><span> *</span></td>
                </tr>
                <tr><td></td><td class="error"><asp:RequiredFieldValidator ID="rfvAccounts_Email" runat="server" ErrorMessage="Chưa nhập Email" ControlToValidate="txtAccounts_Email" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revAccounts_Email" runat="server" ErrorMessage="Email ko hợp lệ" ControlToValidate="txtAccounts_Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td></tr>
            </table><br />
            <asp:LinkButton ID="lbtnReset" runat="server" CssClass="button3D" onclick="lbtnReset_Click" style="margin-left:105px; font-size:14px;">Lấy lại mật khẩu</asp:LinkButton><br />
		</div>
    </form>
</body>
</html>
