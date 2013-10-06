<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="ThangNMjsc.Info.Address"  MasterPageFile="~/MasterPage/PublicProduct.Master"%>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Product" runat="server">
    <title>Bản đồ đường đi - Công ty Cổ phần ThangNM</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div style="width:700px; height:500px; margin: 15px 15px 15px 15px;">
        <iframe width="700" height="500px" frameborder="0" scrolling="yes" marginheight="0" marginwidth="0" src="https://maps.google.com/maps/ms?msa=0&amp;msid=211632425546060642516.0004d91111be2094ce033&amp;ie=UTF8&amp;t=m&amp;ll=20.985904,105.839217&amp;spn=0.003005,0.007735&amp;z=17&amp;iwloc=0004d91139afc333d9b4f&amp;output=embed"></iframe><br />
        <small>Xem <a href="https://maps.google.com/maps/ms?msa=0&amp;msid=211632425546060642516.0004d91111be2094ce033&amp;ie=UTF8&amp;t=m&amp;ll=20.985904,105.839217&amp;spn=0.003005,0.007735&amp;z=17&amp;iwloc=0004d91139afc333d9b4f&amp;source=embed" target="_blank" style="color:#0000FF;text-align:left">Công ty Cổ phần ThangNM</a> ở bản đồ lớn hơn</small>
    </div>
</asp:Content>

