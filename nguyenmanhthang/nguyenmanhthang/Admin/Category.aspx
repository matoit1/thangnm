<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="nguyenmanhthang.Category" MasterPageFile="~/Admin/Admin.Master" %>

<%@ Register src="../UserControl/CategoryListUC.ascx" tagname="CategoryListUC" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody_Admin" runat="server">
    
    <uc1:CategoryListUC ID="CategoryListUC1" runat="server" OnViewTopic="ViewTopic_Click" OnPageChangeTopic="PageChangeTopic_Click"/>
    
</asp:Content>
