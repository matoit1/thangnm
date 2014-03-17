<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TGiangVien.aspx.cs" Inherits="DO_AN_TN.Test.TGiangVien" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/GiangVien_DetailUC.ascx" tagname="GiangVien_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/GiangVien_ListUC.ascx" tagname="GiangVien_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:GiangVien_DetailUC ID="GiangVien_DetailUC1" runat="server" />
    <uc2:GiangVien_ListUC ID="GiangVien_ListUC1" runat="server" />
</asp:Content>
