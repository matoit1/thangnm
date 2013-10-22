<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="nguyenmanhthang.Default1" MasterPageFile="~/Default.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
    <meta property="fb:app_id" content="432781806807255"/>
    <link href="../../Css/Product/tab.css" rel="stylesheet" type="text/css"/>
    <script language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div style="margin: 15px 15px 15px 15px;">
        <asp:Panel ID="pnlDetail" runat="server">
            <center><h1><asp:Label ID="lblWebsite_Title" runat="server"></asp:Label></h1></center><br /><br />
            <asp:Label ID="lblWebsite_Content" runat="server"></asp:Label><br /><br />
            <asp:Label ID="lblWebsite_LastUpdate" runat="server"></asp:Label><br />
            <asp:Label ID="lblVote" runat="server" Text="Đánh giá bài viết: "></asp:Label><asp:Label ID="Label2" runat="server" CssClass="rw-js-container"></asp:Label>
            <script language="javascript" src="http://thangnm.googlecode.com/svn/vote.js" type="text/javascript"></script>
            <br />
            <hr />
        </asp:Panel>
        <asp:Panel ID="pnlComment" runat="server">
            <div id="tabContaier">
		        <ul>
			        <li><a href="#tab1">Bình luận Facebook</a></li>
			        <li><a href="#tab2">Bình luận Google+</a></li>
		        </ul>
		        <div class="tabDetails">
			        <div id="tab1" class="tabContents">
		                <div id="Div1"></div><!-- Begin Comment Facebook -->
			            <script>
			                (function (d, s, id) {
			                    var js, fjs = d.getElementsByTagName(s)[0];
			                    if (d.getElementById(id)) return;
			                    js = d.createElement(s); js.id = id;
			                    js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1&appId=432781806807255";
			                    fjs.parentNode.insertBefore(js, fjs);
			                } (document, 'script', 'facebook-jssdk'));
                        </script>
		                <div class="fb-comments" data-href="<%=Request.Url.ToString()%>" data-width="500" data-num-posts="10"></div><!-- End Comment Facebook -->
			        </div>
			        <div id="tab2" class="tabContents">
				        <script src="https://apis.google.com/js/plusone.js"></script>
		                <div class="g-comments"
			                data-href="<%=Request.Url.ToString()%>"
			                data-width="500"
			                data-first_party_property="BLOGGER"
			                data-view_type="FILTERED_POSTMOD">
		                </div>
			        </div>
		        </div>
		        <script type="text/javascript">
		            $(document).ready(function () {
		                $(".tabContents").hide(); // Ẩn toàn bộ nội dung của tab
		                $(".tabContents:first").show(); // Mặc định sẽ hiển thị tab1
		                $("#tabContaier ul li a").click(function () { //Khai báo sự kiện khi click vào một tab nào đó
		                    var activeTab = $(this).attr("href");
		                    $("#tabContaier ul li a").removeClass("active");
		                    $(this).addClass("active");
		                    $(".tabContents").hide();
		                    $(activeTab).fadeIn();
		                });
		            });
		        </script>
	        </div>
        </asp:Panel>
        <asp:Panel ID="pnlAll" runat="server">
        <center><br /><br /><h1><asp:Label ID="lblMore" runat="server"></asp:Label></h1><br /></center>
            <asp:Repeater ID="rpTopic" runat="server" onitemcommand="rpTopic_ItemCommand" 
                onitemdatabound="rpTopic_ItemDataBound" >
                <HeaderTemplate><ul></HeaderTemplate>
                <ItemTemplate>
                    <li><asp:HiddenField ID="lblWebsite_ID" runat="server" Value='<%#Eval("Topic_ID")%>'></asp:HiddenField>
                        <asp:Label ID="Label1" runat="server" Text="Tiêu đề: "></asp:Label>
                        <asp:Label ID="lblWebsite_Title" runat="server" Text='<%#Eval("Topic_Title")%>'></asp:Label>
                        <i><asp:Label ID="lblWebsite_LastUpdate" runat="server" Text='<%#" cập nhật lần cuối: <"+Eval("Topic_LastUpdate")+">"%>'></asp:Label></i>
                        <asp:LinkButton ID="hplDetail" runat="server" CommandName="Detail"> >>Chi tiết >> </asp:LinkButton>
                    </li>
                </ItemTemplate>
                <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
        </asp:Panel>
    </div>
</asp:Content>
