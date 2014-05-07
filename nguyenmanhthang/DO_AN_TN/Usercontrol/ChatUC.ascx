<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChatUC.ascx.cs" Inherits="DO_AN_TN.UserControl.ChatUC" %>
<div>
    <link href="http://localhost:1766/App_Themes/New/ChatRoom.css" type="text/css" rel="stylesheet" />
   
    <asp:ScriptManager ID="ScriptManager1" runat="server"  EnablePartialRendering="True" EnablePageMethods="True">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/chatroom.js" />
        </Scripts>
    </asp:ScriptManager>
    <table cellpadding="0" cellspacing="0">
        <tr>
            <td width="80%">
                <asp:textbox runat="server" TextMode="MultiLine" id="txt" style="WIDTH: 690px; HEIGHT: 260px" rows="16" Columns="79" ></asp:textbox>&nbsp;
                <br />
                <asp:TextBox id="txtMsg" Width="400" Runat="server"></asp:TextBox>&nbsp;&nbsp; <input id="btn" onclick="button_clicked()" type="button" value="SEND" class="btn"/>
            </td>
            <td width="20%" rowspan="2" valign="top">
                Room Members <br />&nbsp;
                <asp:ListBox runat="server" Width="100" ID="lstMembers" Enabled="false" Height="249px"></asp:ListBox>
            </td>
        </tr>
    </table>
</div>