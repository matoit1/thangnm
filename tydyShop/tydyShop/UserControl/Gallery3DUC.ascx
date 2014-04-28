﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Gallery3DUC.ascx.cs" Inherits="tydyShop.UserControl.Gallery3DUC" %>
<link rel="stylesheet" type="text/css" href="../App_Themes/Gallery3D_1.css" />
<link rel="stylesheet" type="text/css" href="../App_Themes/Gallery3D_2.css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script type="text/javascript" src="../Scripts/Gallery3D_1.js"></script>
<script type="text/javascript" src="../Scripts/Gallery3D_2.js"></script>
<script type="text/javascript">
	$(function() {
		$('#dg-container').gallery();
	});
</script>
<div class="container">
	<section id="dg-container" class="dg-container">
		<div class="dg-wrapper">
            <asp:Repeater ID="rptAdv" runat="server">
                <ItemTemplate>
                    <a href='<%#"../New/Product.aspx?Products_ID="+Eval("Products_ID")%>'><img src='<%#Eval("Products_Image1")%>' alt='<%#Eval("Products_Name")%>' width="260px" height="260px"><div><%#Eval("Products_Name")%></div></a>
                </ItemTemplate>
            </asp:Repeater>
		</div>
		<nav>	
			<span class="dg-prev">&lt;</span>
			<span class="dg-next">&gt;</span>
		</nav>
	</section>
</div>