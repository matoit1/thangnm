<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLCauhoi.aspx.cs" Inherits="TracNghiemTrucTuyen.QLCauhoi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label><br />
        Tên câu hỏi: <asp:TextBox ID="txttencauhoi" runat="server"></asp:TextBox><br />
        Đáp án A <asp:TextBox ID="txtdaa" runat="server"></asp:TextBox><br />
        Đáp án B <asp:TextBox ID="txtdab" runat="server"></asp:TextBox><br />
        Đáp án C <asp:TextBox ID="txtdac" runat="server"></asp:TextBox><br />
        Đáp án D <asp:TextBox ID="txtdad" runat="server"></asp:TextBox><br />
        Đáp án Đúng <asp:TextBox ID="txtdadung" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="OK" onclick="btnAdd_Click" />
    </div>
    <asp:GridView ID="grvDS" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
