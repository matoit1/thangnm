<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersDetails.aspx.cs" Inherits="ThangNMjsc.Customer.OrdersDetails" MasterPageFile="~/MasterPage/PublicCustomer.Master" %>
<%@ Register src="../UserControls/OrdersDetailUC.ascx" tagname="OrdersDetailUC" tagprefix="uc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <uc1:OrdersDetailUC ID="OrdersDetailUC1" runat="server" />
</asp:Content>
