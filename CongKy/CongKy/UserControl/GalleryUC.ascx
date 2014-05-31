<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GalleryUC.ascx.cs" Inherits="CongKy.UserControl.GalleryUC" %>
<asp:Repeater ID="rptGallery" runat="server" 
    onitemdatabound="rptGallery_ItemDataBound">
<ItemTemplate>
                    <!-- team start -->
    <div  class="content homepage" id="menu-1" style="height: 250px">
     <div class="templatemo_ourteam">
     		<div class="container templatemo_hexteam" style="width: 1024px;">
            	<div class="row">
                	<div class="col-sm-4">
                        	 <div class="hexagon hexagonteam gallery-item">
                               <div class="hexagon-in1">
                                <div class="hexagon-in2" style="background-image: url('<%# Eval("sLinkImage")%>');">
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
                               	<div class="overlay templatemo_overlaytxt"><%# Eval("sTenMonHoc")%></div>
                                </div>
                            </div>
                          </div>
  			       </div>
                    <div class="col-sm-8 templatemo_servicetxt" style="width:65%" >
                    	<h2><a href="../../SinhVien/MonHoc.aspx?iTrangThai=4"><%# Eval("sTenMonHoc")%></a></h2>
                        <asp:Label ID="lblContent" runat="server" Text='<%# Eval("PK_iMonHocID")%>'></asp:Label>
                    </div>
               </div>
            </div>
             
             <div class="clear"></div>
     </div>
     </div>
    <!--team end-->
</ItemTemplate>
</asp:Repeater>
