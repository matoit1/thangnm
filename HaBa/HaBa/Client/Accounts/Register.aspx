<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HaBa.Client.Accounts.Register" %>

<%@ Register src="../../UserControl/RegisterUC.ascx" tagname="RegisterUC" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 600px; margin: 0px auto 0px auto; border: 1px solid blue; padding: 5px">
    
        <uc1:RegisterUC ID="RegisterUC1" runat="server" />
    
    </div>
    </form>
</body>
</html>
