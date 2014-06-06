<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Preview.aspx.cs" Inherits="EHOU.Preview" %>
<%@ Register src="UserControl/PdfUC.ascx" tagname="PdfUC" tagprefix="uc1" %>
<%@ Register src="UserControl/VideoUC.ascx" tagname="VideoUC" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            <center><a href="../Default.aspx" rel="nofollow"><img src="Images/Avatar/default.png" alt="Công Kỳ Hero" width="160px" height="100px"></a></center>
            <asp:Label ID="lblMsg" runat="server"></asp:Label><br /><br />
            <table  class="tblInfo">
                <tr class="rowOther">
                    <td class="colLeft">Mã học liệu:</td>
                    <td class="colRight">
                        <asp:Label ID="lblPK_lMaterial" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Tên môn học:</td>
                    <td class="colRight">
                        <asp:Label ID="lblFK_sSubject" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="rowOther">
                    <td class="colLeft">Giảng viên đăng tải:</td>
                    <td class="colRight">
                        <asp:Label ID="lblFK_sUsername" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Mô tả:</td>
                    <td class="colRight">
                        <asp:Label ID="lblsDescription" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="rowOther">
                    <td class="colLeft">Ngày cập nhật:</td>
                    <td class="colRight">
                        <asp:Label ID="lbltLastUpdate" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Kích thước file: </td>
                    <td class="colRight">
                        <asp:Label ID="lbliSize" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="rowOther">
                    <td class="colLeft">Loại học liệu: </td>
                    <td class="colRight">
                        <asp:Label ID="lbliType" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="colLeft">Trạng thái</td>
                    <td class="colRight">
                        <asp:Label ID="lbliStatus" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="rowOther">
                    <td class="colLeft">Download tại đây !</td>
                    <td class="colRight"><asp:HyperLink ID="hplsLinkDownload" runat="server"><img src="Images/New/download_now.gif" width="300px" alt="Tải về ngay!" /></asp:HyperLink></td>
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
