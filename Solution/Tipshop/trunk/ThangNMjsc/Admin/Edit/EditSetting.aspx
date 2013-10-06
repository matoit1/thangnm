<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSetting.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditSetting" MasterPageFile="~/MasterPage/PublicAdmin.Master" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div><br /><br /><br />
    <center>
        <asp:Label ID="lblTitle" runat="server" CssClass="tieude"></asp:Label><br /><br />
    </center>
    <asp:Panel ID="pnlMain" runat="server">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p><asp:Label ID="Label11" runat="server" Text="Tiêu đề: "></asp:Label>
            <asp:TextBox ID="txtWebsite_Title" runat="server" class="text"></asp:TextBox><br />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Nội dung: "></asp:Label>
        <CKEditor:CKEditorControl ID="txtWebsite_Content" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
    </asp:Panel><br />
    <asp:Label ID="lblWebsite_LastUpdate" runat="server"></asp:Label><br />
    <center>
        <asp:Button ID="btnAdd" runat="server" Text="Thêm" onclick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" onclick="btnUpdate_Click" />
    </center>
</div>
</asp:Content>
