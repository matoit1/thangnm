<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblChiTietGiaoTrinh_DetailUC.ascx.cs" Inherits="CongKy.UserControl.tblChiTietGiaoTrinh_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Chi tiết giáo trình" CssClass="form_tittle"></asp:Label></td>
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
            <td><asp:Label ID="lblPK_iGiaoTrinhID_Title" runat="server" Text="Mã giáo trình: "></asp:Label></td>
            <td><asp:TextBox ID="txtPK_iGiaoTrinhID" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iGiaoTrinhID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Môn học: </td>
            <td><asp:DropDownList ID="ddlFK_iMonHocID" runat="server" Width="405px" TabIndex="6" Enabled="false"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iMonHocID" runat="server" Enabled="false"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên bài học: </td>
            <td><asp:TextBox ID="txtsTenBaiHoc" runat="server" Width="400px" MaxLength="200" 
                    TabIndex="1"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenBaiHoc" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td>Thông tin: </td>
            <td><asp:TextBox ID="txtsThongTin" runat="server" Width="400px" 
                    TabIndex="2"></asp:TextBox></td>
            <td><asp:Label ID="lblsThongTin" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td>Link download: </td>
            <td>
                <asp:FileUpload ID="fuFile" runat="server" /></td>
            <%--<asp:TextBox ID="txtsLinkDownload" runat="server" Width="400px" MaxLength="200" 
                    TabIndex="3"></asp:TextBox>--%>
            <td><asp:Label ID="lblsLinkDownload" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td><asp:Label ID="lbliType_Title" runat="server" Text="Loại: "></asp:Label></td>
            <td><asp:DropDownList ID="ddliType" runat="server" Width="405px" TabIndex="4"></asp:DropDownList></td>
            <td><asp:Label ID="lbliType" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lbltNgayCapNhat_Title" runat="server" Text="Ngày cập nhật: "></asp:Label></td>
            <td><asp:TextBox ID="txttNgayCapNhat" runat="server" Width="400px" class="startdate" Enabled="false" TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapNhat" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lbliTrangThai_Title" runat="server" Text="Trạng thái: "></asp:Label></td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px" TabIndex="6"></asp:DropDownList></td>
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
                    onclick="btnInsert_Click" TabIndex="7" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="8" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="9" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="10" />
            </td>
            <td></td>
        </tr>
    </table>
</div>