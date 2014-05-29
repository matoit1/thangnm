<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CongKy.QuanTri.Accounts.Login" %>
<%@ Register src="~/UserControl/LoginUC.ascx" tagname="LoginUC" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:LoginUC ID="LoginUC1" runat="server" OnLogin="Login_Click"/>
    </div>
    </form>
</body>
</html>
