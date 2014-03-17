<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TMonHoc.aspx.cs" Inherits="DO_AN_TN.Test.TMonHoc" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" %>

<%@ Register src="../UserControl/MonHoc_DetailUC.ascx" tagname="MonHoc_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/MonHoc_ListUC.ascx" tagname="MonHoc_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:MonHoc_DetailUC ID="MonHoc_DetailUC1" runat="server" />
    <uc2:MonHoc_ListUC ID="MonHoc_ListUC1" runat="server" />
</asp:Content>
