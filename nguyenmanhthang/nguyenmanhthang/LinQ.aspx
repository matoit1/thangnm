﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinQ.aspx.cs" Inherits="nguyenmanhthang.LinQ" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grvDemo" runat="server">
        </asp:GridView><br /><br />
        <asp:Label ID="lblTongSoBanGhi" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblTongSoView" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
