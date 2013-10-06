<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProducts.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditProducts" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="Label9" runat="server" class="title" Text="Sửa thông tin Sản phẩm."></asp:Label><br /></p>
        <p><asp:Label ID="Label10" runat="server" Text=""></asp:Label></p>
        <asp:ValidationSummary DisplayMode="List" HeaderText="Lỗi: " ShowMessageBox="false" ShowSummary="true" ID="ValidationSummary1" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên Sản phẩm" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Price" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập giá bán Sản phẩm" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Description" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa nhập mô tả Sản phẩm" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Image1" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa nhập link hình ảnh" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ControlToValidate="txtProducts_Price" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Giá bán phải là 1 số VD: 10000" ValidationExpression="([0-9])*" Display="None"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ControlToValidate="txtProducts_Sale" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Giá khuyến mại phải là 1 số VD: 10000" ValidationExpression="([0-9])*" Display="None"></asp:RegularExpressionValidator>
        <asp:Panel ID="Panel1" runat="server">
            <table>
                <tr>
                    <td>Mã Sản phẩm: </td>
                    <td><asp:TextBox ID="txtProducts_ID" runat="server" Enabled="false" class="number"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Nhóm Sản phẩm: </td>
                    <td><asp:DropDownList ID="dropProducts_Group" runat="server" class="dropbox"></asp:DropDownList></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Tên Sản phẩm: </td>
                    <td><asp:TextBox ID="txtProducts_Name" runat="server" class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Giá bán Sản phẩm: </td>
                    <td><asp:TextBox ID="txtProducts_Price" runat="server" class="number"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Giá khuyến mại: </td>
                    <td><asp:TextBox ID="txtProducts_Sale" runat="server" class="number"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Thuế giá trị gia tăng (VAT):</td>
                    <td><asp:CheckBox ID="chkProducts_VAT" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp; Đã bao gồm VAT</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Mô tả cho Sản phẩm: </td>
                    <td><CKEditor:CKEditorControl ID="txtProducts_Description" runat="server" CssClass="ck"></CKEditor:CKEditorControl></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Thông tin Sản phẩm: </td>
                    <td><CKEditor:CKEditorControl ID="txtProducts_Info" runat="server" CssClass="ck"></CKEditor:CKEditorControl></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Xuất xứ: </td>
                    <td><asp:TextBox ID="txtProducts_Origin" runat="server" class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Đính kèm ảnh 1:</td>
                    <td><asp:TextBox ID="txtProducts_Image1" runat="server" class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Đính kèm ảnh 2:</td>
                    <td><asp:TextBox ID="txtProducts_Image2" runat="server" class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Đính kèm ảnh 3:</td>
                    <td><asp:TextBox ID="txtProducts_Image3" runat="server"  class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Đính kèm video:</td>
                    <td><asp:TextBox ID="txtProducts_Video" runat="server" class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Cập nhật lần cuối: </td>
                    <td><asp:TextBox ID="txtProducts_LastUpdate" runat="server" Enabled="false" class="date"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Trạng thái kích hoạt:</td>
                    <td><asp:CheckBox ID="chkProducts_Visible" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp; Đã kích hoạt</td>
                    <td></td>
                </tr>
                <tr><td><br /></td><td><br /></td><td><br /></td></tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click"/><asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/></td>
                    <td></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>