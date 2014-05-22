<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HaBa._Default" MasterPageFile="~/ShareInterface/ProductSI.Master" %>
<%@ Register src="~/UserControl/ShowAllProductUC.ascx" tagname="ShowAllProductUC" tagprefix="uc2" %>
<%@ Register src="~/UserControl/ProducGroupUC.ascx" tagname="ProducGroupUC" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
<!-- Slidr[start] -->
	    <div id="slides-section">
		    <div style="overflow: hidden; display: block;" id="slides">
			    <div style="overflow: hidden; z-index: 1; position: relative; width: 1349px; height: 502.287px;" class="slidesjs-container">
				    <div style="position: relative; z-index: 1; left: 0px; width: 1349px; height: 502.287px;" class="slidesjs-control">
					    <img slidesjs-index="0" style="position: absolute; top: 0px; left: 0px; width: 100%; z-index: 10;" class="slidesjs-slide" alt="HaBa" src="../App_Themes/Images/Home_banner.jpg">
				    </div>
			    </div>
		    </div>
	    </div>
	    <!-- Slidr[end] -->
	    <!-- Ticker [start] -->
	    <div class="featurehomer section" id="featurehomer1">
		    <div class="widget HTML" id="HTML22">
			    <div class="widget-content">
				    <div class="featureticker-wrap">
					    <div id="featuresticker">
						    <div id="ticker">
							    <ul class="ticker-list">
								    <li>
									    <div class="ticker-head1">
										    <h3><strong style="font-family:'Mr Dafoe', cursive; text-transform:none;">HaBa !</strong> Giá rẻ cho mẹ - Niềm vui cho bé</h3><p>Nơi cung cấp các sản phẩm cho bé <b style="color: teal;">Hàng Việt Nam</b> chất lượng, mẫu mã được cập nhật liên tục, giá bán lẻ luôn ưu đãi, giá bán buôn luôn cạnh tranh.</p>
									    </div>
									    <div class="ticker-head2">
										    <div class="buttons buy"><a href="../GioiThieu.aspx">Xem Ngay</a></div>
									    </div>
								    </li>
								    <div style="clear: both;">
								    <li>
									    <div class="ticker-head1">
										    <h3><strong>Uy tín - Chất Lượng</strong> đó là điêu tôi đảm bảo</h3><p>Chúng tôi luôn đặt chữ tín lên hàng đầu và sản phẩn của chúng tôi là chất lượng nhất</p>
									    </div>
									    <div class="ticker-head2">
										    <div class="buttons buy"><a href="#">Xem Ngay</a></div>
									    </div>
								    </li>
								    <div style="clear: both;">
								    <li>
									    <div class="ticker-head1">
										    <h3><strong>Giá rẻ nhất?</strong> điều chúng tôi cam đoan</h3><p>Với những mặt hàng chất lượng chúng tôi cũng cam đoan rằng giá các sản phẩn của chúng tôi sẽ là rẻ nhất</p></div>
									    <div class="ticker-head2">
										    <div class="buttons buy"><a href="#">Xem Ngay</a></div>
									    </div>
								    </li>
								    <div style="clear: both;">
								    <li>
									    <div class="ticker-head1">
										    <h3><strong>Địa chỉ liên hệ</strong> trụ sở chính</h3><p>Tòa nhà chọc trời 2 tầng - 1000 Minh Khai - HBT - Hà Nội</p>
									    </div>
									    <div class="ticker-head2">
										    <div class="buttons buy"><a href="#">Đi ngay</a></div>
									    </div>
								    </li>
								    <div style="clear: both;">
								    <li>
									    <div class="ticker-head1">
										    <h3><strong>Địa chỉ liên hệ?</strong> hãy gửi mail cho Bít Tuốt:)</h3><p>Hãy liên hệ với tôi qua gmail: Seo.vnpro@gmail.com</p></div>
									    <div class="ticker-head2">
										    <div class="buttons buy"><a href="#">Gửi luôn</a></div>
									    </div>
								    </li>
								    <div style="clear: both;">
								    </div></div></div></div></div>
							    </ul>
						    </div>
					    </div>
				    </div>
			    </div>
			    <div class="clear"></div>
		    </div>
	    </div>
	    <!-- Ticker [end] -->
	    <!-- Featured Home Posts [start] -->
	    <div id="featuredhome">
		    <uc4:producgroupuc ID="ProducGroupUC1" runat="server" />
	    </div>
	    <!-- Featured Home Posts [end] -->
	    <!-- Main Body [start] -->
        <div id="body-wrapper">
	    <div id="outer-wrapper">
	        <div id="wrap2">
	            <div id="content-wrapper">
	                <!-- Main wapper [start] -->
                    <div id="main-wrapper">
		            <div id="home_navigation">
			            <h1 class="our_portfolio">HaBa</h1>
			            <span class="line-home"></span>
			            <ul class="home_nav">
                            <li><a href="#">Xem Hàng</a></li>
				            <li><a href="#">Lựa Chọn Hàng</a></li>
				            <li><a href="#">Đặt Hàng</a></li>
				            <li><a href="#">Giao Hàng</a></li>
				            <li class="al"><a href="#">Thanh Toán</a></li>
			            </ul>
		            </div>
                    <br /><br /><br />
		            <div class="main section" id="main">
			            <uc2:showallproductuc ID="ShowAllProductUC1" runat="server" />
		            </div>
                    </div>
	                <!-- Main wapper [end] -->
	            </div>
	            <!-- end content-wrapper -->
	            </div>
            </div>
	    </div>
	    <!-- Main Body [end] -->
</asp:Content>
