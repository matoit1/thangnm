<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="ASPNETChat.Chat" %>
<%@ Import Namespace="ASPNETChat" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chat Room</title>
    <link href="../App_Themes/New/ChatRoom.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <input id="hdnRoomID" type="hidden" name="hdnRoomID" runat="server"/>
        <asp:ScriptManager ID="ScriptManager1" runat="server"  EnablePartialRendering="True" EnablePageMethods="True">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/New/ChatRoom.js" />
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
                    Room Members <br />
                            &nbsp;
                            
                            <asp:ListBox runat="server" Width="100" ID="lstMembers" Enabled="false" Height="249px"></asp:ListBox>
                    
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
