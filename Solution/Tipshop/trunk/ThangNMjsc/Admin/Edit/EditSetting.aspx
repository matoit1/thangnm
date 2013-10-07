<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSetting.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditSetting" MasterPageFile="~/MasterPage/PublicAdmin.Master" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div><br /><br /><br />
    <center>
        <asp:Label ID="lblTitle" runat="server" CssClass="tieude"></asp:Label><br /><br />
    </center>
    <asp:Panel ID="pnlMain" runat="server">
        <table>
            <tr>
                <td>Tiêu đề: </td>
                <td><asp:TextBox ID="txtWebsite_Title" runat="server" class="text"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Nội dung: </td>
                <td><CKEditor:CKEditorControl ID="txtWebsite_Content" runat="server" CssClass="ck"></CKEditor:CKEditorControl></td>
                <td></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblWebsite_LastUpdate" runat="server"></asp:Label></td>
                <td></td>
                <td></td>
            </tr>
            <tr><td><br /></td><td><br /></td><td><br /></td></tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnAdd" runat="server" Text="Thêm" onclick="btnAdd_Click" /><asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" onclick="btnUpdate_Click" /></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p><asp:Label ID="Label11" runat="server" Text="Tiêu đề: "></asp:Label>
            <br />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Nội dung: "></asp:Label>
        
    </asp:Panel><br />
    <br />
    <center>
        
    </center>
</div>
</asp:Content>
