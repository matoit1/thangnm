<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="ThangNMjsc.Test.Email" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Gửi tới:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtTo" runat="server" Width="280px"></asp:TextBox>
    <br />
    Subject:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSubject" runat="server" Width="280px"></asp:TextBox>
    <br />
    Nội dung:&nbsp;
    <asp:TextBox ID="txtConTent" runat="server" Rows="4" TextMode="MultiLine" 
       Width="278px"></asp:TextBox>
    <asp:Button ID="btnSend" runat="server" onclick="btnSend_Click" 
       Text="Gửi mail" />
</div>
    </form>
</body>
</html>
