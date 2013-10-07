<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestDES.aspx.cs" Inherits="ThangNMjsc.Test.TestDES" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
        <td>Input</td>
        <td><asp:TextBox ID="txtInput" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Key</td>
        <td><asp:TextBox ID="txtKey" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button ID="btnEncrypt" runat="server" Text="Encrypt" onclick="btnEncrypt_Click" /></td>
    </tr>
    <tr>
        <td>Output</td>
        <td><asp:TextBox ID="txtOutput" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button ID="btnDecrypt" runat="server" Text="Decrypt" onclick="btnDecrypt_Click" /></td>
    </tr>
    <tr>
        <td>Begin</td>
        <td><asp:TextBox ID="txtBegin" runat="server"></asp:TextBox></td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
