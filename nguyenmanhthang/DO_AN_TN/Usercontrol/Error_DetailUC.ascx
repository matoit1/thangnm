<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Error_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.Error_DetailUC" %>
<link href="../App_Themes/calendar.css" rel="stylesheet" type="text/css"/>  
<script src="../Scripts/calendar1.js" type="text/javascript"></script>  
<script src="../Scripts/calendar2.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
    });
</script>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Error"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã lỗi: </td>
            <td><asp:TextBox ID="txtPK_lErrorID" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_lErrorID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ lỗi: </td>
            <td><asp:TextBox ID="txtsLink" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsLink" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ IP: </td>
            <td><asp:TextBox ID="txtsIP" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsIP" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trình duyệt: </td>
            <td><asp:TextBox ID="txtsBrowser" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsBrowser" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã lỗi: </td>
            <td><asp:TextBox ID="txtiCodes" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliCodes" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày phát hiện: </td>
            <td><asp:TextBox ID="txttTime" runat="server" Width="400px" class="startdate" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbltTime" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày kiểm tra: </td>
            <td><asp:TextBox ID="txttTimeCheck" runat="server" Width="400px" class="startdate" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbltTimeCheck" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliStatus" runat="server" Width="405px"></asp:DropDownList></td>
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
                <asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>