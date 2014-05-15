<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LichDayVaHoc_SearchUC.ascx.cs" Inherits="EHOU.UserControl.Search.LichDayVaHoc_SearchUC" %>
<div id="toPopup">
	<div class="close"></div>
	<span class="ecs_tooltip">Bấm phím Esc để đóng cửa sổ này!</span>
	<div id="popup_content">
        <asp:Panel ID="Panel1" runat="server" CssClass="wrap" DefaultButton="btnSearch">
            <table>
                <tr>
                    <td colspan="2" class="title">Tìm kiếm lịch dạy và học</td>
                </tr>
                <tr><td>&nbsp;</td></tr>
                <tr>
                    <td colspan="2"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Mã Lớp Học</td>
                    <td><asp:TextBox ID="txtFK_sMaLop" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mã Sinh Viên</td>
                    <td><asp:TextBox ID="txtPK_sMaSV" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Họ và Tên</td>
                    <td><asp:TextBox ID="txtsHotenSV" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tên đăng nhập</td>
                    <td><asp:TextBox ID="txtsTendangnhapSV" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" 
                            onclick="btnSearch_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Hủy" 
                            onclick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</div>
<div id="backgroundPopup"></div>