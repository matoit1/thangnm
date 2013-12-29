<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="nguyenmanhthang.About" MasterPageFile="~/Default.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="~/UserControl/CommentUC.ascx" tagname="CommentUC" tagprefix="uc2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
    <meta property="fb:app_id" content="432781806807255"/>
    <link href="../Css/topic.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .content-left-right
        {
            width: 20px;
        }
        .content-center
        {
            width: 680px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:Panel ID="pnlDetail" runat="server">
         <asp:Repeater ID="rptInfo" runat="server" 
             onitemdatabound="rptInfo_ItemDataBound" >
                <ItemTemplate>
                    <div class="all">
                        <div class="panelLastUpdate">
                            <asp:Label ID="Label3" runat="server" Text='<%#" Bài đăng vào lúc: " + Eval("Topic_LastUpdate")%>'></asp:Label>
                            <span style="float:right; margin-right:30px; font-size: 20px;"><asp:HyperLink ID="hplComment" ForeColor="#CC0099" runat="server" NavigateUrl="#1">#1</asp:HyperLink></span>
                        </div>
                        <div class="left">
                            <asp:ImageButton ID="imgAccounts_LinkAvatar" ImageUrl='<%#Eval("Accounts_LinkAvatar")%>' runat="server" Width="100px" Height="100px" />
                        </div>
                        <div class="center">
                            <asp:Label ID="lblAccounts_Username" runat="server" Text='<%#Eval("Accounts_FullName")%>'></asp:Label><br />
                            <asp:Label ID="lblAccounts_Permission" runat="server" Text='<%#" Quyền hạn:" + Eval("Accounts_Permission")%>'></asp:Label><br />
                            <asp:Label ID="Label4" runat="server" Text='<%#" Ngày tham gia: " + Eval("Accounts_RegisterDate")%>'></asp:Label><br />
                            <asp:Label ID="lblAccounts_Like" runat="server" Text='<%#"Like: " + Eval("Accounts_Like")%>'></asp:Label><br />
                            <asp:Label ID="lblCountTopic" runat="server" Text='<%#"Tổng số bài viết: " + Eval("CountTopic")%>'></asp:Label><br />
                        </div>
                        <div class="right">
                            <asp:Label ID="lblTopic_Visit" runat="server" Text='<%#Eval("Topic_Visit")+" lượt xem"%>'></asp:Label><br />
                            <asp:Label ID="lblVote" runat="server" Text="Đánh giá bài viết: "></asp:Label><asp:Label ID="Label2" runat="server" CssClass="rw-js-container"></asp:Label>
                            <script language="javascript" src="http://thangnm.googlecode.com/svn/vote.js" type="text/javascript"></script>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="noidung">
                        <table width="700px">
                            <tr>
                                <td class="content-left-right"><asp:Button ID="btnBack" runat="server" Text="Trở lại" /></td>
                                <td></td>
                                <td class="content-left-right"><asp:Button ID="btnPrevious" runat="server" Text="Tiến" onclick="btnPrevious_Click" /></td>
                            </tr>
                            <tr>
                                <td class="content-left-right"></td>
                                <td class="content-center"><asp:Image ID="imgAnimatedPictures" runat="server" ImageUrl='<%#Eval("Topic_LinkImage")%>' width="650px" /></td>
                                <td class="content-left-right"></td>
                            </tr>
                            <tr>
                                <td class="content-left-right"><asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Topic_ID")%>'></asp:HiddenField></td>
                                <td class="content-center"><asp:Label ID="Label5" runat="server" Text='<%#Eval("Topic_Title")%>' Font-Size="22px" Font-Bold="true"></asp:Label></td>
                                <td class="content-left-right"></td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="clear"></div>
            <div class="divtag">
                <asp:Repeater ID="rptTag" runat="server" onitemdatabound="rptTag_ItemDataBound" >
                    <HeaderTemplate><ul class="tags"></HeaderTemplate>
                    <ItemTemplate>
                        <li><asp:HyperLink ID="hplComment" runat="server" NavigateUrl='<%#"~/Tag.aspx?Topic_Tag="+Eval("Topic_Tag")%>'><%#Eval("Topic_Tag")%></asp:HyperLink></li>
                    </ItemTemplate>
                    <FooterTemplate></ul></FooterTemplate>
                </asp:Repeater>
            </div><div class="clear"></div>
    </asp:Panel>
    <div style="margin: 15px 15px 15px 15px;">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
        <cc1:TabPanel runat="server" HeaderText="Bình luận" ID="TabCommentDefault">
            <ContentTemplate>
                <asp:Repeater ID="rptComment" runat="server">
                <ItemTemplate>
                    <asp:HyperLink ID="hplComment_Name" runat="server" NavigateUrl='<%#Eval("Comment_Website")%>'><%#Eval("Comment_Name")%></asp:HyperLink>
                    <i><asp:Label ID="lblComment_LastUpdate" runat="server" Text='<%#Eval("Comment_LastUpdate")%>'></asp:Label></i><br />
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Comment_Content")%>'></asp:Label>
                    <hr /><br />
                </ItemTemplate>
                <FooterTemplate><div id="comment_success"><a href="comment_success"></a></div></FooterTemplate>
                </asp:Repeater>
                <br /><br />
                <uc2:CommentUC ID="CommentUC1" runat="server" />
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="Bình luận bằng Google" ID="TabCommentGoogle">
            <ContentTemplate>
                <script src="https://apis.google.com/js/plusone.js"></script>
		        <div class="g-comments"
			        data-href="<%=Request.Url.ToString()%>"
			        data-width="500"
			        data-first_party_property="BLOGGER"
			        data-view_type="FILTERED_POSTMOD">
		        </div>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="Bình luận bằng Facebook" ID="TabCommentFacebook">
            <ContentTemplate>
                <div id="fb-root"></div>
                <script>                    (function (d, s, id) {
                        var js, fjs = d.getElementsByTagName(s)[0];
                        if (d.getElementById(id)) return;
                        js = d.createElement(s); js.id = id;
                        js.src = "//connect.facebook.net/en_US/all.js#xfbml=1&appId=432781806807255";
                        fjs.parentNode.insertBefore(js, fjs);
                    } (document, 'script', 'facebook-jssdk'));</script>
                <div class="fb-comments" data-href="<%=Request.Url.AbsoluteUri.ToString()%>" data-colorscheme="light" data-numposts="10" data-width="500"></div>            
            </ContentTemplate>
        </cc1:TabPanel>
    </cc1:TabContainer>
        <asp:Panel ID="pnlAll" runat="server">
        <center><asp:Label ID="lblMessage" runat="server"></asp:Label><br /><br /><h1><asp:Label ID="lblMore" runat="server"></asp:Label></h1><br /></center>
            <asp:Repeater ID="rptTopic" runat="server" onitemcommand="rptTopic_ItemCommand" 
                onitemdatabound="rptTopic_ItemDataBound" >
                <HeaderTemplate><ul></HeaderTemplate>
                <ItemTemplate>
                    <li><asp:HiddenField ID="lblWebsite_ID" runat="server" Value='<%#Eval("Topic_ID")%>'></asp:HiddenField>
                        <asp:Label ID="lblWebsite_Title" runat="server" Text='<%#Eval("Topic_Title")%>'></asp:Label><br />
                        <i><asp:Label ID="lblWebsite_LastUpdate" runat="server" Text='<%#" cập nhật lần cuối: <"+Eval("Topic_LastUpdate")+">"%>'></asp:Label></i>
                        <asp:LinkButton ID="hplDetail" runat="server" CommandName="Detail"> >> Chi tiết >> </asp:LinkButton>
                        <hr /><br />
                    </li>
                </ItemTemplate>
                <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
        </asp:Panel>
    </div>
</asp:Content>