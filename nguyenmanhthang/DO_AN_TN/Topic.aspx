<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="DO_AN_TN.Topic" MasterPageFile="~/Share_Interface/Home_SI.Master"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
    <meta property="fb:app_id" content="432781806807255"/>
    <link href="../Css/topic.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel ID="pnlDetail" runat="server">
                    <div class="all">
                        <div class="panelLastUpdate">
                            <asp:Label ID="lbltNgayCapNhat" runat="server"></asp:Label>
                            <span style="float:right; margin-right:30px; font-size: 20px;"><asp:HyperLink ID="hplComment" ForeColor="#CC0099" runat="server" NavigateUrl="#1">#1</asp:HyperLink></span>
                        </div>
                        <div class="left">
                            <asp:ImageButton ID="imgsLinkAnh" runat="server" Width="100px" Height="100px" />
                        </div>
                        <div class="center">
                            <asp:Label ID="lblFK_sMaGV" runat="server"></asp:Label><br />                            
                        </div>
                        <div class="right">
                            <asp:Label ID="lbliLuotXem" runat="server"></asp:Label><br />
                            <asp:Label ID="lblVote" runat="server" Text="Đánh giá bài viết: "></asp:Label><asp:Label ID="Label2" runat="server" CssClass="rw-js-container"></asp:Label>
                            <script language="javascript" src="http://thangnm.googlecode.com/svn/vote.js" type="text/javascript"></script>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="noidung">
                        <asp:HiddenField ID="lblPK_lMaBaiViet" runat="server"></asp:HiddenField>
                        <center><h1><asp:Label ID="lblsTieuDe" runat="server" Font-Size="22px" Font-Bold="true"></asp:Label></h1></center><hr /><br />
                        <asp:Label ID="lblsNoiDung" runat="server" ></asp:Label>
                    </div>>
            <div class="clear"></div>
            <div class="divtag">
                <asp:Repeater ID="rptTag" runat="server" onitemdatabound="rptTag_ItemDataBound" >
                    <HeaderTemplate><ul class="tags"></HeaderTemplate>
                    <ItemTemplate>
                        <li><asp:HyperLink ID="hplComment" runat="server" NavigateUrl='<%#"~/Tag.aspx?sTag="+Eval("sTag")%>'><%#Eval("sTag")%></asp:HyperLink></li>
                    </ItemTemplate>
                    <FooterTemplate></ul></FooterTemplate>
                </asp:Repeater>
            </div><div class="clear"></div>
    </asp:Panel>
    <div style="margin: 15px 15px 15px 15px;">
    <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
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
    </div>
</asp:Content>
