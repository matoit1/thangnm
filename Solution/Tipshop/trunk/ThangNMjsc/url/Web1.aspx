<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web1.aspx.cs" Inherits="ThangNMjsc.url.Web1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lburl" runat="server"></asp:Label>
&nbsp;
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="IsPostBack" />
    
    </div>
    </form>
</body>
</html>