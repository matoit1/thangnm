<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TPhanCongCongTac.aspx.cs" Inherits="DO_AN_TN.Test.TPhanCongCongTac" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" %>

<%@ Register src="../UserControl/PhanCongCongTac_DetailUC.ascx" tagname="PhanCongCongTac_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/PhanCongCongTac_ListUC.ascx" tagname="PhanCongCongTac_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:PhanCongCongTac_DetailUC ID="PhanCongCongTac_DetailUC1" runat="server" />
    <uc2:PhanCongCongTac_ListUC ID="PhanCongCongTac_ListUC1" runat="server" />
</asp:Content>
