<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HocTap.aspx.cs" Inherits="DO_AN_TN.SinhVien.HocTap" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../UserControl/ASM_ClientUC.ascx" tagname="ASM_ClientUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <uc1:ASM_ClientUC ID="ASM_ClientUC1" runat="server" />
    </div>
</asp:Content>
