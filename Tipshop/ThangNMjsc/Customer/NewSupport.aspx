<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSupport.aspx.cs" Inherits="ThangNMjsc.Customer.NewSupport" MasterPageFile="~/MasterPage/PublicCustomer.Master" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <div class="input">
        <br /><asp:Label ID="Label8" runat="server" Text="Gửi yêu cầu hỗ trợ mới" class="tieude"></asp:Label><br />
        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
        <p style="text-align:left;"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Customer/Profile.aspx">[Chỉnh sửa thông tin cá nhân]</asp:HyperLink></p>
        <table>
            <tr>
                <td>Tên đăng nhập: </td>
                <td><asp:TextBox ID="txtAccounts_Username" runat="server" Enabled="false" class="text"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Tên khách hàng: </td>
                <td><asp:TextBox ID="txtAccounts_FullName" runat="server" Enabled="false" class="text"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Địa chỉ Email: </td>
                <td><asp:TextBox ID="txtAccounts_Email" runat="server" Enabled="false" class="text"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Số Điện thoại: </td>
                <td><asp:TextBox ID="txtAccounts_PhoneNumber" runat="server" Enabled="false" class="number"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr><td><hr /></td><td><hr /></td><td></td></tr>
            <tr>
                <td>Tiêu đề yêu cầu hỗ trợ: </td>
                <td><asp:TextBox ID="txtSupports_Type" runat="server" class="text"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtSupports_Type" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tiêu đề hỗ trợ"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Nhóm Sản phẩm: </td>
                <td><asp:DropDownList ID="dropProducts_Group" runat="server" OnTextChanged="dropProducts_Group_Select" AutoPostBack="true" class="dropbox"></asp:DropDownList></td>
                <td></td>
            </tr>
            <tr>
                <td>Sản phẩm: </td>
                <td><asp:DropDownList ID="dropProducts" runat="server" class="dropbox"></asp:DropDownList></td>
                <td></td>
            </tr>
            <tr>
                <td>Nội dung: </td>
                <td colspan="2"><CKEditor:CKEditorControl ID="txtAnswers_Content" runat="server" CssClass="ck"></CKEditor:CKEditorControl></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAnswers_Content" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập nội dung hỗ trợ"></asp:RequiredFieldValidator></td>
            </tr>
            <tr><td><br /></td><td><br /></td><td><br /></td></tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnSend" runat="server" Text="Gửi yêu cầu hỗ trợ đi" OnClick="btnSend_Click"/></td>
                <td></td>
            </tr>
        </table>
    </div>
</asp:Content>