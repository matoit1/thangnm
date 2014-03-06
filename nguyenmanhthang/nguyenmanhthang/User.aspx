<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="nguyenmanhthang.User" MasterPageFile="~/Common/Default.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <br /><br /><br />
    <center><asp:Label ID="lblTitle" runat="server" ForeColor="Orange" Font-Size="Large"></asp:Label></center>
    <div style="margin-left: 30px">
        <asp:Panel ID="pnlSecret1" runat="server">
            <asp:Label ID="lblAccounts_ID" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Username" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Password" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Email" runat="server"></asp:Label><br />
        </asp:Panel>
            <asp:Label ID="lblAccounts_FullName" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Address" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_DateOfBirth" runat="server"></asp:Label><br />
        <asp:Panel ID="pnlSecret2" runat="server">
            <asp:Label ID="lblAccounts_PhoneNumber" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Permission" runat="server"></asp:Label><br />
        </asp:Panel>
            <asp:Label ID="lblAccounts_LinkAvatar" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Signature" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Like" runat="server"></asp:Label><br />
        <asp:Panel ID="pnlSecret3" runat="server">
            <asp:Label ID="lblAccounts_Notification" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_Status" runat="server"></asp:Label><br />
            <asp:Label ID="lblAccounts_RegisterDate" runat="server"></asp:Label><br /><br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Enabled="true" />
        </asp:Panel>
        </div>
</asp:Content>
