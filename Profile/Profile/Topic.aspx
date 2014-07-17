<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="Profile.Topic" MasterPageFile="~/PublicInterface.Master" %>

<asp:Content ID="cHead" runat="server" ContentPlaceHolderID="cphHead">
    <meta property="fb:app_id" content="432781806807255"/>
</asp:Content>
<asp:Content ID="cBody" runat="server" ContentPlaceHolderID="cphBody">
    <div class="blog"><!-- start main -->
	<div class="container">
		<div class="main row">
			<h2 class="style"><asp:Label ID="lblsTitle" runat="server"></asp:Label></h2>
			<p class="para"><asp:Label ID="lblsContent" runat="server"></asp:Label></p>
			<div class="clearfix"></div>
		</div>

        <div class="divtag">
            <asp:Repeater ID="rptTag" runat="server">
                <HeaderTemplate><ul class="tags"></HeaderTemplate>
                <ItemTemplate>
                    <li><asp:HyperLink ID="hplComment" runat="server" NavigateUrl='<%#"~/Tag.aspx?PK_sTagID="+Eval("Topic_Tag")%>'><%#Eval("sName")%></asp:HyperLink></li>
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