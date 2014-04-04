<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiangDay.aspx.cs" Inherits="DO_AN_TN.GiangVien.GiangDay" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" %>
<%@ Register src="../UserControl/ASM_ServerUC.ascx" tagname="ASM_ServerUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <uc1:ASM_ServerUC ID="ASM_ServerUC1" runat="server" />
    </div>
</asp:Content>