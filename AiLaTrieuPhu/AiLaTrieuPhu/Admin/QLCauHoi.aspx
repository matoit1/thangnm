<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLCauHoi.aspx.cs" Inherits="AiLaTrieuPhu.Admin.QLCauHoi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
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
                    <asp:Label ID="Label4" runat="server" Text="Mã câu hỏi:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_ID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_ID" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Câu hỏi"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_cauhoi" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_cauhoi" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Câu trả lời A:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_A" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_A" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Câu trả lời B:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_B" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_B" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Câu trả lời C:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_C" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_C" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Câu trả lời D:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_D" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_D" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Câu trả lời đúng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_dung" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_dung" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Cấp độ:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCauhoi_capdo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCauhoi_capdo" runat="server"></asp:Label>
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
    <h1>Danh sách câu hỏi</h1><br />
    <asp:GridView ID="grvDanhsachCauhoi" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
