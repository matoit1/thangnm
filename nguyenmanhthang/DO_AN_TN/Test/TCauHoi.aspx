<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TCauHoi.aspx.cs" Inherits="DO_AN_TN.Test.TCauHoi" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"%>

<%@ Register src="../UserControl/CauHoi_DetailUC.ascx" tagname="CauHoi_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/CauHoi_ListUC.ascx" tagname="CauHoi_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:CauHoi_DetailUC ID="CauHoi_DetailUC1" runat="server" />
    <uc2:CauHoi_ListUC ID="CauHoi_ListUC1" runat="server" />
</asp:Content>
