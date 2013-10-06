<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Valid.aspx.cs" Inherits="ThangNMjsc.Test.Valid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary DisplayMode="List" HeaderText="Báo lỗi" ShowMessageBox="false" ShowSummary="true" ID="ValidationSummary1" runat="server" />

        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Họ tên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHoten" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn phải nhập họ tên" ControlToValidate="txtHoten">* (Yêu cầu)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn phải nhập Email" ControlToValidate="txtEmail">* (Yêu cầu)</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Email ko hợp lệ" ControlToValidate="txtEmail" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Accept" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
