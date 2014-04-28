<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShowAllProductUC.ascx.cs" Inherits="tydyShop.UserControl.ShowAllProductUC" %>
<asp:Repeater ID="Repeater1" runat="server">
</asp:Repeater>
<asp:Repeater ID="Repeater2" runat="server">
</asp:Repeater>
<div class="widget Blog" id="Blog1">
	<div class="blog-posts hfeed">
	<!-- google_ad_section_start(name=default) -->
		<div class="date-outer">
			<div class="date-posts">
                <asp:Repeater ID="rptLoadAllProduct" runat="server">
                    <ItemTemplate>
                        <div class="post-outer">
					        <div class="wrapfullpost">
						        <div class="post hentry">
							        <a name="5705322088157809118"></a>
							        <div class="entrybody">
								        <a href='<%#"../Product.aspx?Products_ID="+Eval("Products_ID")%>'>
                                            <img src='<%#Eval("Products_Image1")%>' class="postthumb" alt='<%#Eval("Products_Name")%>' title='<%#Eval("Products_Name")%>'>
                                        </a>
							        </div>
							        <h2 class="post-title entry-title">
								        <a href='<%#"../Product.aspx?Products_ID="+Eval("Products_ID")%>'><span class="border"><%#Eval("Products_Name")%></span></a>
							        </h2>
							        <div class="post-header-line-1"></div>
							        <div class="post-body entry-content"><div style="clear: both;"></div></div>
							        <div class="post-footer">
								        <div class="post-footer-line post-footer-line-"></div>
								        <div class="post-footer-line post-footer-line-2"></div>
								        <div class="post-footer-line post-footer-line-3"></div>
							        </div>
						        </div>
					        </div>
				        </div>
                    </ItemTemplate>
                </asp:Repeater>
				
				<%--<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="9033113351030726402"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk/2013/11/vay-ep-6.html"><img src="../Images/NewInterface/simg_0188_thumb.jpg" class="postthumb" alt="Váy Đẹp 6"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk/2013/11/vay-ep-6.html"><span class="border">Váy Đẹp 6</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="9166836869562558608"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/giay-ep-1_26.html"><img src="../Images/NewInterface/simg_9023_thumb.jpg" class="postthumb" alt="Giày Đẹp 1"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/giay-ep-1_26.html"><span class="border">Giày Đẹp 1</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="530138046961333209"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/vay-ep-5.html"><img src="../Images/NewInterface/simg_0172_thumb.jpg" class="postthumb" alt="Váy Đẹp 5"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/vay-ep-5.html"><span class="border">Váy Đẹp 5</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="8572251406469636378"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/giay-ep-4.html"><img src="../Images/NewInterface/simg_9085_thumb.jpg" class="postthumb" alt="Giày Đẹp 4"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/giay-ep-4.html"><span class="border">Giày Đẹp 4</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="4752288051253889259"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/vay-ep-3.html"><img src="../Images/NewInterface/img_3834_thumb.jpg" class="postthumb" alt="Váy Đẹp 3"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/vay-ep-3.html"><span class="border">Váy Đẹp 3</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="1106052274658721219"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/vay-ep-2.html"><img src="../Images/NewInterface/img_3707_thumb.jpg" class="postthumb" alt="Váy Đẹp 2"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/vay-ep-2.html"><span class="border">Váy Đẹp 2</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="8858110963512416028"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/vay-ep-1.html"><img src="../Images/NewInterface/img_3803_thumb.jpg" class="postthumb" alt="Váy Đẹp 1"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/vay-ep-1.html"><span class="border">Váy Đẹp 1</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3">
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="post-outer">
					<div class="wrapfullpost">
						<div class="post hentry">
							<a name="6796091944239114509"></a>
							<div class="entrybody">
								<a href="http://tydyShop.tk//2013/11/giay-ep-1.html"><img src="../Images/NewInterface/simg_9035_thumb.jpg" class="postthumb" alt="Giày Đep 1"></a>
							</div>
							<h2 class="post-title entry-title">
								<a href="http://tydyShop.tk//2013/11/giay-ep-1.html"><span class="border">Giày Đep 1</span></a>
							</h2>
							<div class="post-header-line-1"></div>
							<div class="post-body entry-content"><div style="clear: both;"></div></div>
							<div class="post-footer">
								<div class="post-footer-line post-footer-line-"></div>
								<div class="post-footer-line post-footer-line-2"></div>
								<div class="post-footer-line post-footer-line-3"></div>
							</div>
						</div>
					</div>
				</div>--%>
			</div>
		</div>
		<!-- google_ad_section_end -->
	</div>
	<div class="blog-pager" id="blog-pager">
		<div class="showpageArea">
			<span style="color: rgb(0, 0, 0);" class="showpageOf"> Pages (2)</span>
			<span class="showpagePoint">1</span>
			<span class="showpageNum"><a href="http://tydyShop.tk//search?updated-max=2013-11-26T00%3A15%3A00-08%3A00&amp;max-results=6">2</a></span>
			<span class="showpage"><a href="http://tydyShop.tk//search?updated-max=2013-11-26T00%3A15%3A00-08%3A00&amp;max-results=6">Next</a></span>
		</div>
	</div>
	<div class="clear"></div>
</div>