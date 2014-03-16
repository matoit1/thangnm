<%@ Page Language="C#" AutoEventWireup="false" EnableViewState="false" CodeBehind="Default.aspx.cs" Inherits="nguyenmanhthang.Error.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>404 File Not Found, Sorry.</title>
    <link href="Chat.css" rel="stylesheet" type="text/css"/>
	<script type="text/javascript" src="chat.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="game" style="opacity:0.2">
        <asp:Panel ID="pnlPopup" runat="server">
        404
        </asp:Panel>
        <a href="http://it.site44.com/lienhe.html" target="_top" id="show-popup">Liên hệ</a>
<%--        <center><object height="600px" width="1024px" data="Dao_vang_I.swf"></object></center>--%>
    </div>
    <div class="all">
        <div onclick="clickx()" id="taskx">
		    Head<br /><hr />
	    </div>
        <div class="chat-box" style="margin: 20px;" id="popup">
		    Content
	    </div>
    </div>
    </form>
</body>
</html>
