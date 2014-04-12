<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Thong_Tin_Lop_HocUC.ascx.cs" Inherits="DO_AN_TN.UserControl.Thong_Tin_Lop_HocUC" %>
<style type="text/css">
    .style1
    {
        width: 54%;
    }
    .style2
    {
        width: 146px;
    }
</style>
<fieldset style="width: 725px; height:180px">
    <legend>Thông tin lớp học</legend>
    <table class="style1">
        <tr>
            <td class="style2">
                Tên lớp học:</td>
            <td>
                <asp:Label ID="lblsTenlop" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Tên môn học:</td>
            <td>
                <asp:Label ID="lblsTenMonhoc" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Giảng viên giảng dạy:</td>
            <td>
                <asp:Label ID="lblsHoTenGV" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sĩ số lớp:</td>
            <td>
                <asp:Label ID="lbliSiso" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</fieldset>