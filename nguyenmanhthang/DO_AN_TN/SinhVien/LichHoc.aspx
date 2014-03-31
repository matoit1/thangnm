<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LichHoc.aspx.cs" Inherits="DO_AN_TN.SinhVien.LichHoc" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" EnableEventValidation="false" %>

<%@ Register src="../UserControl/LichDayVaHoc_ListUC.ascx" tagname="LichDayVaHoc_ListUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <uc1:LichDayVaHoc_ListUC ID="LichDayVaHoc_ListUC1" runat="server"/>
    </div>
</asp:Content>