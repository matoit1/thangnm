<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdvancedSearchUC.ascx.cs" Inherits="HaBa.UserControl.AdvancedSearchUC" %>
<div id="toPopup">
	<div class="close"></div>
	<span class="ecs_tooltip">Bấm phím Esc để đóng cửa sổ này!</span>
	<div id="popup_content">
        <asp:Panel ID="Panel1" runat="server" CssClass="wrap" DefaultButton="btnSearch">
            <table>
                <tr>
                    <td colspan="2" class="title">Tìm kiếm nâng cao</td>
                </tr>
                <tr><td>&nbsp;</td></tr>
                <tr>
                    <td colspan="2"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Mã Sản Phẩm</td>
                    <td><asp:TextBox ID="txtPK_lProductID" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tên sản phẩm</td>
                    <td><asp:TextBox ID="txtsName" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Giá bán từ</td>
                    <td><asp:TextBox ID="txtlPrice1" runat="server" Width="90px"></asp:TextBox>đến
                        <asp:TextBox ID="txtlPrice2" runat="server" Width="90px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mô tả</td>
                    <td><asp:TextBox ID="txtsDescription" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Thông tin</td>
                    <td><asp:TextBox ID="txtsInfomation" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Xuất xứ</td>
                    <td><asp:TextBox ID="txtsOrigin" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Hủy" onclick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</div>
<div id="backgroundPopup"></div>