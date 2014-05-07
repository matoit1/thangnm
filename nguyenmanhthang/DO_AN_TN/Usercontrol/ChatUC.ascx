<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChatUC.ascx.cs" Inherits="DO_AN_TN.UserControl.ChatUC" %>
<link href="http://localhost:1766/App_Themes/New/ChatRoom.css" type="text/css" rel="stylesheet" />
<div style="width: 350px; height: 500px">
    <asp:ScriptManager ID="ScriptManager1" runat="server"  EnablePartialRendering="True" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Timer ID="tAutoUpdateMessage" runat="server" ontick="tAutoUpdateMessage_Tick"></asp:Timer>
            <fieldset class="style1">
            <legend>Chatroom</legend>
             
            <asp:Repeater ID="rptDialog" runat="server">
            <HeaderTemplate>
            <div style="width:300px; padding: 5px; border :3px double black; height: 400px; overflow:auto;">
            </HeaderTemplate>
                <ItemTemplate>
                    <span style="color: <%# GetRowColor(Container.ItemIndex) %>">
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("FK_sNguoiGui")%>'></asp:Label></span>: 
                    <asp:Label ID="lblFK_sNguoiGui" runat="server" Text='<%#Eval("sNoidung")%>'></asp:Label><br />
                </ItemTemplate>
                <FooterTemplate></div>
                </FooterTemplate>
            </asp:Repeater>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <div style="padding:5px">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
            <asp:TextBox id="txtsNoidung" Width="280" Runat="server"></asp:TextBox>
            <asp:Button ID="btnSent" runat="server" Text="Gửi" class="btn" onclick="btnSent_Click"/>
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>