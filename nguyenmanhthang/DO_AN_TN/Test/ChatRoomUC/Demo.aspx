<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="DO_AN_TN.Test.ChatRoomUC.Demo" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc1" %>
<%@ Register src="../../UserControl/DanhSachSinhVienLopHoc.ascx" tagname="DanhSachSinhVienLopHoc" tagprefix="uc2" %>
<%@ Register src="../../UserControl/DongHoUC.ascx" tagname="DongHoUC" tagprefix="uc3" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <link href="../../App_Themes/Chat.css" rel="stylesheet" type="text/css"/>
    <uc3:DongHoUC ID="DongHoUC1" runat="server" />
    <script type="text/javascript" src="../../Scripts/chat.js"></script>
    <div>
        <uc2:DanhSachSinhVienLopHoc ID="DanhSachSinhVienLopHoc1" runat="server" />
    </div>
    <uc1:ChatUC ID="ChatUC1" runat="server" />
</asp:Content>