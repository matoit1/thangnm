﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChatUC.ascx.cs" Inherits="EHOU.UserControl.ChatUC" %>

<style type="text/css">
    .divmain{height: 478px;}
    .divhide{display:none;}
    .divshow:hover .divhide{display:inline}
    
</style>
<%--.divsmiley{position: absolute; top: 343px; left: 68px; width: 232px; height: 185px; display:none;}
    .divshowsmiley{position: absolute; top: 343px; left: 68px; width: 232px; height: 185px; display:block; z-index: 100; }
    .divshowsmiley:hover .divsmiley{display:block;}--%>
<div class="chat" style="display: block; bottom: 0px;" id="chat-box">
	<div style="width: 350px; height: 500px; ">
    <fieldset class="divmain">
        <legend>Chatroom</legend>
        <%--<asp:ScriptManager ID="ScriptManager1" runat="server"  EnablePartialRendering="True" EnablePageMethods="True"></asp:ScriptManager>--%>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="udpnlChatRoom">
            <ProgressTemplate>
            <img src="https://ssl.gstatic.com/s2/oz/images/notifications/spinner_32_041dcfce66a2d43215abb96b38313ba0.gif" width="18px" height="18px" />
            </ProgressTemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel ID="udpnlChatRoom" runat="server" UpdateMode="Conditional" >
            <ContentTemplate>
                <asp:Timer ID="tAutoUpdateMessage" runat="server" ontick="tAutoUpdateMessage_Tick"></asp:Timer>
                <asp:Repeater ID="rptDialog" runat="server" onitemcommand="rptDialog_ItemCommand" onitemdatabound="rptDialog_ItemDataBound">
                    <HeaderTemplate>
                        <div style="width:300px; padding: 5px; border :3px double black; height: 390px; overflow:auto;">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:HiddenField ID="hfdPK_lMessage" runat="server" Value='<%#Eval("PK_lMessage")%>' />
                       <%-- <span style="color: <%=sColor%>">--%>
                        <asp:HiddenField ID="hfFK_sUsername" runat="server" Value='<%#Eval("FK_sUsername")%>' />
                            <asp:Label ID="lblFK_sUsername" runat="server" Text='<%#Eval("FK_sUsername")%>' Font-Bold="true"></asp:Label>
                        <%--</span>--%>
                        <span style="font-size:10px">
                            (<asp:Label ID="lbltDateSent" runat="server" Text='<%#Eval("tDateSent")%>'></asp:Label>)
                        </span>: 
                        <asp:Label ID="lblsContent" runat="server" Text='<%#Eval("sContent")%>'></asp:Label>
                        <div class="divshow">
                            <asp:ImageButton ID="ibntTool" CommandName="ibntTool" runat="server" Width="15px" ImageUrl="~/Images/Icon/info.gif" AlternateText="Tiện ích" ToolTip="Tiện ích !" />
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <div class="divhide">
                                <asp:ImageButton ID="ibntDeleteMessage" CommandName="ibntDeleteMessage" runat="server" Width="15px" ImageUrl="~/Images/Icon/trash.gif" AlternateText="Xóa tin nhắn này !" ToolTip="Xóa tin nhắn này !" />
                                <asp:ImageButton ID="ibntHideAcc" CommandName="ibntHideAcc" runat="server" Width="15px" ImageUrl="~/Images/Icon/ico_on.gif" AlternateText="Chặn người dùng này !" ToolTip="Chặn người dùng này !" />
                                <asp:ImageButton ID="ibntShowAcc" CommandName="ibntShowAcc" runat="server" Width="15px" ImageUrl="~/Images/Icon/form_responses.gif" AlternateText="Mở chặn người dùng này !" ToolTip="Mở chặn người dùng này !" />
                            </div>
                        </div><br />
                    </ItemTemplate>
                    <FooterTemplate>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
            </ContentTemplate>
<%--            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="tAutoUpdateMessage" EventName="Tick" />
            </Triggers>--%>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="udpnlFormChat" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnSent">
                    <div style="padding-top:8px">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        <asp:TextBox id="txtsContent" Width="205" Height="22px" Runat="server" Font-Size="16px"></asp:TextBox>
                        <asp:DropDownList ID="ddlSmiley" runat="server" Visible="false" Width="40" Height="29px" ontextchanged="ddlSmiley_TextChanged" AutoPostBack="true"></asp:DropDownList>
                        <asp:TextBox ID="txtColor" runat="server" type="color" ontextchanged="txtColor_TextChanged" AutoPostBack="true" Width="18px" Height="22px"></asp:TextBox>
                        <asp:ImageButton ID="ibtnSmileys" runat="server" ImageUrl="~/Images/Smileys/Icon_2.gif" onclick="ibtnSmileys_Click" Width="18px" />
                        <asp:Button ID="btnSent" runat="server" Width="50px" Height="27px" Text="Gửi" class="btn" onclick="btnSent_Click"/>
                    </div>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        </fieldset>
    </div>
</div>
<div class="chat-box" onclick="clickx()" style="bottom: 500px;" id="taskx">
    <center>Trung tâm đào tạo E-Learning<span style="float: right;"><img src="../../Images/Icon/closebox.png" width="21px" /></span></center>
	<div class="notification" style="display:none" id="notif">
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblSumOnline" runat="server"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
	<div style="display: block;" title="Close" class="closechatroom" id="closechatroom"></div>
</div>