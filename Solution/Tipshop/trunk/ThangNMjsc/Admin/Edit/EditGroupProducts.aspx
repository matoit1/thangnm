<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGroupProducts.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditGroupProducts" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="Label9" runat="server" class="title" Text="Sửa thông tin Nhóm Sản phẩm."></asp:Label><br /></p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:Panel ID="Panel1" runat="server">
            <p><asp:Label ID="lblProducts_ID" runat="server" Text="Mã Nhóm Sản phẩm: "></asp:Label>
                <asp:TextBox ID="txtProducts_ID" runat="server" Enabled="false" class="number"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label4" runat="server" Text="Nhóm Sản phẩm: "></asp:Label>
                <asp:RadioButton ID="radiobtnParent" runat="server" GroupName="Parent" AutoPostBack="true" Text="Nhóm lớn" oncheckedchanged="radiobtnParent_CheckedChanged"/>
                <asp:RadioButton ID="radiobtnChildrent" runat="server" GroupName="Parent" AutoPostBack="true" Text="Nhóm con" oncheckedchanged="radiobtnChildrent_CheckedChanged"/>
                <asp:DropDownList ID="dropProducts_Parent" runat="server" class="dropbox"></asp:DropDownList><br />
            </p>
            <asp:RequiredFieldValidator ControlToValidate="txtProducts_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên nhóm Sản phẩm"></asp:RequiredFieldValidator>
            <p><asp:Label ID="Label11" runat="server" Text="Tên Nhóm Sản phẩm: "></asp:Label>
                    <asp:TextBox ID="txtProducts_Name" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label2" runat="server" Text="Mô tả Nhóm Sản phẩm: "></asp:Label>
                <CKEditor:CKEditorControl ID="txtProducts_Description" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
                <asp:RequiredFieldValidator ControlToValidate="txtProducts_Description" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập mô tả nhóm Sản phẩm"></asp:RequiredFieldValidator>
            </p>
            <p><asp:Label ID="Label14" runat="server" Text="Trạng thái kích hoạt: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                <asp:CheckBox ID="chkProducts_Visible" runat="server" /><asp:Label ID="Label5" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp; Đã kích hoạt"></asp:Label>
            </p>
            <center>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click"/>
                <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/>
            </center>
        </asp:Panel>
    </div>
</asp:Content>