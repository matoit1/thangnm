<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TBaiViet.aspx.cs" Inherits="DO_AN_TN.Test.TBaiViet" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/BaiViet_DetailUC.ascx" tagname="BaiViet_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/BaiViet_ListUC.ascx" tagname="BaiViet_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:BaiViet_DetailUC ID="BaiViet_DetailUC1" runat="server" />
    <uc2:BaiViet_ListUC ID="BaiViet_ListUC1" runat="server" />
</asp:Content>
