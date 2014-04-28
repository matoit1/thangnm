<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuUC.ascx.cs" Inherits="tydyShop.UserControl.MenuUC" %>
<div id="header-wrapper">
	<div class="header section" id="header">
		<div class="widget Header" id="Header1">
			<div id="header-inner">
				<div class="titlewrapper">
					<h2 class="title"><a href="../New/Default.aspx">tydyShop</a></h2>
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
		    <li class="curent"><a href="../Default.aspx">Home</a></li>
		    <li><a href="../New/GroupProduct.aspx?Products_Group=1">Áo</a>
			    <ul class="children">
				    <li><a href="../New/GroupProduct.aspx?Products_Group=2">Áo sơ mi</a></li>
			    </ul>
		    </li>
		    <li><a href="../New/GroupProduct.aspx?Products_Group=2">Váy</a>
			    <ul class="children">
				    <li><a href="../New/GroupProduct.aspx?Products_Group=4">Váy công sở</a></li>
				    <li><a href="../New/GroupProduct.aspx?Products_Group=5">Váy dạo phố</a></li>
				    <li><a href="../New/GroupProduct.aspx?Products_Group=6">Chân váy</a></li>
				    <li><a href="../New/GroupProduct.aspx?Products_Group=7">Váy khác</a></li>
			    </ul>
		    </li>
		    <li><a href="../New/GroupProduct.aspx?Products_Group=8">Phong cách +</a></li>
	    </ul>
    </div>
    <!-- MENU [end] -->
	<!-- Search [start] -->
	<form _lpchecked="1" action="http://tydyShop.tk/search" class="search-form" id="search_mini_form" method="get">
		<div id="search">
			<div class="search-input form-search">
				<input id="s" name="q" onblur="if (this.value == '') {this.value = 'Search the site';}" onfocus="if (this.value == 'Search the site') {this.value = '';}" value="Search the site" type="text">
				<input id="buttonsinput" style="vertical-align: top;" value="Search!" type="submit">
			</div>
		</div>
	</form>
	<!-- Search [end] -->
</div>