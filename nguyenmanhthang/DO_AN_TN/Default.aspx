<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DO_AN_TN.Default" EnableEventValidation="false"  %>

<%@ Register src="UserControl/MonHoc_DetailUC.ascx" tagname="MonHoc_DetailUC" tagprefix="uc1" %>

<%@ Register src="UserControl/MonHoc_ListUC.ascx" tagname="MonHoc_ListUC" tagprefix="uc2" %>

<%@ Register src="UserControl/CauHoi_DetailUC.ascx" tagname="CauHoi_DetailUC" tagprefix="uc3" %>
<%@ Register src="UserControl/CauHoi_ListUC.ascx" tagname="CauHoi_ListUC" tagprefix="uc4" %>

<%@ Register src="UserControl/SinhVien_DetailUC.ascx" tagname="SinhVien_DetailUC" tagprefix="uc5" %>
<%@ Register src="UserControl/SinhVien_ListUC.ascx" tagname="SinhVien_ListUC" tagprefix="uc6" %>

<%@ Register src="UserControl/GiangVien_DetailUC.ascx" tagname="GiangVien_DetailUC" tagprefix="uc7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <%--<uc3:CauHoi_DetailUC ID="CauHoi_DetailUC1" runat="server" />
        <br />
        <uc4:CauHoi_ListUC ID="CauHoi_ListUC1" runat="server" />
        <br />

        <uc1:MonHoc_DetailUC ID="MonHoc_DetailUC1" runat="server" />
        <br />
        <uc2:MonHoc_ListUC ID="MonHoc_ListUC1" runat="server" />--%>

       <%-- <uc5:SinhVien_DetailUC ID="SinhVien_DetailUC1" runat="server" />
        <br />
        <uc6:SinhVien_ListUC ID="SinhVien_ListUC1" runat="server" />--%>

        <uc7:GiangVien_DetailUC ID="GiangVien_DetailUC1" runat="server" />

    </div>
    </form>
</body>
</html>
