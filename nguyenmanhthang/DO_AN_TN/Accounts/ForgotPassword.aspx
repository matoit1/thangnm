<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="DO_AN_TN.Accounts.ForgotPassword" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quên mật khẩu / tài khoản?</title>
    <link rel="stylesheet" href="login.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 400px; margin: 30px auto auto auto">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
        <cc1:TabPanel runat="server" HeaderText="Quên mật khẩu" ID="TabAccounts_Password">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" DefaultButton="btnReset">
                <div class="signin-card">
                    <asp:ImageButton ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
                    <asp:Label ID="lblMsg1" runat="server"></asp:Label>
                    <asp:TextBox ID="txtAccounts_Username" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtAccounts_Email1" name="Email" type="email" placeholder="Email đăng ký" spellcheck="false" runat="server"></asp:TextBox>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Image ID="imgCaptcha1" runat="server" />
                        <asp:ImageButton ID="ibtnChage1" runat="server" ImageUrl="~/Images/change.jpg" Height="30px" onclick="ChangeCaptcha_Click" />
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    <br /><asp:TextBox ID="txtCaptcha1" runat="server" placeholder="Captcha" ></asp:TextBox><br /><br />
                    <asp:Button ID="btnReset" runat="server" Text="Lấy lại mật khẩu" CssClass="rc-button" onclick="btnReset_Click" />
                    <asp:HyperLink ID="hplHelp" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
                </div>
            </asp:Panel>
        </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="Quên tên đăng nhập" ID="TabAccounts_Username">
        <ContentTemplate>
            <asp:Panel ID="Panel2" runat="server" DefaultButton="btnFindAccount">
                <div class="signin-card">
                    <asp:ImageButton ID="ImageButton1" CssClass="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
                    <asp:Label ID="lblMsg2" runat="server"></asp:Label>
                    <asp:TextBox ID="txtAccounts_Email2" name="Email" type="email" placeholder="Email đăng ký" spellcheck="false" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtAccounts_PhoneNumber" name="PhoneNumber" type="tel" placeholder="Số điện thoại đăng ký" spellcheck="false" runat="server"></asp:TextBox>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Image ID="imgCaptcha2" runat="server" />
                        <asp:ImageButton ID="ibtnChage2" runat="server" ImageUrl="~/Images/change.jpg" Height="30px" onclick="ChangeCaptcha_Click" />
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    <br /><asp:TextBox ID="txtCaptcha2" runat="server" placeholder="Captcha"></asp:TextBox><br /><br />
                    <asp:Button ID="btnFindAccount" runat="server" Text="Lấy lại tên đăng nhập" CssClass="rc-button" onclick="btnFindAccount_Click" />
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
                </div>
            </asp:Panel>
        </ContentTemplate>
        </cc1:TabPanel>
        </cc1:TabContainer>
    </div>
    </form>
</body>
</html>
