<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="nguyenmanhthang.Admin.Topic" MasterPageFile="~/Admin/Admin.Master" %>
<%@ Register src="../UserControl/TopicListUC.ascx" tagname="TopicListUC" tagprefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="../UserControl/TopicDetailUC.ascx" tagname="TopicDetailUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/CommentListUC.ascx" tagname="CommentListUC" tagprefix="uc3" %>
<%@ Register src="../UserControl/CommentDetailUC.ascx" tagname="CommentDetailUC" tagprefix="uc4" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody_Admin" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
            <cc1:TabPanel runat="server" HeaderText="Bài viết đã đăng" ID="TabTopic">
            <ContentTemplate>
            <uc1:TopicListUC ID="TopicListUC1" runat="server" OnViewTopic="ViewTopic_Click" OnPageChangeTopic="PageChangeTopic_Click" OnNewTopic="NewTopic_Click" OnDeleteTopic="DeleteTopic_Click" OnExportToExcelTopic="ExportToExcelTopic_Click"/>
            </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel runat="server" HeaderText="Bài viết bị khóa" ID="TabTopicBlock">
            <ContentTemplate>
            <uc1:TopicListUC ID="TopicListUC2" runat="server" OnViewTopic="ViewTopicBlock_Click" OnPageChangeTopic="PageChangeTopicBlock_Click" OnNewTopic="NewTopic_Click" OnDeleteTopic="DeleteTopic_Click" OnExportToExcelTopic="ExportToExcelTopicBlock_Click"/>
            </ContentTemplate>
            </cc1:TabPanel>
            </cc1:TabContainer>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <cc1:TabContainer ID="tabDetail" runat="server" ActiveTabIndex="0">
            <cc1:TabPanel runat="server" HeaderText="Chi tiết bài viết" ID="TabDetailTopic">
            <ContentTemplate>
            <uc2:TopicDetailUC ID="TopicDetailUC1" runat="server" OnBack="Back_Click"/>
                </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel runat="server" HeaderText="Bình luận" ID="TabComment">
                <ContentTemplate>
                <uc3:CommentListUC ID="CommentListUC1" runat="server" OnViewComment="ViewComment_Click" OnPageChangeComment="PageChangeComment_Click" OnNewComment="NewComment_Click" OnDeleteComment="DeleteComment_Click" OnExportToExcelComment="ExportToExcelComment_Click"/>
                </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel runat="server" HeaderText="Bình luận bị khóa" ID="TabCommentBlock">
                <ContentTemplate>
                <uc3:CommentListUC ID="CommentListUC2" runat="server" OnViewComment="ViewCommentBlock_Click" OnPageChangeComment="PageChangeCommentBlock_Click" OnNewComment="NewComment_Click" OnDeleteComment="DeleteComment_Click" OnExportToExcelComment="ExportToExcelCommentBlock_Click"/>
                </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel runat="server" HeaderText="Chi tiết bình luận" ID="TabCommentDetail">
                <ContentTemplate>
                <uc4:CommentDetailUC ID="CommentDetailUC1" runat="server" />
                </ContentTemplate>
                </cc1:TabPanel>
                </cc1:TabContainer>
        </asp:View>
    </asp:MultiView>

</asp:Content>