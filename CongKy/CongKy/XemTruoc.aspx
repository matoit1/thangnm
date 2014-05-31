<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XemTruoc.aspx.cs" Inherits="CongKy.XemTruoc" %>

<%@ Register src="UserControl/PdfUC.ascx" tagname="PdfUC" tagprefix="uc1" %>
<%@ Register src="UserControl/VideoUC.ascx" tagname="VideoUC" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       .tblInfo
        {
            width: 800px;
        }
        .colLeft
        {
            width: 200px;
        }
        .colRight
        {
            width: 500px;
        }
        .rowOther
        {
            background-color:#CCCCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="width: 800px; margin: 5px auto auto 250px;">
            <center><a href="../Default.aspx" rel="nofollow"><img src="../App_Themes/images/templatemo_logo.png" alt="Công Kỳ Hero" width="160px" height="100px"></a></center>
            <asp:Label ID="lblMsg" runat="server"></asp:Label><br /><br />
            <table  class="tblInfo">
                <tr class="rowOther">
                    <td class="colLeft">Mã giáo trình</td>
                    <td class="colRight">
                        <asp:Label ID="lblPK_iGiaoTrinhID" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Tên bài học</td>
                    <td class="colRight">
                        <asp:Label ID="lblsTenBaiHoc" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="rowOther">
                    <td class="colLeft">Thông tin bài học</td>
                    <td class="colRight">
                        <asp:Label ID="lblsThongTin" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Ngày cập nhật</td>
                    <td class="colRight">
                        <asp:Label ID="lbltNgayCapNhat" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="rowOther">
                    <td class="colLeft">Trạng thái</td>
                    <td class="colRight">
                        <asp:Label ID="lbliTrangThai" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Download tại đây !</td>
                    <td class="colRight"><asp:HyperLink ID="hplDownload" runat="server"><img src="../App_Themes/images/download_now.png" alt="Tải về ngay!" /></asp:HyperLink></td>
                </tr>
            </table>
        </div>
        <center>
        <asp:Panel ID="pnlVideo" runat="server" Visible="false">
            <uc2:VideoUC ID="VideoUC1" runat="server" />
        </asp:Panel>
        <asp:Panel ID="pnlPdf" runat="server" Visible="false">
            <uc1:PdfUC ID="PdfUC1" runat="server" />
        </asp:Panel>
        </center>
    </div>
    </form>
</body>
</html>
