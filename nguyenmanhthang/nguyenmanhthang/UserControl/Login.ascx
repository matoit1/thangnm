<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="nguyenmanhthang.UserControl.Login" %>
<div class="signin-card">
    <asp:Image ID="imgProfile" class="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" alt="Nguyễn Mạnh Thắng" runat="server" /><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <asp:TextBox ID="txtAccounts_Username" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtAccounts_Password" name="Password" TextMode="Password" placeholder="Mật khẩu" runat="server"></asp:TextBox>
    <asp:CheckBox ID="chkRememberMe" runat="server" value="yes"/>
	<span>Ghi nhớ</span>
    <a id="A1" href="">Quên Tài khoản / Mật khẩu?</a><br /><br />
    <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" class="rc-button" onclick="btnLogin_Click" />
<%--	<input id="signIn" name="signIn" class="rc-button" type="submit" value="Đăng nhập" />--%>
	<a id="link-forgot-passwd" href="">Bạn cần trợ giúp?</a>
</div>