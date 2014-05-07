<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="DO_AN_TN.Test.ChatRoomUC.Demo" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
  <link href="../../App_Themes/Chat.css" rel="stylesheet" type="text/css"/>
  <script type="text/javascript" src="../../Scripts/chat.js"></script>
    <div class="chat" 
        style="display: block; bottom: 0px; text-decoration: underline;" id="chat-box">
        
		<uc1:ChatUC ID="ChatUC1" runat="server" />
	</div>
	<div class="chat-box" onclick="clickx()" style="bottom: 500px;" id="taskx">
		<center> ChatRoom - Trung tâm đào tạo E-Learning<span style="float: right;">X</span></center>
		<div class="notification" style="display:none" id="notif"> 2</div>
		<div style="display: block;" title="Close" class="closechatroom" id="closechatroom"></div>
	</div>
    
</asp:Content>
