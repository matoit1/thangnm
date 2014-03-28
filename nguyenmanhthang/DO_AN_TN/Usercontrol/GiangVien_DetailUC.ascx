<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiangVien_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.GiangVien_DetailUC" %>
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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Giảng viên"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã giảng viên: </td>
            <td><asp:TextBox ID="txtPK_sMaGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sMaGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ và tên: </td>
            <td><asp:TextBox ID="txtsHoTenGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsHoTenGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên đăng nhập: </td>
            <td><asp:TextBox ID="txtsTendangnhapGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsTendangnhapGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mật khẩu: </td>
            <td><asp:TextBox ID="txtsMatkhauGV" runat="server" Width="400px" TextMode="Password"></asp:TextBox></td>
            <td><asp:Label ID="lblsMatkhauGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtsEmailGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsEmailGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ liên hệ: </td>
            <td><asp:TextBox ID="txtsDiachiGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsDiachiGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số điện thoại: </td>
            <td><asp:TextBox ID="txtsSdtGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsSdtGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày sinh: </td>
            <td><asp:TextBox ID="txttNgaysinhGV" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgaysinhGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Giới tính: </td>
            <td><asp:DropDownList ID="ddlbGioitinhGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblbGioitinhGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số CMND: </td>
            <td><asp:TextBox ID="txtsCMNDGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCMNDGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cấp CMND: </td>
            <td><asp:TextBox ID="txttNgayCapCMNDGV" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapCMNDGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nơi cấp CMND: </td>
            <td><asp:TextBox ID="txtsNoiCapCMNDGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsNoiCapCMNDGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Hôn nhân: </td>
            <td><asp:DropDownList ID="ddlbHonNhanGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblbHonNhanGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày nhận công tác: </td>
            <td><asp:TextBox ID="txttNgayNhanCongTacGV" runat="server" Width="400px" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayNhanCongTacGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Chức vụ: </td>
            <td><asp:DropDownList ID="ddlbiChucVuGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lbliChucVuGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Học vị: </td>
            <td><asp:DropDownList ID="ddliHocViGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblsHocViGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Công chức: </td>
            <td><asp:DropDownList ID="ddlbCongChucGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblbCongChucGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link kênh dạy học: </td>
            <td><asp:TextBox ID="txtsLinkChannelsGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkChannelsGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link Chat Room: </td>
            <td><asp:TextBox ID="txtsLinkChatRoomsGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkChatRoomsGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link Avatar: </td>
            <td><asp:TextBox ID="txtsLinkAvatarGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkAvatarGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliTrangThaiGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lbliTrangThaiGV" runat="server"></asp:Label></td>
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
