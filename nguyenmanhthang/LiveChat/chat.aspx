<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chat.aspx.cs" Inherits="LiveChat.chat"  MasterPageFile="~/Popup.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="styles/chat.css" />
    <script src="scripts/chat.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            chatSetup();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <input type="hidden" id="LastUpdateId" value="0" />
    <div style="display:none;" id="divContent" runat="server" >
        <input id="ConversationId" value="0" />
    </div>
    
    <div id="result">
    </div>
    <div id="messageMommy">
        <textarea id="message"></textarea>
    </div>
    <div id="sendMommy">
        <input type="button" id="send" value="send" />
    </div>
    <div id="info">
        Client Name:
        <asp:Label ID="lblName" runat="server" />
        Conversation Title:
        <asp:Label ID="lblTitle" runat="server" />
    </div>
</asp:Content>

