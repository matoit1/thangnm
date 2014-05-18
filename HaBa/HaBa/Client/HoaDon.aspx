<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="HaBa.Client.HoaDon" MasterPageFile="~/ShareInterface/ClientSI.Master" %>

<%@ Register src="../UserControl/tblHoaDon_PrintUC.ascx" tagname="tblHoaDon_PrintUC" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">

    <uc1:tblHoaDon_PrintUC ID="tblHoaDon_PrintUC1" runat="server" />

</asp:Content>
