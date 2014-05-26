<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblGiaoTrinh_DetailUC.ascx.cs" Inherits="CongKy.UserControl.tblGiaoTrinh_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin giáo trình" CssClass="form_tittle"></asp:Label></td>
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
            <td>Mã môn học: </td>
            <td><asp:DropDownList ID="ddlFK_iMonHocID" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iMonHocID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã giáo trình: </td>
            <td><asp:DropDownList ID="ddlFK_iGiaoTrinhID" runat="server" Width="405px" 
                    TabIndex="1"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iGiaoTrinhID" runat="server"></asp:Label></td>
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
                    onclick="btnInsert_Click" TabIndex="2" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="3" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="4" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="5" />
            </td>
            <td></td>
        </tr>
    </table>
</div>