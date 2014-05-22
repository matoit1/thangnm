﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblNhomSanPham_DetailUC.ascx.cs" Inherits="HaBa.UserControl.tblNhomSanPham_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin nhóm sản phẩm" CssClass="form_tittle"></asp:Label></td>
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
            <td>Mã nhóm sản phẩm: </td>
            <td><asp:TextBox ID="txtPK_iNhomSanPhamID" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iNhomSanPhamID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nhóm con: </td>
            <td><asp:DropDownList ID="ddliNhomCon" runat="server" Width="405px" TabIndex="1"></asp:DropDownList></td>
            <td><asp:Label ID="lbliNhomCon" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên nhóm: </td>
            <td><asp:TextBox ID="txtsTenNhom" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="2"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenNhom" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
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
                <asp:Button ID="btnInsert" runat="server" Text="Insert" 
                    onclick="btnInsert_Click" TabIndex="4" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="5" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="6" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="7" />
            </td>
            <td></td>
        </tr>
    </table>
</div>