<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="nguyenmanhthang.ThuThuat.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="TimeDeleteFileImageCaptcha" runat="server" ontick="TimeDeleteFileImageCaptcha_Tick" Interval="5000" ></asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
    <table>
        <tr>
            <td>Enter verify code
            </td>
            <td><asp:TextBox ID="txtInputString" runat="server"></asp:TextBox></td>
            <td><asp:Image ID="captchaImage" runat="server" /></td>
        </tr>
        <tr><td colspan="3"><asp:Button ID="btnVerify" runat="server" Text="Verify" OnClick="btnVerify_Click" /><asp:Button ID="Button1" runat="server" Text="Redefine" OnClick="btnRedefine_Click" /></td></tr>
        </table>
    </form>
</body>
</html>
