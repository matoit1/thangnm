<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestXML.aspx.cs" Inherits="DO_AN_TN.Test.TestXML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList ID="dlQuangCao" runat="server"  CellPadding="0" CellSpacing="0" Width="100%" >
        <ItemStyle HorizontalAlign="Center"  VerticalAlign="Top" />
        <ItemTemplate>
            <div id="LinkOfList" class="LinkOfList_div">
                <li id="Product"><a  href='<%# Eval("Link") %>'> <%# Eval("Images") %></a></li>
                <a  href='<%# Eval("Link") %>'><%# Eval("Title")%></a>
            </div>
        </ItemTemplate>
    </asp:DataList>
    </div>
    </form>
</body>
</html>
