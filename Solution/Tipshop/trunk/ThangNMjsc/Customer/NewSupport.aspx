<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSupport.aspx.cs" Inherits="ThangNMjsc.Customer.NewSupport" MasterPageFile="~/MasterPage/PublicCustomer.Master" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <div class="input">
        <br /><asp:Label ID="Label8" runat="server" Text="Gửi yêu cầu hỗ trợ mới" class="tieude"></asp:Label><br />
        <p style="text-align:left;"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Customer/Profile.aspx">[Chỉnh sửa thông tin cá nhân]</asp:HyperLink></p>
        <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
        <br />
        <p><asp:Label ID="Label11" runat="server" Text="Tên đăng nhập: "></asp:Label>
                <asp:TextBox ID="txtAccounts_Username" runat="server" Enabled="false" class="text"></asp:TextBox><br />
        </p>
        <p><asp:Label ID="Label9" runat="server" Text="Tên khách hàng: "></asp:Label>
                <asp:TextBox ID="txtAccounts_FullName" runat="server" Enabled="false" class="text"></asp:TextBox><br />
        </p>
        <p><asp:Label ID="Label10" runat="server" Text="Địa chỉ Email: "></asp:Label>
                <asp:TextBox ID="txtAccounts_Email" runat="server" Enabled="false" class="text"></asp:TextBox><br />
        </p>
        <p><asp:Label ID="Label2" runat="server" Text="Số Điện thoại liên hệ: "></asp:Label>
                <asp:TextBox ID="txtAccounts_PhoneNumber" runat="server" Enabled="false" class="number"></asp:TextBox><br />
        </p>
        <hr /><br />
        <p><asp:Label ID="Label1" runat="server" Text="Tiêu đề yêu cầu hỗ trợ: "></asp:Label>
                <asp:TextBox ID="txtSupports_Type" runat="server" class="text"></asp:TextBox><br />
        </p>
        <asp:RequiredFieldValidator ControlToValidate="txtSupports_Type" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tiêu đề hỗ trợ"></asp:RequiredFieldValidator>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Nhóm Sản phẩm: "></asp:Label>
                <asp:DropDownList ID="dropProducts_Group" runat="server" OnTextChanged="dropProducts_Group_Select" AutoPostBack="true" class="dropbox"></asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Sản phẩm: "></asp:Label>
                <asp:DropDownList ID="dropProducts" runat="server" class="dropbox"></asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Nội dung: "></asp:Label><br />
            <CKEditor:CKEditorControl ID="txtAnswers_Content" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
            <asp:RequiredFieldValidator ControlToValidate="txtAnswers_Content" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập nội dung hỗ trợ"></asp:RequiredFieldValidator>
        </p>
        <br /><center><asp:Button ID="btnSend" runat="server" Text="Gửi yêu cầu hỗ trợ đi" OnClick="btnSend_Click"/></center><br /><br />
    </div>
</asp:Content>