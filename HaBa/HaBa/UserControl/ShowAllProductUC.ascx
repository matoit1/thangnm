<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShowAllProductUC.ascx.cs" Inherits="HaBa.UserControl.ShowAllProductUC" %>
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
								        <a href='<%#"../SanPham.aspx?PK_sSanPhamID="+Eval("PK_sSanPhamID")%>'>
                                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("sLinkImage")%>' class="postthumb" ToolTip='<%#Eval("sTenSanPham")%>' AlternateText='<%#Eval("sTenSanPham")%>' />
                                            <%--<img src='<%#Eval("sLinkImage")%>' class="postthumb" alt='<%#Eval("sTenSanPham")%>' title='<%#Eval("sTenSanPham")%>'>--%>
                                        </a>
							        </div>
							        <h2 class="post-title entry-title">
								        <a href='<%#"../SanPham.aspx?PK_sSanPhamID="+Eval("PK_sSanPhamID")%>'><span class="border"><%#Eval("sTenSanPham")%></span></a>
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
			</div>
		</div>
		<!-- google_ad_section_end -->
	</div>
	<div class="blog-pager" id="blog-pager">
		<div class="showpageArea">
			<span style="color: rgb(0, 0, 0);" class="showpageOf"> Pages (2)</span>
			<span class="showpagePoint">1</span>
			<span class="showpageNum"><a href="http://HaBa.tk//search?updated-max=2013-11-26T00%3A15%3A00-08%3A00&amp;max-results=6">2</a></span>
			<span class="showpage"><a href="http://HaBa.tk//search?updated-max=2013-11-26T00%3A15%3A00-08%3A00&amp;max-results=6">Next</a></span>
		</div>
	</div>
	<div class="clear"></div>
</div>