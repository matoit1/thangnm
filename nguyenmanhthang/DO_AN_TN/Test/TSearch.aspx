<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TSearch.aspx.cs" Inherits="DO_AN_TN.Test.TSearch" %>

<%@ Register src="../UserControl/Search/SinhVien_SearchUC.ascx" tagname="SinhVien_SearchUC" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../App_Themes/popup.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../Scripts/jquery-1.4.1.min.js"> </script>
    <script type="text/javascript" src="../Scripts/popup.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hplLogin" runat="server" NavigateUrl="#" CssClass="topopup style_button" >Đăng nhập</asp:HyperLink>
            <uc1:SinhVien_SearchUC ID="SinhVien_SearchUC1" runat="server" />
        </div>
    </form>
</body>
</html>
