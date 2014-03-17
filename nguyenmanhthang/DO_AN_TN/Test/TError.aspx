<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TError.aspx.cs" Inherits="DO_AN_TN.Test.TError" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/Error_DetailUC.ascx" tagname="Error_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/Error_ListUC.ascx" tagname="Error_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:Error_DetailUC ID="Error_DetailUC1" runat="server" />
    <uc2:Error_ListUC ID="Error_ListUC1" runat="server" />
</asp:Content>
