﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat_Room.aspx.cs" Inherits="nguyenmanhthang.UngDung.Chat_Room" MasterPageFile="~/Common/Default.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
<div style="padding: 20px">
    <script id="sid0010000022441419647">        (function () { function async_load() { s.id = "cid0010000022441419647"; s.src = 'http://st.chatango.com/js/gz/emb.js'; s.style.cssText = "width:600px;height:500px;"; s.async = true; s.text = '{"handle":"thangnm","styles":{"b":60,"f":50,"l":"999999","p":"14","q":"999999","r":100,"s":1}}'; var ss = document.getElementsByTagName('script'); for (var i = 0, l = ss.length; i < l; i++) { if (ss[i].id == 'sid0010000022441419647') { ss[i].id += '_'; ss[i].parentNode.insertBefore(s, ss[i]); break; } } } var s = document.createElement('script'); if (s.async == undefined) { if (window.addEventListener) { addEventListener('load', async_load, false); } else if (window.attachEvent) { attachEvent('onload', async_load); } } else { async_load(); } })();</script>
</div>
</asp:Content>