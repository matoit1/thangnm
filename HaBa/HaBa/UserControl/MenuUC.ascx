<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuUC.ascx.cs" Inherits="HaBa.UserControl.MenuUC" %>
<div id="header-wrapper">
	<div class="header section" id="header">
		<div class="widget Header" id="Header1">
			<div id="header-inner">
				<div class="titlewrapper">
					<h2 style="font-family:'Mr Dafoe', cursive; text-transform:none;"><a href="../Default.aspx">HaBa</a></h2>
				</div>
				<div class="descriptionwrapper">
					<p class="description"><span></span></p>
				</div>
			</div>
		</div>
	</div>
	<!-- MENU [start] -->
    <div class="menu-secondary-container">
	    <ul class="menus menu-secondary">
		    <asp:Repeater ID="rptRoot" runat="server" OnItemDataBound="rptRoot_ItemDataBound">
                <ItemTemplate>
                    <li><asp:HyperLink ID="hplPK_iNhomSanPhamID" runat="server" NavigateUrl='<%#"~/NhomSanPham.aspx?PK_iNhomSanPhamID="+Eval("PK_iNhomSanPhamID")%>'><%#Eval("sTenNhom")%></asp:HyperLink>
                        <asp:Repeater ID="rptiNhomCon" runat="server">
                            <HeaderTemplate><ul></HeaderTemplate>
                            <ItemTemplate>
                                <li><asp:HyperLink ID="hpliNhomCon" runat="server" NavigateUrl='<%#"~/NhomSanPham.aspx?PK_iNhomSanPhamID="+Eval("iNhomCon")%>'><%#Eval("sTenNhom")%></asp:HyperLink></li>
                            </ItemTemplate>
                            <FooterTemplate></ul></FooterTemplate>
                        </asp:Repeater>
                    </li>
                    <asp:HiddenField ID="hrfPK_iNhomSanPhamID" runat="server" Value='<%#Eval("PK_iNhomSanPhamID")%>' />
                </ItemTemplate>
            </asp:Repeater>
<%--
		    <li><a href="../GroupProduct.aspx?lGroup=1">Áo</a>
			    <ul class="children">
				    <li><a href="../GroupProduct.aspx?lGroup=2">Áo sơ mi</a></li>
			    </ul>
		    </li>
		    <li><a href="../GroupProduct.aspx?lGroup=2">Váy</a>
			    <ul class="children">
				    <li><a href="../GroupProduct.aspx?lGroup=4">Váy công sở</a></li>
				    <li><a href="../GroupProduct.aspx?lGroup=5">Váy dạo phố</a></li>
				    <li><a href="../GroupProduct.aspx?lGroup=6">Chân váy</a></li>
				    <li><a href="../GroupProduct.aspx?lGroup=7">Váy khác</a></li>
			    </ul>
		    </li>
		    <li><a href="../GroupProduct.aspx?lGroup=8">Phong cách +</a></li>--%>
	    </ul>
    </div>
    <!-- MENU [end] -->
	<!-- Search [start] -->
		<div id="search">
			<div class="search-input form-search">
                <asp:TextBox ID="txtKeyWord" CssClass="keyword" runat="server" placeholder="Tìm kiếm sản phẩm?" ></asp:TextBox>
                <asp:Button ID="btnSearch" CssClass="btnSearch" runat="server" Text="Button" style="vertical-align: top;" onclick="btnSearch_Click" />
			</div>
		</div>
	<!-- Search [end] -->
</div>