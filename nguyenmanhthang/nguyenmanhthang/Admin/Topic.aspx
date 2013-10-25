<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="nguyenmanhthang.Admin.Topic" MasterPageFile="~/Admin/Admin.Master" %>
<%@ Register src="../UserControl/ListTopicUC.ascx" tagname="ListTopicUC" tagprefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="../UserControl/DetailTopicUC.ascx" tagname="DetailTopicUC" tagprefix="uc2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody_Admin" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
                <cc1:TabPanel runat="server" HeaderText="TabTopic" ID="TabPanel1">
                    <ContentTemplate>
                        <uc1:ListTopicUC ID="ListTopicUC1" runat="server" />
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel runat="server" HeaderText="TabTopicBlock" ID="TabPanel2">
                    <ContentTemplate>
                        <uc1:ListTopicUC ID="ListTopicUC2" runat="server" />
                    </ContentTemplate>
                </cc1:TabPanel>
            </cc1:TabContainer>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <uc2:DetailTopicUC ID="DetailTopicUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>