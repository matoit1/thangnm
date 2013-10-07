<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGroupProducts.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditGroupProducts" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="Label9" runat="server" class="title" Text="Sửa thông tin Nhóm Sản phẩm."></asp:Label><br /></p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:Panel ID="Panel1" runat="server">
            <table>
                <tr>
                    
                    <td><asp:Label ID="lblProducts_ID" runat="server" Text="Mã Nhóm Sản phẩm: "></asp:Label></td>
                    <td><asp:TextBox ID="txtProducts_ID" runat="server" Enabled="false" class="number"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Nhóm Sản phẩm: </td>
                    <td><asp:RadioButton ID="radiobtnParent" runat="server" GroupName="Parent" AutoPostBack="true" Text="Nhóm lớn" oncheckedchanged="radiobtnParent_CheckedChanged"/>
                    <asp:RadioButton ID="radiobtnChildrent" runat="server" GroupName="Parent" AutoPostBack="true" Text="Nhóm con" oncheckedchanged="radiobtnChildrent_CheckedChanged"/>
                    <asp:DropDownList ID="dropProducts_Parent" runat="server" class="dropbox"></asp:DropDownList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>Tên Nhóm Sản phẩm: </td>
                    <td><asp:TextBox ID="txtProducts_Name" runat="server" class="text"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ControlToValidate="txtProducts_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên nhóm Sản phẩm"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Mô tả Nhóm Sản phẩm: </td>
                    <td><CKEditor:CKEditorControl ID="txtProducts_Description" runat="server" CssClass="ck"></CKEditor:CKEditorControl></td>
                    <td><asp:RequiredFieldValidator ControlToValidate="txtProducts_Description" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập mô tả nhóm Sản phẩm"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Trạng thái kích hoạt:</td>
                    <td><asp:CheckBox ID="chkProducts_Visible" runat="server" /><asp:Label ID="Label5" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp; Đã kích hoạt"></asp:Label></td>
                    <td></td>
                </tr>
                <tr><td><br /></td><td><br /></td><td><br /></td></tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnAdd" runat="server" Text="Thêm nhóm Sản phẩm" OnClick="btnAdd_Click"/><asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/></td>
                    <td></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>