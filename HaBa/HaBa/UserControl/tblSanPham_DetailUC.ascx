<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblSanPham_DetailUC.ascx.cs" Inherits="HaBa.UserControl.tblSanPham_DetailUC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

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
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin sản phẩm"  CssClass="form_tittle"></asp:Label></td>
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
            <td>Mã sản phẩm: </td>
            <td><asp:TextBox ID="txtPK_sSanPhamID" runat="server" Width="400px" MaxLength="50"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sSanPhamID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nhóm sản phẩm: </td>
            <td><asp:DropDownList ID="ddlFK_iNhomSanPhamID" runat="server" Width="405px" 
                    TabIndex="1"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_iNhomSanPhamID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên sản phẩm: </td>
            <td><asp:TextBox ID="txtsTenSanPham" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="2"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenSanPham" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mô tả: </td>
            <td><asp:TextBox ID="txtsMoTa" runat="server" Width="400px" TextMode="MultiLine" 
                    Rows="3" Enabled = "false" MaxLength="500" ></asp:TextBox></td>
            <td><asp:Label ID="lblsMoTa" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Thông tin: </td>
            <td><CKEditor:CKEditorControl ID="txtsThongTin" runat="server" Width="800px" 
                    TabIndex="4"></CKEditor:CKEditorControl></td>
            <td><asp:Label ID="lblsThongTin" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Xuất xứ: </td>
            <td><asp:TextBox ID="txtsXuatXu" runat="server" Width="400px" MaxLength="50" 
                    TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lblsXuatXu" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link hình ảnh: </td>
            <td><asp:TextBox ID="txtsLinkImage" runat="server" Width="400px" MaxLength="500" 
                    TabIndex="6"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkImage" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Giá bán: </td>
            <td><asp:TextBox ID="txtlGiaBan" runat="server" Width="400px" TabIndex="7"></asp:TextBox> VNĐ</td>
            <td><asp:Label ID="lbllGiaBan" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Thuế giá trị gia tăng VAT: </td>
            <td><asp:TextBox ID="txtiVAT" runat="server" Width="400px" TabIndex="8"></asp:TextBox> %</td>
            <td><asp:Label ID="lbliVAT" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Độ tuổi: </td>
            <td><asp:DropDownList ID="ddliDoTuoi" runat="server" Width="405px" TabIndex="9"></asp:DropDownList></td>
            <td><asp:Label ID="lbliDoTuoi" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Giới tính: </td>
            <td><asp:DropDownList ID="ddliGioiTinh" runat="server" Width="405px" TabIndex="10"></asp:DropDownList></td>
            <td><asp:Label ID="lbliGioiTinh" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số lượng: </td>
            <td><asp:TextBox ID="txtiSoLuong" runat="server" Width="400px" TabIndex="11"></asp:TextBox></td>
            <td><asp:Label ID="lbliSoLuong" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cập nhật: </td>
            <td><asp:TextBox ID="txttNgayCapNhat" runat="server" Width="400px" 
                    class="startdate" Enabled="false" TabIndex="12"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapNhat" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px" TabIndex="13"></asp:DropDownList></td>
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
                    onclick="btnInsert_Click" TabIndex="14" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" TabIndex="15" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" TabIndex="16" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    TabIndex="17" />
            </td>
            <td></td>
        </tr>
    </table>
</div>