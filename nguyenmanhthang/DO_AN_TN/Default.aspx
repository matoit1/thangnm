<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DO_AN_TN.Default" EnableEventValidation="false"  %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đồ án tốt nghiệp - Lớp học ảo</title>
    <%--<script type="text/javascript">
        window.location.href = "../Test/TBaiViet.aspx"
	</script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:500px; margin-top: 200px; margin-left:550px">
            <asp:Button ID="btnTrangChu" runat="server" Text="Trang Chủ" onclick="btnTrangChu_Click" />
            <asp:Button ID="btnQuanTri" runat="server" Text="Quản trị" onclick="btnQuanTri_Click" />
            <asp:Button ID="btnGiangVien" runat="server" Text="Giảng viên" onclick="btnGiangVien_Click" />
            <asp:Button ID="btnSinhVien" runat="server" Text="Sinh Viên" onclick="btnSinhVien_Click" />
    </div>
    </form>
</body>
</html>
