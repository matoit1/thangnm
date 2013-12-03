<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLDiem.aspx.cs" Inherits="AiLaTrieuPhu.Admin.QLDiem" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Mã điểm:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDiem_ID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblDiem_ID" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Điểm người dùng:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDiem_User" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblDiem_User" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Điểm tiền:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDiem_tien" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblDiem_tien" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Điểm ngày:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDiem_ngay" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblDiem_ngay" runat="server"></asp:Label>
                </td>
            </tr>
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
    <h1>Danh sách điểm</h1><br />
    <asp:GridView ID="grvDanhsachDiem" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
