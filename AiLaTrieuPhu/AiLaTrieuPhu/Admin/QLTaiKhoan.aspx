<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLTaiKhoan.aspx.cs" Inherits="AiLaTrieuPhu.Admin.QLTaiKhoan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div style="width:600px; margin: 0 auto 0 auto">
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Mã tài khoản:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_ID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_ID" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Tên đăng nhập"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_tentaikhoan" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_tentaikhoan" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Mật khẩu:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_matkhau" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_matkhau" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_Email" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_Email" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Tên đầy đủ:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_tendaydu" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_tendaydu" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Địa chỉ:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_diachi" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_diachi" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Ngày sinh"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_ngaysinh" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_ngaysinh" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Số điện thoại:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_sodienthoai" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_sodienthoai" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Quyền hạn:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_quyenhan" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbtaikhoan_quyenhan" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Ảnh đại điện:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_annhdaidien" runat="server" ></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_annhdaidien" runat="server"></asp:Label>
                </td>
          
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Trạng thái:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_trangthai" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_trangthai" runat="server"></asp:Label>
                </td>
          
            <tr>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Ngày đăng ký:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txttaikhoan_ngaydangky" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbltaikhoan_ngaydangky" runat="server"></asp:Label>
                </td>
          
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnThem" runat="server" Text="Thêm" onclick="btnThem_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" Text="Sửa" onclick="btnSua_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" onclick="btnXoa_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnTimkiem" runat="server" Text="Tìm kiếm" onclick="btnTimkiem_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnXoatrang" runat="server" Text="Xóa trắng" onclick="btnXoatrang_Click" />
                </td>
                <td></td>
            </tr>
        </table>
    </div>
    <br /><br />
    <h1>Danh sách tài khoản</h1><br />
    <asp:GridView ID="grvDanhsachTaikhoan" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
