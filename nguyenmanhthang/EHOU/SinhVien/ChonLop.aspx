<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChonLop.aspx.cs" Inherits="EHOU.SinhVien.ChonLop" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../UserControl/CaHocUC.ascx" tagname="CaHocUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <uc1:CaHocUC ID="CaHocUC1" runat="server" OnGoClass = "GoClass_Click" />
</asp:Content>