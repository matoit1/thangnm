<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TSearch.aspx.cs" Inherits="DO_AN_TN.Test.TSearch" %>

<%@ Register src="../UserControl/Search/SinhVien_SearchUC.ascx" tagname="SinhVien_SearchUC" tagprefix="uc1" %>

<%@ Register src="../UserControl/ChatRoomUC.ascx" tagname="ChatRoomUC" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../App_Themes/New/ChatRoom.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="hdnRoomID" type="hidden" name="hdnRoomID" runat="server"/>
        </div>
    </form>
</body>
</html>
