<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DO_AN_TN.Test.List" EnableEventValidation="false" %>

<%@ Register src="../UserControl/SinhVien_ListUC.ascx" tagname="SinhVien_ListUC" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:SinhVien_ListUC ID="SinhVien_ListUC1" runat="server" />
    
    </div>
    </form>
</body>
</html>
