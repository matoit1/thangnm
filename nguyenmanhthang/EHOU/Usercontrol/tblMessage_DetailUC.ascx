<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblMessage_DetailUC.ascx.cs" Inherits="EHOU.UserControl.tblMessage_DetailUC" %>
<link href="../App_Themes/calendar.css" rel="stylesheet" type="text/css"/>  
<script src="../Scripts/calendar1.js" type="text/javascript"></script>  
<script src="../Scripts/calendar2.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $(".startdate").datepicker({ dateFormat: "mm/dd/yy" }).val()
        $(".enddate").datepicker({ dateFormat: "mm/dd/yy" }).val()
    });
</script>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Tin nhắn" CssClass="form_tittle"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã tin nhắn: </td>
            <td><asp:TextBox ID="txtPK_lMessage" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_lMessage" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Phòng chat: </td>
            <td><asp:DropDownList ID="ddlFK_sRoom" runat="server" Width="405px" TabIndex="1"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sRoom" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Người gửi: </td>
            <td><asp:DropDownList ID="ddlFK_sUsername" runat="server" Width="405px" TabIndex="2"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sUsername" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nội dung: </td>
            <td><asp:TextBox ID="txtsContent" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="4"></asp:TextBox></td>
            <td><asp:Label ID="lblsContent" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày gửi: </td>
            <td><asp:TextBox ID="txttDateSent" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lbltDateSent" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliStatus" runat="server" Width="405px" TabIndex="11"></asp:DropDownList></td>
            <td><asp:Label ID="lbliStatus" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" 
                    onclick="btnInsert_Click" TabIndex="12" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="13" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="14" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="15" />
            </td>
            <td></td>
        </tr>
    </table>
</div>