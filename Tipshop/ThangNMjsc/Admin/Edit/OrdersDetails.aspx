<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersDetails.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.OrdersDetails" MasterPageFile="~/MasterPage/PublicAdmin.Master" %>
<%@ Register src="../../UserControls/OrdersDetailUC.ascx" tagname="OrdersDetailUC" tagprefix="uc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <center><br /><asp:Label ID="lblMsg" runat="server"></asp:Label><br /></center>
    <uc1:OrdersDetailUC ID="OrdersDetailUC1" runat="server" />
    <center>
        <br /><br /><asp:Button ID="btnExcute" runat="server" Text="Xử lý đơn hàng" OnClick="btnExcute_Click" OnClientClick="return confirm('Bạn có muốn xử lý Hóa đơn này ko?');" />
        <asp:Button ID="btnDelete" runat="server" Text="Xóa" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa Hóa đơn này ko?');" /><br /><br />
    </center>
</asp:Content>
