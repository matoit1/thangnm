<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Captcha.aspx.cs" Inherits="DO_AN_TN.Test.Captcha" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Image ID="imgCaptcha1" runat="server" />
    <asp:ImageButton ID="ibtnChage1" runat="server" ImageUrl="~/Images/change.jpg" Height="30px" onclick="ChangeCaptcha_Click" />
    <br /><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
    <asp:TextBox ID="txtInput" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
