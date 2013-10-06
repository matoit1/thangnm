<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ThangNMjsc.Accounts.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Customer Register - ThangNM Joint Stock Company</title>
    <link href="../favicon.ico" rel="Shortcut Icon" type="image/x-icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="language" content="Vietnamese, English"/>
	<meta name="description" content="Customer Register - ThangNM Joint Stock Company" />
	<meta name="language" content="Vietnamese, English"/>
	<meta name="keywords" content="ThangNM, Customer Register, ThangNM Joint Stock Company, Login, thang.991992@gmail.com"/>
    <link rel="author" href="https://plus.google.com/109664385150832451485"/>
    <meta name="copyright" content=" © 2013 Copyright ThangNM ™"/>
    <!-- CSS & JavaScript -->
    <link href="../Css/public.css" rel="stylesheet" type="text/css"/>  
    <link href="../Css/calendar.css" rel="stylesheet" type="text/css"/>  
    <script src="../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../Scripts/calendar2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
            $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 5px auto;width: 450px;border: 3px dotted blue;padding: 10px 10px 10px 10px;">
        <div>
            <center>
                <a href="../Default.aspx" title="ThangNM Join Stock Company"><img src="../Images/logo.gif" alt="logo ThangNM Joint Stock Company"/></a><br />
                <span style="color:Red">Join Stock Company</span><br /> <br />
                <asp:Label ID="lblerror" runat="server" Text="Đăng ký tài khoản" style="color:Green; text-transform:uppercase;"></asp:Label>
            </center>
        </div>
        <div style="margin:20px auto auto 20px;" class="input">
            <asp:ValidationSummary DisplayMode="BulletList" ID="ValidationSummary1" runat="server" HeaderText="Đăng ký không thành công" ShowMessageBox="false"/>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Họ và tên:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_FullName" runat="server" Width="200px" class="text"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn phải nhập tên thật của mình" ControlToValidate="txtAccounts_FullName">* (Bắt buộc)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Tên đăng nhập:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_Username" runat="server" Width="200px" ontextchanged="txtAccounts_Username_TextChanged" class="text"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập tên tên đăng nhập" ControlToValidate="txtAccounts_Username">* (Bắt buộc)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Mật khẩu:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_Password" runat="server" Width="200px" TextMode="Password" class="text"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa nhập mật khẩu" ControlToValidate="txtAccounts_Password">* (Bắt buộc)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Địa chỉ Email:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_Email" runat="server" Width="200px" ontextchanged="txtAccounts_Email_TextChanged" class="text"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa nhập địa chỉ email" ControlToValidate="txtAccounts_Email">* (Bắt buộc)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Link Avatar:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_LinkAvatar" runat="server" Width="200px" class="text"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Địa chỉ:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_Address" runat="server" Width="200px" class="text"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Ngày sinh:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_DateOfBirth" runat="server" Width="200px" class="startdate" style="float: right; margin-right: 250px;"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Bạn chưa nhập ngày sinh" ControlToValidate="txtAccounts_DateOfBirth">* (Bắt buộc)</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Số điện thoại:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAccounts_PhoneNumber" runat="server" Width="200px" class="text"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:CheckBox ID="CheckBoxAgree" runat="server"  Text="Đồng ý với điều khoản của " oncheckedchanged="CheckBoxAgree_CheckedChanged"/><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Info/Terms.aspx">ThangNM Join Stock Company Terms</asp:HyperLink><br /><br />
            <asp:Button ID="Button1" runat="server" onclick="btnRegister_Click" Text="Register" style="margin-left: 150px;"/>
        </div>
    </div>
    </form>
</body>
</html>
