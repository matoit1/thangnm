<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CKFinder.aspx.cs" Inherits="ThangNMjsc.Test.CKFinder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="<%=ResolveUrl("~/") %>Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="<%=ResolveUrl("~/") %>ckfinder/ckfinder.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnSelectImg").click(function () {
                var finder = new CKFinder();
                finder.selectActionFunction = function (fileUrl) {
                    $('#<%=txtImgUrl.ClientID %>').val(fileUrl);
                };
                finder.popup();
            });
        });
 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtImgUrl" runat="server"></asp:TextBox>
        <input type="button" id="btnSelectImg" value="Chọn ..." />
    </div>
    </form>
</body>
</html>
