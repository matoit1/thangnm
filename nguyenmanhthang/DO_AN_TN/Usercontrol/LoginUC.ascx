<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUC.ascx.cs" Inherits="DO_AN_TN.UserControl.LoginUC" %>
<link href="../../App_Themes/login.css" rel="stylesheet" type="text/css" />
<asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnLogin">
    <div class="signin-card">
        <asp:ImageButton ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/default.jpg" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:TextBox ID="txtsTendangnhap" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtsMatkhau" name="Password" TextMode="Password" placeholder="Mật khẩu" runat="server"></asp:TextBox>
        <asp:CheckBox ID="chkRememberMe" runat="server" value="yes"/><span>Ghi nhớ</span>
        <asp:HyperLink ID="hplLost" runat="server">Quên Tài khoản / Mật khẩu?</asp:HyperLink><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="rc-button"  onclick="btnLogin_Click" />
        <asp:HyperLink ID="hplHelp" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
    </div>
</asp:Panel>