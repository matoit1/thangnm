<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCKEditer.aspx.cs" Inherits="ThangNMjsc.Test.TestCKEditer" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <CKEditor:CKEditorControl ID="txtOther" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
    </div>
    </form>
</body>
</html>
