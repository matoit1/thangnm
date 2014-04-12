<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcuteProgram.aspx.cs" Inherits="DO_AN_TN.ExcuteProgram" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:FileUpload ID="fuFile" runat="server" />
        <asp:Button ID="btnUpload" runat="server" onclick="btnUpload_Click" Text="Upload" />
        <asp:Button ID="btnBuildCode" runat="server" Text="Build Code" onclick="btnBuildCode_Click" />
        <br />
        <asp:Label ID="lblFileName" runat="server" ></asp:Label><br />
        <asp:Label ID="lblFileClength" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
