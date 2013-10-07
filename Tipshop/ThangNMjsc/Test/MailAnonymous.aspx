<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailAnonymous.aspx.cs" Inherits="ThangNMjsc.Test.MailAnonymous" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
	<head>
	<title>E-mail and ASP.NET - Part 1</title>
	</head>
	<body>
		<form id="Form1" runat="server">
                <div align="center">
                <table border="0" width="350">
					<tr>
						<td valign="top"><font face="Verdana" size="2">Name:</font></td>
						<td height="24">   <asp:TextBox runat="server" Height="25px" Width="215px" ID="txtName"></asp:TextBox>
						    <br><asp:RequiredFieldValidator ID = "req1" ControlToValidate = "txtFrom" Runat = "server" ErrorMessage = "Please enter your name"></asp:RequiredFieldValidator>
                        </td>
					</tr>
					<tr>
						<td valign="top"><font face="Verdana" size="2">From</font></td>
						<td height="24"> <asp:TextBox runat="server" Height="22px" Width="213px" ID="txtFrom"></asp:TextBox>
						    <br><asp:RegularExpressionValidator ID = "reg1" ControlToValidate = "txtFrom" Runat = "server" ErrorMessage = "Invalid Email" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>&nbsp;<asp:RequiredFieldValidator ID = "req3" ControlToValidate = "txtFrom" Runat = "server" ErrorMessage = "Please enter your E-mail" ></asp:RequiredFieldValidator>
                        </td>
					</tr>
					<tr>
						<td valign="top"><font face="Verdana" size="2">To</font></td>
						<td height="24" valign="top"> 
						    <asp:TextBox runat="server" Height="22px" Width="212px" ID="txtTo"></asp:TextBox><br>
						    <asp:RegularExpressionValidator ID = "reg2" ControlToValidate = "txtTo" Runat = "server" ErrorMessage = "Invalid Email" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>&nbsp;<asp:RequiredFieldValidator ID = "req4" ControlToValidate = "txtTo" Runat = "server" ErrorMessage = "Please enter recipients E-mail" ></asp:RequiredFieldValidator>
                        </td>
					</tr>
					<tr>
						<td valign="top"><font face="Verdana" size="2">Cc</font></td>
						<td height="24" valign="top"> 
						    <asp:TextBox runat="server" Height="22px" Width="210px" ID="txtCc"></asp:TextBox>
						    <br><asp:RegularExpressionValidator ID = "reg3" ControlToValidate = "txtCc" Runat = "server" ErrorMessage = "Invalid Email" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
						</td>
					</tr>
					<tr>
						<td valign="top"><font face="Verdana" size="2">Subject:</font></td>
						<td height="24">   <asp:TextBox runat="server" Height="25px" Width="215px" ID="txtSubject"></asp:TextBox>
						    <br><asp:RequiredFieldValidator ID = "req5" ControlToValidate = "txtSubject" Runat = "server" ErrorMessage = "Please enter your Subject"></asp:RequiredFieldValidator>
                        </td>
					</tr>
					<tr>
						<td>
					</tr>
					<tr>
						<td valign="top"><font face="Verdana" size="2">Comments:</font></td>
						<td height="112"> <asp:TextBox runat="server" Height="107px" TextMode="MultiLine" Width="206px" ID="txtComments"></asp:TextBox>
						    <br><asp:RequiredFieldValidator ID = "req2" ControlToValidate = "txtComments" Runat = "server" ErrorMessage = "Please enter your comments"></asp:RequiredFieldValidator>
						</td>
					</tr>
					<tr>
						<td colspan="2" valign="top" height="30">
                            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />&nbsp;<input id="Reset1" type = "reset" runat = "server" value = "Clear">
                        </td>
					</tr>
					</table>
				</div>
		</form>
	</body>
</html>