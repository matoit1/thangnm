<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BaiViet_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.BaiViet_DetailUC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Bài viết"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Giáo viên: </td>
            <td><asp:DropDownList ID="ddlFK_sMaGV" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã bài viết: </td>
            <td><asp:TextBox ID="txtPK_lMaBaiViet" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_lMaBaiViet" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tiêu đề: </td>
            <td><asp:TextBox ID="txtsTieuDe" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsTieuDe" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link Ảnh: </td>
            <td><asp:TextBox ID="txtsLinkAnh" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkAnh" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tags: </td>
            <td><asp:TextBox ID="txtsTag" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsTag" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nội dung: </td>
            <td>
            <CKEditor:CKEditorControl ID="txtsNoiDung" runat="server" Width="800px"></CKEditor:CKEditorControl>
            </td>
            <td><asp:Label ID="lblsNoiDung" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Lượt xem: </td>
            <td><asp:TextBox ID="txtiLuotXem" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbliLuotXem" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày viết: </td>
            <td><asp:TextBox ID="txttNgayViet" runat="server" Width="400px" class="startdate" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayViet" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cập nhật: </td>
            <td><asp:TextBox ID="txttNgayCapNhat" runat="server" Width="400px" class="startdate" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapNhat" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mô tả: </td>
            <td><asp:TextBox ID="txtsMoTa" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsMoTa" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px"></asp:DropDownList></td>
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