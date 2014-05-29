<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GalleryUC.ascx.cs" Inherits="CongKy.UserControl.GalleryUC" %>
<asp:Repeater ID="rptGallery" runat="server">
<ItemTemplate>
                    <!-- team start -->
    <div  class="content homepage" id="menu-1">
     <div class="templatemo_ourteam">
     		<div class="container templatemo_hexteam" style="width: 1024px;">
            	<div class="row">
                	<div class="col-sm-4">
                        	 <div class="hexagon hexagonteam gallery-item">
                               <div class="hexagon-in1">
                                <div class="hexagon-in2" style="background-image: url(../App_Themes/images/team/1.jpg);">
                                <div class="overlay templatemo_overlay1">
                                	<a href="#">
                                   	 <div class="smallhexagon">
                                  	 	 <span class="fa fa-facebook"></span>
                                 	  </div>
                                    </a>
                                </div>
                                <div class="overlay templatemo_overlay2">
                                	<a href="#">
                                   	 <div class="smallhexagon">
                                  	 	 <span class="fa fa-twitter"></span>
                                 	  </div>
                                    </a>
                                </div>
                                <div class="overlay templatemo_overlay3">
                                	<a href="#">
                                   	 <div class="smallhexagon">
                                  	 	 <span class="fa fa-linkedin"></span>
                                 	  </div>
                                    </a>
                                </div>
                                <div class="overlay templatemo_overlay4">
                                	<a href="#">
                                   	 <div class="smallhexagon">
                                  	 	 <span class="fa fa-rss"></span>
                                 	  </div>
                                    </a>
                                </div>
                                <div class="clear"></div>
                               	<div class="overlay templatemo_overlaytxt">Phasellus interdum</div>
                                </div>
                            </div>
                          </div>
  			       </div>
                    <div class="col-sm-8 templatemo_servicetxt" style="width:65%" >
                    	<h2>Free Template</h2>
                        <p>Polygon is <a href="http://www.templatemo.com/page/1">free HTML5 template</a> by templatemo that can be used for any purpose. Cras lobortis, ligula ut hendrerit condimentum, magna lorem lobortis nisi, ac suscipit nunc est vitae turpis. Nullam vulputate nec nulla sed fringilla. Aliquam tempus consectetur diam, in suscipit turpis pulvinar at.</p>
                    </div>
               </div>
            </div>
             <br /><br /><br /><br /><br /><br /><br /><br /><div class="clear"></div>
     </div>
     </div>
    <!--team end-->
</ItemTemplate>
</asp:Repeater>
