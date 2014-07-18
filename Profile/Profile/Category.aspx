﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Profile.Category" MasterPageFile="~/PublicInterface.Master"  %>

<asp:Content ID="cHead" runat="server" ContentPlaceHolderID="cphHead">
    <title>Nguyễn Mạnh Thắng - Blog</title>
    <meta name="description" content="Nguyễn Mạnh Thắng - Blog" />
    <meta name="keywords" content="ThangNM, Nguyen Manh Thang, Don Gian La Chia Se, Blog, Nhat ky ca nhan" />
</asp:Content>
<asp:Content ID="cBody" runat="server" ContentPlaceHolderID="cphBody">
    <div class="blog"><!-- start main -->
	<div class="container">
		<div class="main row">
			<div class="col-md-8 blog_left">
				<h2 class="style">Bài viết chia sẻ</h2>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
                <asp:Repeater ID="rptTopic" runat="server" onitemcommand="rptTopic_ItemCommand">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="blog_main">
					    <a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID")%>'><img src='<%# Eval("sLinkImage")%>' alt="" class="blog_img img-responsive"/></a>
					    <h4><a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID")%>'><%# Eval("sTitle")%></a></h4>
						<div class="blog_list pull-left">
						    <ul class="list-unstyled">
						        <li><i class="fa fa-calendar-o"></i><span><%# Eval("tLastUpdate")%></span></li>
						        <li><a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID") +"#comment"%>'><i class="fa fa-comment"></i><span>Comments</span></a></li>
						        <li><a href='<%#"../Member.aspx?PK_iAccountsID="+Eval("FK_iAccountsID")%>'><i class="fa fa-user"></i><span><%# Eval("FK_iAccountsID")%></span></a></li>
						        <li><a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID")%>'><i class="fa fa-eye"></i><span><%# Eval("iVisit")%> views</span></a></li>
						    </ul>
						</div>
					    <div class="b_left pull-right">
                            <asp:LinkButton ID="lbtniLike" runat="server" CommandName="Like"><i class="fa fa-heart"></i><span><%# Eval("iLike")%></span></asp:LinkButton>
					    </div>
					    <div class="clearfix"></div>
					    <p class="para"><%# Eval("sDescription")%></p>
					    <div class="read_more btm">
						    <a href='<%#"../Topic.aspx?PK_lTopicID="+Eval("PK_lTopicID")%>'>view more</a>
					    </div><hr />
				    </div>
                    <asp:HiddenField ID="hfID" runat="server" Value='<%# Eval("PK_lTopicID")%>' />
                </ItemTemplate>
                <FooterTemplate></FooterTemplate>
                </asp:Repeater>
</ContentTemplate>
                    </asp:UpdatePanel>
			</div>
			<div class="col-md-4 blog_right">
				<ul class="ads_nav list-unstyled">
					<h4>Ads 125 x 125</h4>
						<li><a href="#"><img src="https://thangnm.googlecode.com/svn/profile/images/ads_pic.jpg" alt=""> </a></li>
						<li><a href="#"><img src="https://thangnm.googlecode.com/svn/profile/images/ads_pic.jpg" alt=""> </a></li>
						<li><a href="#"><img src="https://thangnm.googlecode.com/svn/profile/images/ads_pic.jpg" alt=""> </a></li>
						<li><a href="#"><img src="https://thangnm.googlecode.com/svn/profile/images/ads_pic.jpg" alt=""> </a></li>
					<div class="clearfix"></div>
				</ul>
				<ul class="tag_nav list-unstyled">
					<h4>tags</h4>
						<li class="active"><a href="#">art</a></li>
						<li><a href="#">awesome</a></li>
						<li><a href="#">classic</a></li>
						<li><a href="#">photo</a></li>
						<li><a href="#">wordpress</a></li>
						<li><a href="#">videos</a></li>
						<li><a href="#">standard</a></li>
						<li><a href="#">gaming</a></li>
						<li><a href="#">photo</a></li>
						<li><a href="#">music</a></li>
						<li><a href="#">data</a></li>
						<div class="clearfix"></div>
				</ul>
				<!-- start social_network_likes -->
					<div class="social_network_likes">
				      		 <ul class="list-unstyled">
				      		 	<li><a href="#" class="tweets"><div class="followers"><p><span>2k</span>Followers</p></div><div class="social_network"><i class="twitter-icon"> </i> </div></a></li>
				      			<li><a href="#" class="facebook-followers"><div class="followers"><p><span>5k</span>Followers</p></div><div class="social_network"><i class="facebook-icon"> </i> </div></a></li>
				      			<li><a href="#" class="email"><div class="followers"><p><span>7.5k</span>members</p></div><div class="social_network"><i class="email-icon"> </i></div> </a></li>
				      			<li><a href="#" class="dribble"><div class="followers"><p><span>10k</span>Followers</p></div><div class="social_network"><i class="dribble-icon"> </i></div></a></li>
				      			<div class="clear"> </div>
				    		</ul>
		          	</div>
				<div class="news_letter">
					<h4>news letter</h4>
						<form>
							<span><input type="text" placeholder="Your email address"></span>
							<span  class="pull-right fa-btn btn-1 btn-1e"><input type="submit" value="subscribe"></span>
						</form>
				</div>
			</div>
			<div class="clearfix"></div>
		</div>
	</div>
</div><!-- end main -->
</asp:Content>
