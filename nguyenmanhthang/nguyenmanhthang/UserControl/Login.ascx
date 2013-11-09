<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="nguyenmanhthang.UserControl.Login" %>
<asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnLogin">
    <div class="signin-card">
        <asp:Image ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" AlternateText="ThangNM" runat="server" /><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:TextBox ID="txtAccounts_Username" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtAccounts_Password" name="Password" TextMode="Password" placeholder="Mật khẩu" runat="server"></asp:TextBox>
        <asp:CheckBox ID="chkRememberMe" runat="server" value="yes"/>
	    <span>Ghi nhớ</span>
        <a id="A1" href="">Quên Tài khoản / Mật khẩu?</a><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="rc-button" onclick="btnLogin_Click" />
	    <a id="link-forgot-passwd" href="">Bạn cần trợ giúp?</a>
    </div>
</asp:Panel>