<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="DO_AN_TN.Test.ChatRoomUC.Demo" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <input id="hdnRoomID" type="hidden" name="hdnRoomID" runat="server"/>
    <uc1:ChatUC ID="ChatUC1" runat="server" />
</asp:Content>
