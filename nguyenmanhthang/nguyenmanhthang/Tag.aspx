<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tag.aspx.cs" Inherits="nguyenmanhthang.Tag" MasterPageFile="~/Default.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:TextBox ID="txtTag" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSearch" runat="server" Text="Search" />
</asp:Content>