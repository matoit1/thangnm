﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="nguyenmanhthang.Admin.Accounts.Login" %>

<%@ Register src="~/UserControl/Login.ascx" tagname="Login" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link rel="stylesheet" href="login.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 10px auto auto auto; width:500px">
        <uc1:Login ID="Login1" runat="server" />
    </div>
    </form>
</body>
</html>
