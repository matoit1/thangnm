<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblMonHoc_DetailUC.ascx.cs" Inherits="CongKy.UserControl.tblMonHoc_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin môn học"  CssClass="form_tittle"></asp:Label></td>
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
            <td><asp:TextBox ID="txtPK_iMonHocID" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iMonHocID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên môn học: </td>
            <td><asp:TextBox ID="txtsTenMonHoc" runat="server" Width="400px" TabIndex="1" 
                    MaxLength="100"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenMonHoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link ảnh: </td>
            <td><asp:TextBox ID="txtsLinkImage" runat="server" Width="400px" TabIndex="2" 
                    MaxLength="200"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkImage" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lbliTrangThai_Title" runat="server" Text="Trạng thái: "></asp:Label></td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px" TabIndex="3"></asp:DropDownList></td>
            <td><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" TabIndex="4" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" TabIndex="5" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" TabIndex="6" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" TabIndex="7" />
                <asp:Button ID="btnSubscribe" runat="server" Text="Đăng ký" onclick="btnSubscribe_Click" TabIndex="8" Visible="False" />
                <asp:Button ID="btnUnsubscribe" runat="server" Text="Hủy đăng ký" onclick="btnUnsubscribe_Click" TabIndex="9" Visible="False" />
            </td>
            <td></td>
        </tr>
    </table>
</div>