<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.ContactUC" %>
<asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnSent">
    <div class="signin-card">
        <asp:ImageButton ID="imgProfile" CssClass="profile-img" ImageUrl="~/Images/Avatar/admin.jpg" AlternateText="ThangNM" PostBackUrl="~/Default.aspx" runat="server" /><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:TextBox ID="txtFullName" name="FullName" type="text" placeholder="Họ và Tên" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
        <asp:TextBox ID="txtEmail" name="Email" type="email" placeholder="Email" spellcheck="false" runat="server"></asp:TextBox><span style="color:Red"> *</span>
        <asp:TextBox ID="txtContent" name="Content" TextMode="MultiLine" Height="200px" placeholder="Nội dung" runat="server"></asp:TextBox><span style="color:Red; position:absolute"> *</span>
        <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList><span style="color:Red"> *</span><br />
        <asp:Button ID="btnSent" runat="server" Text="Gửi đi" CssClass="rc-button" onclick="btnSent_Click" />
        <asp:HyperLink ID="hplHelp" runat="server" NavigateUrl="~/FAQ.aspx">Bạn cần trợ giúp?</asp:HyperLink>
    </div>
</asp:Panel>