<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddGroupProducts.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.AddGroupProducts" MasterPageFile="~/MasterPage/PublicAdmin.Master" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="Label9" runat="server" class="title" Text="Thêm Nhóm Sản phẩm mới."></asp:Label><br /></p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <p><asp:Label ID="Label2" runat="server" Text="Nhóm Sản phẩm: "></asp:Label>
            <asp:DropDownList ID="dropProducts_Parent" runat="server" class="dropbox"></asp:DropDownList><br />
        </p>
        <p><asp:Label ID="Label11" runat="server" Text="Tên nhóm Sản phẩm: "></asp:Label>
            <asp:TextBox ID="txtProducts_Name" runat="server" class="text"></asp:TextBox><br />
        </p>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên nhóm Sản phẩm"></asp:RequiredFieldValidator>
        <p><asp:Label ID="Label5" runat="server" Text="Mô tả Nhóm Sản phẩm: "></asp:Label>
            <CKEditor:CKEditorControl ID="txtProducts_Description" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
            <asp:RequiredFieldValidator ControlToValidate="txtProducts_Description" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập mô tả nhóm Sản phẩm"></asp:RequiredFieldValidator>
        </p>
        <span style="margin-left: 250px;">
            <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click"/>
        </span>
    </div>
</asp:Content>
