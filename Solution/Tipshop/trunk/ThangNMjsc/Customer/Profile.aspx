<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="ThangNMjsc.Customer.Profile" MasterPageFile="~/MasterPage/PublicCustomer.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead_Customer" runat="server">
    <link href="../Css/calendar.css" rel="stylesheet" type="text/css"/>  
    <script src="../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../Scripts/calendar2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
            $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        });
    </script>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <div class="input">
        <p><asp:Label ID="Label9" runat="server" class="title" Text="Sửa thông tin tài khoản."></asp:Label><asp:Image ID="img" runat="server"  Width="100px"/></p>
         <p><asp:Label ID="Label12" runat="server" Text="" style="margin-left: 30px"></asp:Label></p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email ko hợp lệ" Display="None" ControlToValidate="txtAccounts_Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <table>
            <tr>
                <td>Tên đăng nhập: </td>
                <td><asp:TextBox ID="txtAccounts_Username" runat="server" Enabled="false" class="text"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_Username" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên đăng nhập"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Mật khẩu: </td>
                <td><asp:TextBox ID="txtAccounts_Password" runat="server" TextMode="Password" class="text"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_Password" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập mật khẩu"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Địa chỉ Email: </td>
                <td><asp:TextBox ID="txtAccounts_Email" runat="server" ontextchanged="txtAccounts_Email_TextChanged" AutoPostBack="true" class="text"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_Email" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa nhập tên email"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Link Avatar: </td>
                <td><asp:TextBox ID="txtAccounts_LinkAvatar" runat="server" class="text"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Ngày đăng ký: </td>
                <td><asp:TextBox ID="txtAccounts_RegisterDate" runat="server" Enabled="false" class="date"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Họ và tên: </td>
                <td><asp:TextBox ID="txtAccounts_FullName" runat="server" class="text"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_FullName" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa nhập họ và tên"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Địa chỉ: </td>
                <td><asp:TextBox ID="txtAccounts_Address" runat="server" class="text"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_Address" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Bạn chưa nhập địa chỉ"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Ngày sinh: </td>
                <td><asp:TextBox ID="txtAccounts_DateOfBirth" runat="server" class="startdate" Height="20px" Width="300px" style=" float:right; margin-right: 250px;"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_DateOfBirth" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Bạn chưa nhập ngày sinh"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Số điện thoại: </td>
                <td><asp:TextBox ID="txtAccounts_PhoneNumber" runat="server" class="number"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ControlToValidate="txtAccounts_PhoneNumber" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Bạn chưa nhập số điện thoại"></asp:RequiredFieldValidator></td>
            </tr>
            <tr><td><br /></td><td><br /></td><td><br /></td></tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnUpdate" runat="server" Text="Cập nhật thông tin" OnClick="btnUpdate_Click"/></td>
                <td></td>
            </tr>
        </table>
        <center></center><br /><br />
    </div>
</asp:Content>