<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblTaiKhoan_DetailUC.ascx.cs" Inherits="CongKy.UserControl.tblTaiKhoan_DetailUC" %>

<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Thông tin tài khoản"  CssClass="form_tittle"></asp:Label></td>
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
            <td><asp:Label ID="lblPK_iTaiKhoanID_Title" runat="server" Text="Mã tài khoản: "></asp:Label></td>
            <td><asp:TextBox ID="txtPK_iTaiKhoanID" runat="server" Width="400px" Enabled="false"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iTaiKhoanID" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên đăng nhập: </td>
            <td><asp:TextBox ID="txtsTenDangNhap" runat="server" Width="400px" MaxLength="50" TabIndex="1"></asp:TextBox></td>
            <td><asp:Label ID="lblsTenDangNhap" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mật khẩu: </td>
            <td><asp:TextBox ID="txtsMatKhau" runat="server" Width="400px" TextMode="Password"  MaxLength="50" TabIndex="2"></asp:TextBox></td>
            <td><asp:Label ID="lblsMatKhau" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ và Tên: </td>
            <td><asp:TextBox ID="txtsHoTen" runat="server" Width="400px" MaxLength="50" TabIndex="3"></asp:TextBox></td>
            <td><asp:Label ID="lblsHoTen" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtsEmail" runat="server" Width="400px" MaxLength="50" TabIndex="4"></asp:TextBox></td>
            <td><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ: </td>
            <td><asp:TextBox ID="txtsDiaChi" runat="server" Width="400px" MaxLength="500" TabIndex="5"></asp:TextBox></td>
            <td><asp:Label ID="lblsDiaChi" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số điện thoại: </td>
            <td><asp:TextBox ID="txtsSoDienThoai" runat="server" Width="400px" MaxLength="13" TabIndex="6"></asp:TextBox></td>
            <td><asp:Label ID="lblsSoDienThoai" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Link Avatar: </td>
            <td><asp:TextBox ID="txtsLinkAvatar" runat="server" Width="400px" MaxLength="500" TabIndex="7"></asp:TextBox></td>
            <td><asp:Label ID="lblsLinkAvatar" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày sinh: </td>
            <td><asp:TextBox ID="txttNgaySinh" runat="server" Width="400px" class="startdate" MaxLength="32897" TabIndex="8"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgaySinh" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày đăng ký: </td>
            <td><asp:TextBox ID="txttNgayDangKy" runat="server" Width="400px" Enabled="false" MaxLength="32897" TabIndex="9" class="startdate"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayDangKy" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lbliQuyenHan_Title" runat="server" Text="Quyền hạn: "></asp:Label></td>
            <td><asp:DropDownList ID="ddliQuyenHan" runat="server" Width="405px" TabIndex="10"></asp:DropDownList></td>
            <td><asp:Label ID="lbliQuyenHan" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lbliTrangThai_Title" runat="server" Text="Trạng thái: "></asp:Label></td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px" TabIndex="11"></asp:DropDownList></td>
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