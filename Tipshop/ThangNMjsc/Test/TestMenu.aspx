<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestMenu.aspx.cs" Inherits="ThangNMjsc.Test.TestMenu" %>
<%@ Import Namespace="System.Data" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="menu"><!-- Begin #menu -->
		<ul id="navMenu">
            <%--<asp:Repeater ID="rpMenu" runat="server">
                <ItemTemplate>
                    <li><asp:HyperLink ID="HyperLink3" NavigateUrl="~/Default.aspx" runat="server" Text='<%#Eval("Products_Name")%>'></asp:HyperLink></li>
                </ItemTemplate>
            </asp:Repeater>--%>

            <asp:Repeater id="parentRepeater" runat="server">
	            <itemtemplate>
		            <b><%# DataBinder.Eval(Container.DataItem, "Products_ID")%></b><br>
		            <asp:Repeater id="childRepeater" runat="server" datasource='<%# ((DataRowView)Container.DataItem).Row.GetChildRows("myrelation") %>' >
			            <itemtemplate>
				            <%# DataBinder.Eval(Container.DataItem, "[\"title_id\"]")%><br>	
			            </itemtemplate>
		            </asp:Repeater> 
	            </itemtemplate>
            </asp:Repeater>
		</ul>
    </div>
    </form>
</body>
</html>
