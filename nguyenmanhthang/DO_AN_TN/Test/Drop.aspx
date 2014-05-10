<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Drop.aspx.cs" Inherits="DO_AN_TN.Test.Drop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <br />
        <asp:TextBox ID="txtColor" runat="server" type="color" ontextchanged="txtColor_TextChanged" AutoPostBack="true"></asp:TextBox>
        <asp:Label ID="lblColor" runat="server" Text="Color"></asp:Label>

        <table>
            
            <tr>
                <td>Quyền hạn:</td>
                <td><asp:DropDownList ID="ddlSelectList1" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg1" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Học vị:</td>
                <td><asp:DropDownList ID="ddlSelectList2" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg2" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Giới tính:</td>
                <td><asp:DropDownList ID="ddlSelectList3" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg3" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Hôn Nhân:</td>
                <td><asp:DropDownList ID="ddlSelectList4" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg4" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Công Chức:</td>
                <td><asp:DropDownList ID="ddlSelectList5" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg5" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Trạng Thái Giáo Viên:</td>
                <td><asp:DropDownList ID="ddlSelectList6" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg6" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Trạng Thái Sinh Viên:</td>
                <td><asp:DropDownList ID="ddlSelectList7" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg7" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Đoàn thanh niên cộng sản Hồ Chí Minh:</td>
                <td><asp:DropDownList ID="ddlSelectList8" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg8" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Quan hệ với người liên hệ:</td>
                <td><asp:DropDownList ID="ddlSelectList9" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg9" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Hệ số tính điểm:</td>
                <td><asp:DropDownList ID="ddlSelectList10" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg10" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Xếp loại kết quả học tập:</td>
                <td><asp:DropDownList ID="ddlSelectList11" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg11" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Tính điểm chuyên cần:</td>
                <td><asp:DropDownList ID="ddlSelectList12" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg12" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Chức vụ:</td>
                <td><asp:DropDownList ID="ddlSelectList13" runat="server"></asp:DropDownList></td>
                <td><asp:Label ID="lblMsg13" runat="server"></asp:Label></td>
            </tr>
            <tr></tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnCheck" runat="server" Text="Check" onclick="btnCheck_Click" /></td>
                <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
