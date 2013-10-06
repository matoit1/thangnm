<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThangNMjsc.Product.Default" MasterPageFile="~/MasterPage/PublicProduct.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Product" runat="server">
    <link rel="stylesheet" type="text/css" href="show/style6.css" />
    <script language="javascript" type="text/javascript" src="show/jquery.js"></script>
    <script language="javascript" type="text/javascript" src="show/jquery.easing.js"></script>
    <script language="javascript" type="text/javascript" src="show/script.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var buttons = { previous: $('#jslidernews3 .button-previous'),
                next: $('#jslidernews3 .button-next')
            };

            var _complete = function (slider, index) {
                $('#jslidernews3 .slider-description').animate({ height: 0 });
                slider.find(".slider-description").animate({ height: 100 })
            }; ;
            $('#jslidernews3').lofJSidernews({ interval: 4000,
                direction: 'opacity',
                easing: 'easeOutBounce',
                duration: 1200,
                auto: true,
                mainWidth: 752,
                buttons: buttons,
                onComplete: _complete
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div>
        <div id="welcome">
            <!-- MAIN CONTENT --> 
		<div id="jslidernews3" class="lof-slidecontent" style="width:752px; height:260px;">   
			<div class="button-previous">Previous</div> 
			<div class="main-slider-content" style="width:752px; height:260px;">
                <div class="sliders-wrapper" style="width: 752px;">
				<ul class="sliders-wrap-inner lof-opacity">
                    <li style="width: 752px; opacity: 1; z-index: 3;">
                        <img src="show/thumbl_980x340.png" title="Newsflash 2" width="752px" height="260px">           
                        <div class="slider-description" style="height: 100px;">
							<div class="description-wrapper">
								<div class="slider-meta">
                                    <h4>Content of Newsflash 1<a class="readmore" href="http://www.landofcoder.com/demo/jquery/lofslidernews/index6.html#">Read more </a></h4>
								</div>
							</div>
						</div>
                    </li> 
					<li style="width: 752px; opacity: 0; z-index: 1;">
						<img src="show/thumbl_980x340_002.png" title="Newsflash 1" width="752px" height="260px">           
                        <div class="slider-description" style="height: 0px;">
							<div class="description-wrapper">
								<div class="slider-meta">
                                    <h4>Content of Newsflash 2<a class="readmore" href="http://www.landofcoder.com/demo/jquery/lofslidernews/index6.html#">Read more </a></h4>
								</div>
							</div>
						</div>
					</li> 
					<li style="width: 752px; opacity: 0; z-index: 1;">
						<img src="show/thumbl_980x340_003.png" title="Newsflash 3" width="752px" height="260px">            
                        <div class="slider-description" style="height: 0px;">
							<div class="description-wrapper">
								<div class="slider-meta">
                                    <h4>Content of Newsflash 3</h4><a class="readmore" href="http://www.landofcoder.com/demo/jquery/lofslidernews/index6.html#">Read more </a>
								</div>
							</div>
						</div>
					</li> 
                    <li style="width: 752px; opacity: 0; z-index: 1;">
						<img src="show/thumbl_980x340_004.png" title="Newsflash 5" width="752px" height="260px">            
                        <div class="slider-description" style="height: 0px;">
							<div class="description-wrapper">
								<div class="slider-meta">
                                    <h4>Content of Newsflash 4</h4><a class="readmore" href="http://www.landofcoder.com/demo/jquery/lofslidernews/index6.html#">Read more </a>
								</div>
							</div>
						</div>
                    </li> 
                    <li style="width: 752px; opacity: 0; z-index: 1;">
						<img src="show/thumbl_980x340_005.png" title="Newsflash 5" width="752px" height="260px">            
						<div class="slider-description" style="height: 0px;">
							<div class="description-wrapper">
								<div class="slider-meta">
                                    <h4>Content of Newsflash 5</h4><a class="readmore" href="http://www.landofcoder.com/demo/jquery/lofslidernews/index6.html#">Read more </a>
								</div>
							</div>
						</div>
                    </li> 
                    <li style="width: 752px; opacity: 0; z-index: 1;">
						<img src="show/thumbl_980x340_006.png" title="Newsflash 5" width="752px" height="260px">            
                        <div class="slider-description" style="height: 0px;">
							<div class="description-wrapper">
								<div class="slider-meta">
                                    <h4>Content of Newsflash 6</h4><a class="readmore" href="http://www.landofcoder.com/demo/jquery/lofslidernews/index6.html#">Read more </a>
								</div>
							</div>
						</div>
                    </li>
				</ul>
				</div>  	
            </div> 
			<div class="button-next">Next</div>
		</div>
 		<!-- END MAIN CONTENT -->
        </div><!-- End #welcome -->
            <asp:Repeater ID="rpListProductGroup" runat="server" OnItemDataBound="rpListProductGroup_ItemDataBound">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <div class="ienlarger">
                    <h1><a href="../Group.aspx?Products_ID=<%#Eval("Products_ID")%>">&nbsp;&nbsp;&nbsp;<%#Eval("Products_Name")%></a></h1>
                        <asp:Repeater ID="rpListProduct" runat="server" onitemcommand="rpListProduct_ItemCommand">
                                <ItemTemplate>
                                    <div style="width:228px; margin: 5px 5px 5px 5px; padding: 5px 5px 5px 5px; border: 3px outset seagreen; float: left;">
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
                        </asp:Repeater>
                    <asp:HiddenField ID="hrID" runat="server" Value='<%#Eval("Products_ID")%>' /> <!-- cai nay de luu ID cua danh muc cap cha  -->
                    </div><div class="clear" style="height:30px;"></div>
                </ItemTemplate>
                <FooterTemplate></FooterTemplate>
             </asp:Repeater>
    </div><!-- End #primary -->
</asp:Content>