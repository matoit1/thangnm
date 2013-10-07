<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ThangNMjsc.Product.Product" MasterPageFile="~/MasterPage/PublicProduct.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Product" runat="server">
    <meta property="fb:app_id" content="432781806807255"/>
    <link href="../../Css/Product/tab.css" rel="stylesheet" type="text/css"/>
    <link href="../../Css/Product/FastHoverSlideshow.css" rel="stylesheet" type="text/css"/>
    <script language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div class="slideshow">
			<div class="hs-wrapper">
				<asp:Image ID="imgProducts_Image1" runat="server" AlternateText="Products_Image1: Unknown"/>
                <asp:Image ID="imgProducts_Image2" runat="server" AlternateText="Products_Image1: Unknown"/>
                <asp:Image ID="imgProducts_Image3" runat="server" AlternateText="Products_Image1: Unknown"/>
				<div class="hs-overlay">
					<span><strong>Tip</strong> Shop</span>
				</div>
			</div>
    </div>
    <div class="detail">
        <p><strong><asp:Label ID="lblProducts_Name" runat="server" ></asp:Label></strong><br />
            Mã SP: #<asp:Label ID="lblProducts_ID" runat="server" CssClass="Text"></asp:Label><br />
            <asp:Label ID="lblVote" runat="server" Text="Đánh giá sản phẩm: "></asp:Label><asp:Label ID="Label2" runat="server" CssClass="rw-js-container"></asp:Label>
            <script language="javascript" src="http://thangnm.googlecode.com/svn/vote.js" type="text/javascript"></script>
            <br />
            Cập nhật lần cuối: <asp:Label ID="lblProducts_LastUpdate" runat="server" CssClass="Text"></asp:Label><br />
        </p><hr />
        <p>Giá bán SP: <asp:Label ID="lblProducts_Price" runat="server"></asp:Label><asp:Label ID="lblVat" runat="server"></asp:Label><br />
            Giảm giá SP: <asp:Label ID="lblProducts_Sale" runat="server"></asp:Label>
        </p>
        <center><p><asp:ImageButton ID="ibtnBuy" CommandName="add" runat="server" ImageUrl="~/Css/Product/theme/buy.png" onclick="ibtnBuy_Click" /></p></center><br />
    </div>
    <div id="tabContaier">
		<ul>
			<li><a class="active" href="#tab1">Mô tả sản phẩm</a></li>
			<li><a href="#tab2">Bình luận Facebook</a></li>
			<li><a href="#tab3">Bình luận Google+</a></li>
		</ul>
		<div class="tabDetails">
			<div id="tab1" class="tabContents">
				<p>Mô tả SP:<asp:Label ID="lblProducts_Description" runat="server"></asp:Label></p>
                <p>Thông tin SP: <asp:Label ID="lblProducts_Info" runat="server"></asp:Label></p>
                <p>Xuất xứ SP: <asp:Label ID="lblProducts_Origin" runat="server"></asp:Label></p>
			</div>
			<div id="tab2" class="tabContents">
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
			<div id="tab3" class="tabContents">
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
    <div class="clear"><br /><br /></div>
    <div class="ienlarger">
            <h1>&nbsp;&nbsp;&nbsp;Các Sản phẩm cùng loại</h1>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" DataKeyField="Products_ID" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <div style="width:240px; padding: 5px 5px 5px 5px; border: 1px dotted red">
                    <asp:LinkButton ID="LinkButton1" runat="server"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' Width="180px" class="resize_thumb" AlternateText='<%#Eval("Products_Name") %>'/>
                    <span><asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' Width="180px" AlternateText='<%#Eval("Products_Name") %>'/> Tên SP: <%#Eval("Products_Name")%></span></asp:LinkButton><br />
                    <asp:Label ID="Label1" runat="server" Text="Mã SP: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="lblProducts_ID" runat="server" Text='<%#Eval("Products_ID") %>'></asp:Label><br />
                    <asp:Label ID="Label2" runat="server" Text="Tên SP: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="lblProducts_Name" runat="server" Text='<%#Eval("Products_Name") %>'></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" Text="Giá bán: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="lblProducts_Price" runat="server" Text='<%#Eval("Products_Price") %> '></asp:Label><br />
                    <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/Images/icon_chitiet.gif" CommandName="Detail"/>
                    <asp:ImageButton ID="ImageButton1" CommandName="add" runat="server" ImageUrl="~/Css/Product/theme/buy.png" /><br /><br />
                </div>
            </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>"
                SelectCommand="SELECT TOP 6 * FROM Products Where (Products_Group<>0)">
            </asp:SqlDataSource>
        </div>
</asp:Content>
