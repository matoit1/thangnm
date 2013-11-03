<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="nguyenmanhthang.Admin.Users" MasterPageFile="~/Admin/Admin.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="../UserControl/AccountsDetailUC.ascx" tagname="AccountsDetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/AccountsListUC.ascx" tagname="AccountsListUC" tagprefix="uc2" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody_Admin" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
        <cc1:TabPanel runat="server" HeaderText="Tài khoản đang hoạt động" ID="tabAccounts">
        <ContentTemplate>
        <uc2:AccountsListUC ID="AccountsListUC1" runat="server" OnPageChangeAccounts="PageChangeAccounts_Click" OnViewAccounts="ViewAccounts_Click" />
        </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="Tài khoản đang bị khóa" ID="tabAccountsBlock">
        <ContentTemplate>
        <uc2:AccountsListUC ID="AccountsListUC2" runat="server" OnPageChangeAccounts="PageChangeAccountsBlock_Click" OnViewAccounts="ViewAccountsBlock_Click" />
        </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="Thông tin chi tiết tài khoản" ID="tabDetail">
        <ContentTemplate>
        <uc1:AccountsDetailUC ID="AccountsDetailUC1" runat="server" OnBack="Back_Click" />
        </ContentTemplate>
        </cc1:TabPanel>
        </cc1:TabContainer>
</asp:Content>