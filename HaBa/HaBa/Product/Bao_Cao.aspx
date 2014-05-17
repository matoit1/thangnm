<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bao_Cao.aspx.cs" Inherits="HaBa.Product.Bao_Cao" %>

<%@ Register src="../UserControl/ReportUC.ascx" tagname="ReportUC" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:ReportUC ID="ReportUC1" runat="server" />
    
    </div>
    </form>
</body>
</html>
