<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TLopHoc.aspx.cs" Inherits="DO_AN_TN.Test.TLopHoc" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" %>

<%@ Register src="../UserControl/LopHoc_DetailUC.ascx" tagname="LopHoc_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/LopHoc_ListUC.ascx" tagname="LopHoc_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:LopHoc_DetailUC ID="LopHoc_DetailUC1" runat="server" />
    <uc2:LopHoc_ListUC ID="LopHoc_ListUC1" runat="server" />
</asp:Content>
