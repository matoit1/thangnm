<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="nguyenmanhthang.Contact" MasterPageFile="~/Default.Master"%>

<%@ Register src="UserControl/ContactUC.ascx" tagname="ContactUC" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <uc1:ContactUC ID="ContactUC1" runat="server" />
</asp:Content>
