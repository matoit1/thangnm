<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChatUC.ascx.cs" Inherits="DO_AN_TN.UserControl.ChatUC" %>
<link href="http://localhost:1766/App_Themes/New/ChatRoom.css" type="text/css" rel="stylesheet" />
<style type="text/css">
    .divhide{display:none;}
    .divshow:hover .divhide{display:inline}
</style>

<div class="chat" style="display: block; bottom: 0px;" id="chat-box">
	<div style="width: 350px; height: 500px; ">
        <asp:ScriptManager ID="ScriptManager1" runat="server"  EnablePartialRendering="True" EnablePageMethods="True"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Timer ID="tAutoUpdateMessage" runat="server" ontick="tAutoUpdateMessage_Tick"></asp:Timer>
                <fieldset class="style1">
                <legend>Chatroom</legend>
                <asp:Repeater ID="rptDialog" runat="server" onitemcommand="rptDialog_ItemCommand">
                <HeaderTemplate>
                <div style="width:300px; padding: 5px; border :3px double black; height: 400px; overflow:auto;">
                </HeaderTemplate>
                    <ItemTemplate>
                        <asp:HiddenField ID="hfdPK_lTinNhan" runat="server" Value='<%#Eval("PK_lTinNhan")%>' />
                        <span style="color: <%# GetRowColor(Container.ItemIndex) %>">
                            <asp:Label ID="lblFK_sNguoiGui" runat="server" Text='<%#Eval("FK_sNguoiGui")%>'></asp:Label>
                        </span>
                        <span style="font-size:10px">
                            (<asp:Label ID="lbltNgayGui" runat="server" Text='<%#Eval("tNgayGui")%>'></asp:Label>)
                        </span>: 
                        <asp:Label ID="lblsNoidung" runat="server" Text='<%#Eval("sNoidung")%>'></asp:Label>
                        <div class="divshow">
                            <asp:ImageButton ID="ibntTool" CommandName="ibntTool" runat="server" Width="15px" ImageUrl="~/Images/Icon/info.gif" AlternateText="Tiện ích" ToolTip="Tiện ích !" />
                            <div class="divhide">
                                <asp:ImageButton ID="ibntDeleteMessage" CommandName="ibntDeleteMessage" runat="server" Width="15px" ImageUrl="~/Images/Icon/trash.gif" AlternateText="Xóa tin nhắn này !" ToolTip="Xóa tin nhắn này !" />
                                <asp:ImageButton ID="ibntHideAcc" CommandName="ibntHideAcc" runat="server" Width="15px" ImageUrl="~/Images/Icon/ico_on.gif" AlternateText="Chặn người dùng này !" ToolTip="Chặn người dùng này !" />
                                <asp:ImageButton ID="ibntShowAcc" CommandName="ibntShowAcc" runat="server" Width="15px" ImageUrl="~/Images/Icon/form_responses.gif" AlternateText="Mở chặn người dùng này !" ToolTip="Mở chặn người dùng này !" />
                            </div>
                        </div><br />
                    </ItemTemplate>
                    <FooterTemplate></div>
                    </FooterTemplate>
                </asp:Repeater>
                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnSent">
                    <div style="padding:5px">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        <asp:TextBox id="txtsNoidung" Width="280" Runat="server"></asp:TextBox>
                        <asp:Button ID="btnSent" runat="server" Text="Gửi" class="btn" onclick="btnSent_Click"/>
                    </div>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>
<div class="chat-box" onclick="clickx()" style="bottom: 500px;" id="taskx">
<center> ChatRoom - Trung tâm đào tạo E-Learning<span style="float: right;">X</span></center>
	        <div class="notification" style="display:none" id="notif">
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
	        
                <asp:Label ID="lblSumOnline" runat="server"></asp:Label>
            
        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
	        <div style="display: block;" title="Close" class="closechatroom" id="closechatroom"></div>
</div>


