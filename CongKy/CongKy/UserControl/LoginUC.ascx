<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUC.ascx.cs" Inherits="CongKy.UserControl.LoginUC" %>

<asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnLogin">
    <div style="width: 310px; margin: 50px auto auto 500px; box-shadow:0 0 0 5px rgba(0, 0, 0, 0.15); border-radius: 2px; padding: 20px">
        
        <center><asp:HyperLink ID="hplHome" runat="server" NavigateUrl="~/Default.aspx"><img src="../../App_Themes/images/templatemo_logo.png" /></asp:HyperLink></center><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
        <asp:TextBox ID="txtsTenDangNhap" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server" Width="300px" Height="30px"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtsMatKhau" name="Password" TextMode="Password" placeholder="Mật khẩu" runat="server" Width="300px" Height="30px"></asp:TextBox><br /><br />
        <asp:CheckBox ID="chkRememberMe" runat="server" value="yes"/><span>Ghi nhớ mật khẩu</span><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="rc-button"  onclick="btnLogin_Click" /><br /><br />
        <hr />
        <asp:HyperLink ID="hplLost" runat="server">Quên Tài khoản / Mật khẩu?</asp:HyperLink><br />
        <asp:HyperLink ID="hplRegister" runat="server"></asp:HyperLink>
    </div>
</asp:Panel>