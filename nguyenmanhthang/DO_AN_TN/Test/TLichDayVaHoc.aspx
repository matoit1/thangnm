<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TLichDayVaHoc.aspx.cs" Inherits="DO_AN_TN.Test.TLichDayVaHoc" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/LichDayVaHoc_DetailUC.ascx" tagname="LichDayVaHoc_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/LichDayVaHoc_ListUC.ascx" tagname="LichDayVaHoc_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:LichDayVaHoc_DetailUC ID="LichDayVaHoc_DetailUC1" runat="server" />
    <uc2:LichDayVaHoc_ListUC ID="LichDayVaHoc_ListUC1" runat="server" />
</asp:Content>
