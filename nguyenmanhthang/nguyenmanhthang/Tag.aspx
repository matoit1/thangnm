<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tag.aspx.cs" Inherits="nguyenmanhthang.Tag" MasterPageFile="~/Common/Default.Master" %>
<%@ Register src="~/UserControl/TopicListUC.ascx" tagname="TopicListUC" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
<br /><br />
    <uc1:TopicListUC ID="TopicListUC1" runat="server" OnViewTopic="ViewTopic_Click" OnPageChangeTopic="PageChangeTopic_Click"/>
</asp:Content>