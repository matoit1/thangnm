<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupProduct.aspx.cs" Inherits="tydyShop.GroupProduct" MasterPageFile="~/ShareInterface/ProductSI.Master" %>
<%@ Register src="~/UserControl/Gallery3DUC.ascx" tagname="Gallery3DUC" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <uc1:Gallery3DUC ID="Gallery3DUC1" runat="server" />
</asp:Content>