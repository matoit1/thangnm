<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TSinhVien.aspx.cs" Inherits="DO_AN_TN.Test.TSinhVien" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/SinhVien_DetailUC.ascx" tagname="SinhVien_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/SinhVien_ListUC.ascx" tagname="SinhVien_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:SinhVien_DetailUC ID="SinhVien_DetailUC1" runat="server" />
    <uc2:SinhVien_ListUC ID="SinhVien_ListUC1" runat="server" />
</asp:Content>
