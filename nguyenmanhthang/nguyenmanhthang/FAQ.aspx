<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="nguyenmanhthang.FAQ" MasterPageFile="~/Default.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label><br /><br />
    <asp:Button ID="btnAdd" runat="server" Text="Thêm" onclick="btnAdd_Click"/><br />
    <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click"/><br />
    <asp:Button ID="btnUpdate" runat="server" Text="Sửa" onclick="btnUpdate_Click"/><br />
    <asp:Button ID="btnView" runat="server" Text="Xem" onclick="btnView_Click" /><br />
</asp:Content>
