<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.LoginUC" %>
<asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnLogin">
    <div class="signin-card">
        <asp:ImageButton ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:TextBox ID="txtAccounts_Username" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtAccounts_Password" name="Password" TextMode="Password" placeholder="Mật khẩu" runat="server"></asp:TextBox>
        <asp:CheckBox ID="chkRememberMe" runat="server" value="yes"/><span>Ghi nhớ</span>
        <asp:HyperLink ID="hplLost" runat="server" NavigateUrl="~/Accounts/ForgotPassword.aspx">Quên Tài khoản / Mật khẩu?</asp:HyperLink><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="rc-button" onclick="btnLogin_Click" />
        <asp:HyperLink ID="hplHelp" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
    </div>
</asp:Panel>