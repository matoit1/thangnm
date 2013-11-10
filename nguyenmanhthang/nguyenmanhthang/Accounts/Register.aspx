<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="nguyenmanhthang.Accounts.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký tài khoản</title>
    <link rel="stylesheet" href="login.css"/>
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
    <div>
        <asp:Panel ID="Panel1" runat="server" DefaultButton="btnRegister">
            <div class="signin-card">
                <asp:ImageButton ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                <p style="display:inline"><asp:TextBox ID="txtAccounts_FullName" name="FullName" type="text" placeholder="Họ và Tên" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span></p>
                <asp:TextBox ID="txtAccounts_Username" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server" ontextchanged="txtAccounts_Username_TextChanged"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_Password" name="Password" type="text" placeholder="Mật khẩu" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_Password1" name="Password1" type="email" placeholder="Nhập lại Mật khẩu" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_Email" name="Email" type="Email" placeholder="Email" spellcheck="false" runat="server" ontextchanged="txtAccounts_Email_TextChanged"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_LinkAvatar" name="LinkAvatar" type="url" placeholder="Link Avatar" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_Address" name="Address" type="text" placeholder="Địa chỉ" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_DateOfBirth" name="DateOfBirth" type="date" placeholder="Ngày sinh" spellcheck="false" CssClass="startdate" runat="server"></asp:TextBox><span style="color:Red"> *</span>
                <asp:TextBox ID="txtAccounts_PhoneNumber" name="PhoneNumber" type="tel" placeholder="Số điện thoại" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
                <asp:CheckBox ID="chkAgree" runat="server" value="yes" oncheckedchanged="chkAgree_CheckedChanged"/><span>Đồng ý với </span><asp:HyperLink ID="hplPoliciesPrivacy" runat="server" NavigateUrl="~/Policies-Privacy.aspx">Điều khoản ThangNM <span style="color:Red"> *</span></asp:HyperLink><br /><br />
                <asp:Button ID="btnRegister" runat="server" Text="Đăng ký" CssClass="rc-button" onclick="btnRegister_Click" />
                <asp:HyperLink ID="hplHelp" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
            </div>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
