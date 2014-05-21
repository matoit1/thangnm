<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProducGroupUC.ascx.cs" Inherits="HaBa.UserControl.ProducGroupUC" %>
<div id="featuredhome-wrap">
	<div class="featurehomer section" id="featurehomer">
		<div class="widget HTML" id="HTML2">
			<h2 class="title">Featured Post (TOP)</h2>
			<div class="widget-content">
            <%--<marquee behavior="scroll" onmouseout="this.start()" onmouseover="this.stop()" truespeed="" scrollamount="1" scrolldelay="30" direction="up">--%>
            <ul class="label_with_thumbs">
                <asp:Repeater ID="rptLoadProductGroup" runat="server" >
                    <ItemTemplate>
                        <li class="clearfix">
					        <a class="picturelabela" target="_top" href='<%#"../NhomSanPham.aspx?PK_iNhomSanPhamID=" + Eval("PK_iNhomSanPhamID")%>'>
                            <img class="label_thumb" src='<%#"../Images/Product/"+ Eval("PK_iNhomSanPhamID")+".jpg"%>' alt='<%#Eval("sTenNhom")%>' title='<%#Eval("sTenNhom")%>' /></a>
					        <strong><h2><a class="titlelabel" target="_top" href='<%#"../NhomSanPham.aspx?PK_iNhomSanPhamID=" + Eval("PK_iNhomSanPhamID")%>'><%#Eval("sTenNhom")%></a></h2></strong>
					        <%--<div class="contento">
						        Áo sơ mi công sở 2014. Áo đẹp thời trang! ...<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />
						        <a class="url" target="_top" href="../Default.aspx">Chi Tiết »</a>
					        </div>--%>
				        </li>
                    </ItemTemplate>
               </asp:Repeater>
			</ul>
            <%--</marquee>--%>
			</div>
			<div class="clear"></div>
		</div>
	</div>
</div>


