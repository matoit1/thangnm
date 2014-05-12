<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNETChat.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login to The Chat Room</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
      	<table>
				<asp:Panel Runat="server" ID="pnlLogin">

						<tr>
							<td>User Name :</td>
							<td>
								<asp:TextBox id="txtUserName" Runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator id="req1" Runat="server" Display="Dynamic" ErrorMessage="8" ControlToValidate="txtUserName"></asp:RequiredFieldValidator></td>
						</tr>
						<tr>
							<td colspan="2">
								<asp:Button cssclass="btn" id="btnLogin" Runat="server" Text="LOGIN" OnClick="btnLogin_Click"></asp:Button></td>
						</tr>
				</asp:Panel>
				<asp:Panel Runat="server" ID="pnlChat">
					<tr valign="top">
						<td valign="top">Choose Room:
						</td>
						<td>
							<asp:ListBox id="lstRooms" runat="server">
								<asp:ListItem Value="1" Selected="True">Sports</asp:ListItem>
								<asp:ListItem Value="2">Music</asp:ListItem>
								<asp:ListItem Value="3">Software</asp:ListItem>
							</asp:ListBox></td>
					</tr>
					<tr>
						<td colspan="2">
							<asp:Button CssClass="btn" id="btnChat" OnClick="btnChat_Click" Runat="server" Text="Join"></asp:Button></td>
					</tr>
				</asp:Panel>
			</table>
    </form>
</body>
</html>
