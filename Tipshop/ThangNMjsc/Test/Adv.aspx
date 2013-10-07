<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv.aspx.cs" Inherits="test.WebControl.Adv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlAdv" />
        <asp:XmlDataSource ID="XmlAdv" runat="server" 
            DataFile="~/Test/XMLAdv.xml"></asp:XmlDataSource>
    <p><a href="XmlAdv.xml" target="_blank">View XML file</a></p>
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Test/XMLAdv.xml">HyperLink</asp:HyperLink>
    </div>
    </form>
</body>
</html>
