<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="Profile.Topic" MasterPageFile="~/PublicInterface.Master" %>

<asp:Content ID="cHead" runat="server" ContentPlaceHolderID="cphHead">
    <meta property="fb:app_id" content="432781806807255"/>
    <link href="App_Themes/topic.css" rel='stylesheet' type='text/css' />
</asp:Content>
<asp:Content ID="cBody" runat="server" ContentPlaceHolderID="cphBody">
    <div class="blog"><!-- start main -->
	<div class="container">
		<div class="main row">
			<h2 class="style"><asp:Label ID="lblsTitle" runat="server"></asp:Label></h2>
            <div class="blog_list pull-left" style="margin-top:0px">
			    <ul class="list-unstyled">
				    <li><i class="fa fa-calendar-o"></i><span><asp:Label ID="lbltLastUpdate" runat="server"></asp:Label></span></li>
				    <li><asp:HyperLink ID="hplPK_lTopicID" runat="server"><a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID") +"#comment"%>'><i class="fa fa-comment"></i><span>Comments</span></a></asp:HyperLink></li>
				    <li><asp:HyperLink ID="hplFK_iAccountsID" runat="server"><a href='<%#"../Member.aspx?PK_iAccountsID="+Eval("FK_iAccountsID")%>'><i class="fa fa-user"></i><span><asp:Label ID="lblFK_iAccountsID" runat="server"></asp:Label></span></a></asp:HyperLink></li>
				    <li><asp:HyperLink ID="hplPK_lTopicID1" runat="server"><a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID")%>'><i class="fa fa-eye"></i><span><asp:Label ID="lbliVisit" runat="server"></asp:Label> views</span></a></asp:HyperLink></li>
			    </ul>
		    </div>
		    <div class="b_left pull-right">
                <asp:LinkButton ID="lbtniLike" runat="server" CommandName="Like"><i class="fa fa-heart"></i><span><%# Eval("iLike")%></span></asp:LinkButton>
		    </div>
            <div class="clearfix"></div><br />
			<p class="para"><asp:Label ID="lblsContent" runat="server"></asp:Label></p>
			<div class="clearfix"></div>
		</div>
        <div class="divtag">
            <asp:Repeater ID="rptTag" runat="server">
                <HeaderTemplate><ul class="tags"></HeaderTemplate>
                <ItemTemplate>
                    <li><asp:HyperLink ID="hplComment" runat="server" NavigateUrl='<%#"~/Tag.aspx?PK_sTagID="+Eval("PK_sTagID")%>'><%#Eval("sName")%></asp:HyperLink></li>
                </ItemTemplate>
                <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
        </div>
        <div class="clear"></div>
        <div class="main row">
        <div id="fb-root"></div>
        <script>
            (function (d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) return;
                js = d.createElement(s); js.id = id;
                js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&appId=432781806807255&version=v2.0";
                fjs.parentNode.insertBefore(js, fjs);
            } (document, 'script', 'facebook-jssdk'));
        </script>
        <div class="fb-comments" data-href="<%=Request.Url.AbsoluteUri.ToString()%>" data-colorscheme="light" data-numposts="10" data-width="700"></div>
        <div id="comment"><a href="comment"></a></div>
        </div>
	</div>
</div><!-- end main -->
</asp:Content>