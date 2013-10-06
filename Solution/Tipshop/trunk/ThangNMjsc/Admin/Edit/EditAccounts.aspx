<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditAccounts.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditAccounts" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead_Admin" runat="server">
    <link href="../../Css/calendar.css" rel="stylesheet" type="text/css"/>  
    <script src="../../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../../Scripts/calendar2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
            $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        });
    </script>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="lblTitle" runat="server" Text="Sửa thông tin tài khoản." class="title"></asp:Label><br /></p>
        <p><asp:Image ID="img" runat="server"  Width="100px"/><asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label13" runat="server" style="margin-left:50px"></asp:Label><br />
        </p>
        <asp:ValidationSummary DisplayMode="List" ShowMessageBox="false" ShowSummary="true" ID="ValidationSummary1" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_Username" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên đăng nhập" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_Password" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập mật khẩu" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_Email" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa nhập tên email" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email ko hợp lệ" ControlToValidate="txtAccounts_Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_FullName" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa nhập họ và tên" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_Address" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Bạn chưa nhập địa chỉ" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_DateOfBirth" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Bạn chưa nhập ngày sinh" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtAccounts_PhoneNumber" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Bạn chưa nhập số điện thoại" Display="None"></asp:RequiredFieldValidator>

        <asp:Panel ID="Panel1" runat="server">
            <p><asp:Label ID="Label1" runat="server" Text="Tên đăng nhập: "></asp:Label>
                <asp:TextBox ID="txtAccounts_Username" runat="server" Enabled="false" class="text" ontextchanged="txtAccounts_Username_TextChanged" AutoPostBack="true"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label11" runat="server" Text="Mật khẩu: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_Password" runat="server" TextMode="Password" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label2" runat="server" Text="Địa chỉ Email: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_Email" runat="server" class="text" ontextchanged="txtAccounts_Email_TextChanged" AutoPostBack="true"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label3" runat="server" Text="Quyền hạn: "></asp:Label>
                    <asp:DropDownList ID="dropAccounts_Permission" runat="server" class="dropbox"></asp:DropDownList><br />
            </p>
            <p><asp:Label ID="Label4" runat="server" Text="Ngày đăng ký: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_RegisterDate" runat="server" Enabled="false" class="date"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label12" runat="server" Text="Link Avatar: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_LinkAvatar" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label5" runat="server" Text="Họ và Tên: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_FullName" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label6" runat="server" Text="Địa chỉ: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_Address" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label7" runat="server" Text="Ngày sinh: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_DateOfBirth" runat="server" style="float:right; margin-right: 250px;" Width= "300px" Height="20px" class="startdate"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label8" runat="server" Text="Số điện thoại: "></asp:Label>
                    <asp:TextBox ID="txtAccounts_PhoneNumber" runat="server" class="number"></asp:TextBox><br />
            </p>
            <p>
                <asp:CheckBox ID="ChkAccounts_Status" runat="server" Text="Trạng thái kích hoạt tài khoản" class="checkbox" /><br />
            </p>
            <span style="margin-left: 250px;">
                <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/>
                <asp:Button ID="btnRegister" runat="server" Text="Đăng ký" OnClick="btnRegister_Click"/>
            </span>
        </asp:Panel>
    </div>
</asp:Content>