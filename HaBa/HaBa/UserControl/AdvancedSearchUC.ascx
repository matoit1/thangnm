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
                    <td><asp:TextBox ID="txtPK_sSanPhamID" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tên sản phẩm</td>
                    <td><asp:TextBox ID="txtsTenSanPham" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Giá bán từ</td>
                    <td>
                        50.000 VNĐ <input id="txtlGiaBan" name="txtlGiaBan" width="90px" type="range" min="50000" max="2000000" /> 2.000.000 VNĐ
                    <%--<asp:TextBox ID="txtlGiaBan" runat="server" Width="90px" type="range" min="0" max="10"></asp:TextBox>--%>
                    </td>
                </tr>
                <tr>
                    <td>Mô tả</td>
                    <td><asp:TextBox ID="txtsMoTa" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Xuất xứ</td>
                    <td><asp:TextBox ID="txtsXuatXu" runat="server" Width="250px"></asp:TextBox></td>
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