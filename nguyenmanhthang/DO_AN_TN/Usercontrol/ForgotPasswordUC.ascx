<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ForgotPasswordUC.ascx.cs" Inherits="DO_AN_TN.UserControl.ForgotPasswordUC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<link href="../../App_Themes/login.css" rel="stylesheet" type="text/css" />
<div style="width: 400px; margin: 30px auto auto auto">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
        <cc1:TabPanel runat="server" HeaderText="Quên mật khẩu" ID="TabAccounts_Password">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" DefaultButton="btnReset">
                <div class="signin-card">
                    <asp:ImageButton ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/default.png" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
                    <asp:Label ID="lblMsg1" runat="server"></asp:Label>
                    <asp:TextBox ID="txtsTendangnhap" name="Username" type="text" placeholder="Tên đăng nhập" spellcheck="false" runat="server" Width="250px"></asp:TextBox>
                    <asp:TextBox ID="txtsEmail1" name="Email" type="email" placeholder="Email đăng ký" spellcheck="false" runat="server" Width="250px"></asp:TextBox>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Image ID="imgCaptcha1" runat="server" />
                            <asp:ImageButton ID="ibtnChage1" runat="server" ImageUrl="~/Images/change.jpg" Height="30px" onclick="ChangeCaptcha_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br /><asp:TextBox ID="txtCaptcha1" runat="server" placeholder="Captcha" Width="250px"></asp:TextBox><br /><br />
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
                    <asp:ImageButton ID="ImageButton1" CssClass="profile-img" ImageUrl="~/Images/Avatar/default.png" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
                    <asp:Label ID="lblMsg2" runat="server"></asp:Label>
                    <asp:TextBox ID="txtsEmail2" name="Email" type="email" placeholder="Email đăng ký" spellcheck="false" runat="server" Width="250px"></asp:TextBox>
                    <asp:TextBox ID="txtsSdt" name="PhoneNumber" type="tel" placeholder="Số điện thoại đăng ký" spellcheck="false" runat="server" Width="250px"></asp:TextBox><br /><br />
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Image ID="imgCaptcha2" runat="server" />
                        <asp:ImageButton ID="ibtnChage2" runat="server" ImageUrl="~/Images/change.jpg" Height="30px" onclick="ChangeCaptcha_Click" />
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    <br /><asp:TextBox ID="txtCaptcha2" runat="server" placeholder="Captcha" Width="250px"></asp:TextBox><br /><br />
                    <asp:Button ID="btnFindAccount" runat="server" Text="Lấy lại tên đăng nhập" CssClass="rc-button" onclick="btnFindAccount_Click" />
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
                </div>
            </asp:Panel>
    </ContentTemplate>
        

</cc1:TabPanel>
        </cc1:TabContainer>
    </div>