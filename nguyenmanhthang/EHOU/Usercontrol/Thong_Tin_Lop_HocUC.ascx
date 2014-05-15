<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Thong_Tin_Lop_HocUC.ascx.cs" Inherits="EHOU.UserControl.Thong_Tin_Lop_HocUC" %>
<style type="text/css">
    .tblInfo
    {
        width: 755px;
    }
    .colLeft
    {
        width: 155px;
    }
    .colRight
    {
        width: 600px;
    }
    .rowOther
    {
        background-color:#CCCCFF;
    }
</style>
<fieldset style="width: 725px; height:240px">
    <legend>Thông tin lớp học</legend>
    <table class="tblInfo">
        <tr class="rowOther">
            <td class="colLeft">Tên lớp học:</td>
            <td class="colRight"><asp:Label ID="lblsTenlop" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="colLeft">Tên môn học:</td>
            <td class="colRight"><asp:Label ID="lblsTenMonhoc" runat="server"></asp:Label></td>
        </tr>
        <tr class="rowOther">
            <td class="colLeft">Giảng viên giảng dạy:</td>
            <td class="colRight"><asp:Label ID="lblsHoTenGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="colLeft">Sĩ số lớp:</td>
            <td class="colRight"><asp:Label ID="lbliSiso" runat="server"></asp:Label></td>
        </tr>
        <tr class="rowOther">
            <td class="colLeft">Ca học:</td>
            <td class="colRight"><asp:Label ID="lbliCaHoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="colLeft">Số tiết dạy:</td>
            <td class="colRight"><asp:Label ID="lbliSoTietDay" runat="server"></asp:Label></td>
        </tr>
        <tr class="rowOther">
            <td class="colLeft">Ngày bắt đầu môn học:</td>
            <td class="colRight"><asp:Label ID="lbltNgayBatDau" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="colLeft">Ngày kết thúc môn học:</td>
            <td class="colRight"><asp:Label ID="lbltNgayKetThuc" runat="server"></asp:Label></td>
        </tr>
        <tr class="rowOther">
            <td class="colLeft">Trạng thái:</td>
            <td class="colRight"><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
        </tr>
    </table>
</fieldset>