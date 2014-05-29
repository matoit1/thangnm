<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CongKy.SinhVien.Default" MasterPageFile="~/ShareInterface/ReportSI.Master" %>

<%@ Register src="../UserControl/PdfUC.ascx" tagname="PdfUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/WordUC.ascx" tagname="WordUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
<%--    <uc1:PdfUC ID="PdfUC1" runat="server" />--%>
    <uc2:WordUC ID="WordUC1" runat="server" />
    <br />
</asp:Content>