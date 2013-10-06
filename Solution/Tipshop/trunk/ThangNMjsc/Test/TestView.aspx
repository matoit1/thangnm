<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestView.aspx.cs" Inherits="ThangNMjsc.Test.TestView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div> 
<asp:MultiView ID="MultiView1" runat="server">
<asp:View ID="ViewNOSP" runat="server">
không có sản phẩm nào trong phần này
<hr /> 
</asp:View> 
<asp:View ID="ViewDanhSach" runat="server">
<asp:Button ID="Button1" runat="server" Text="Thêm mới" 
onclick="Button1_Click" />
<hr /> 
Danh sách các sản phẩm
<hr /> 
<table style="width: 100%;">
<tr> <td> &nbsp; stt</td>
<td> &nbsp; Tên Sp</td>
<td> &nbsp; Công cụ</td>
</tr>
<tr> <td> &nbsp; 01</td>
<td> &nbsp; Máy tính để bàn</td>
<td> &nbsp; xóa,Thay đổi</td>
</tr>
<tr>
<td> &nbsp; 02</td>
<td> &nbsp; máy tính sách tay</td>
<td> &nbsp;&nbsp; xóa,Thay đổi</td>
</tr>
<tr>
<td> 03</td>
<td> Máy tính thanh lý</td>
<td> &nbsp;xóa,Thay đổi</td>
</tr>
</table>
</asp:View>
<asp:View ID="ViewThem" runat="server">
Thêm mới sản phẩm
<hr />
<table style="width: 100%;">
<tr>
<td> &nbsp; </td>
<td> &nbsp; </td>
<td> &nbsp; </td>
</tr>
<tr> <td> &nbsp; Tên sản phẩm</td>
<td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </td>
<td> &nbsp; </td>
</tr>
<tr>
<td> &nbsp; </td>
<td> &nbsp; <asp:Button ID="Button2" runat="server" Text="Chấp nhận" /> </td>
<td> &nbsp; </td>
</tr>
</table>

</asp:View>
</asp:MultiView>
<hr /> 
<asp:Button ID="Button3" runat="server" Text="Thêm mới" 
onclick="Button3_Click" />
<asp:Button ID="Button4"
runat="server" Text="Danh sách" onclick="Button4_Click" />
<asp:Button ID="Button5" runat="server" Text="Xóa toàn bộ" 
onclick="Button5_Click" />
</div>
</form>
</body>
</html>
