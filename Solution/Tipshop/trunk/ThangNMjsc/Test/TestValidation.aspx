<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestValidation.aspx.cs" Inherits="ThangNMjsc.Test.TestValidation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="checkall" HeaderText="Báo lỗi" ShowMessageBox="true"/>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtEmail" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
