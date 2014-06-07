<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblMaterial_DetailUC.ascx.cs" Inherits="EHOU.Usercontrol.tblMaterial_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Học liệu" CssClass="form_tittle"></asp:Label></td>
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
            <td>Mã học liệu: </td>
            <td><asp:TextBox ID="txtPK_lMaterial" runat="server" Width="400px" Enabled="false" TabIndex="1"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_lMaterial" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Môn học: </td>
            <td><asp:DropDownList ID="ddlFK_sSubject" runat="server" Width="405px" TabIndex="2"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sSubject" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Người đăng: </td>
            <td><asp:DropDownList ID="ddlFK_sUsername" runat="server" Width="405px" TabIndex="3"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sUsername" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mô tả: </td>
            <td><asp:TextBox ID="txtsDescription" runat="server" Width="400px" TabIndex="4"></asp:TextBox></td>
            <td><asp:Label ID="lblsDescription" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link Download: </td>
            <td><asp:TextBox ID="txtsLinkDownload" runat="server" Width="400px" TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkDownload" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cập nhật: </td>
            <td><asp:TextBox ID="txttLastUpdate" runat="server" Width="400px" MaxLength="50" TabIndex="6"></asp:TextBox></td>
            <td><asp:Label ID="lbltLastUpdate" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Kích thước file: </td>
            <td><asp:TextBox ID="txtiSize" runat="server" Width="400px" TabIndex="7"></asp:TextBox></td>
            <td><asp:Label ID="lbliSize" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Loại File: </td>
            <td><asp:TextBox ID="txtiType" runat="server" Width="400px" TabIndex="8"></asp:TextBox></td>
            <td><asp:Label ID="lbliType" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliStatus" runat="server" Width="405px" TabIndex="9"></asp:DropDownList></td>
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
                    onclick="btnInsert_Click" TabIndex="10" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="11" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="12" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="13" />
            </td>
            <td></td>
        </tr>
    </table>
</div>