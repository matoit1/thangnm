<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TDiemThi.aspx.cs" Inherits="DO_AN_TN.Test.TDiemThi" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" %>

<%@ Register src="../UserControl/DiemThi_DetailUC.ascx" tagname="DiemThi_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/DiemThi_ListUC.ascx" tagname="DiemThi_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:DiemThi_DetailUC ID="DiemThi_DetailUC1" runat="server" />
    <uc2:DiemThi_ListUC ID="DiemThi_ListUC1" runat="server" />
</asp:Content>
