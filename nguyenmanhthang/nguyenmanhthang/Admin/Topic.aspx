<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="nguyenmanhthang.Admin.Topic" MasterPageFile="~/Admin/Admin.Master" %>
<%@ Register src="../UserControl/TopicListUC.ascx" tagname="TopicListUC" tagprefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="../UserControl/TopicDetailUC.ascx" tagname="TopicDetailUC" tagprefix="uc2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody_Admin" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
                <cc1:TabPanel runat="server" HeaderText="Bài viết" ID="TabTopic">
                    <ContentTemplate>
                        <uc1:TopicListUC ID="TopicListUC1" runat="server" OnViewTopic="OnViewTopic_Click" OnPageChangeTopic="OnPageChangeTopic_Click"/>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel runat="server" HeaderText="Bài viết bị khóa" ID="TabTopicBlock">
                    <ContentTemplate>
                        <uc1:TopicListUC ID="TopicListUC2" runat="server" OnViewTopic="OnViewTopicBlock_Click" OnPageChangeTopic="OnPageChangeTopicBlock_Click"/> 
                    </ContentTemplate>
                </cc1:TabPanel>
        </cc1:TabContainer>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <uc2:TopicDetailUC ID="TopicDetailUC1" runat="server" OnBack="OnBack_Click"/>
        </asp:View>
    </asp:MultiView>
    <asp:ImageButton ID="ibtnAdd" runat="server" ImageUrl="~/Images/Template/btnNewTopic.png" onclick="ibtnAdd_Click" CssClass="btnNewTopic" />
</asp:Content>