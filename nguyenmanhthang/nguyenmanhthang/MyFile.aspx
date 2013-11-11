<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyFile.aspx.cs" Inherits="nguyenmanhthang.MyFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to My Profile</h1>
    <asp:Label ID="msgError" runat="server" ForeColor="Red"></asp:Label>
    </div>
    <br />
    <asp:Button ID="btnAddNew" runat="server" Text="AddNew" OnClick="btnAddNew_Click" />
    <br />
    <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
    </div>
    </form>
</body>
</html>
