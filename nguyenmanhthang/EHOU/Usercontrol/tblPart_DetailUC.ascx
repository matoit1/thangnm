<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblPart_DetailUC.ascx.cs" Inherits="EHOU.UserControl.tblPart_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Buổi học" CssClass="form_tittle"></asp:Label></td>
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
            <td>Mã buổi học: </td>
            <td><asp:TextBox ID="txtPK_iPart" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iPart" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Môn học: </td>
            <td><asp:DropDownList ID="ddlFK_sSubject" runat="server" Width="405px" 
                    TabIndex="1"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sSubject" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tiêu đề: </td>
            <td><asp:TextBox ID="txtsTitle" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="4"></asp:TextBox></td>
            <td><asp:Label ID="lblsTitle" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link Video: </td>
            <td><asp:TextBox ID="txtsLinkVideo" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkVideo" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Danh sách bị khóa: </td>
            <td><asp:TextBox ID="txtsBlackList" runat="server" Width="400px" MaxLength="500" 
                    TabIndex="6"></asp:TextBox></td>
            <td><asp:Label ID="lblsBlackList" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày giờ bắt đầu: </td>
            <td><asp:TextBox ID="txttDateTimeStart" runat="server" Width="400px" MaxLength="13" 
                    TabIndex="7"></asp:TextBox></td>
            <td><asp:Label ID="lbltDateTimeStart" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày giờ kết thúc: </td>
            <td><asp:TextBox ID="txttDateTimeEnd" runat="server" Width="400px" MaxLength="500" 
                    TabIndex="8"></asp:TextBox></td>
            <td><asp:Label ID="lbltDateTimeEnd" runat="server"></asp:Label></td>
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