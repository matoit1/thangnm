<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AMS_Client.aspx.cs" Inherits="DO_AN_TN.Test.AMS_Client" %>

<%@ Register src="../UserControl/ASM_ClientUC.ascx" tagname="ASM_ClientUC" tagprefix="uc1" %>

<%@ Register src="../UserControl/TracNghiemUC.ascx" tagname="TracNghiemUC" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:ASM_ClientUC ID="ASM_ClientUC1" runat="server" />
    
    </div>
    <uc2:TracNghiemUC ID="TracNghiemUC1" runat="server" />
    </form>
</body>
</html>
