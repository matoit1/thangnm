﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SinhVien_DetailUC.ascx.cs" Inherits="DO_AN_TN.UserControl.SinhVien_DetailUC" %>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Giảng viên"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã sinh viên: </td>
            <td><asp:TextBox ID="txtFK_sMaLop" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblFK_sMaLop" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã sinh viên: </td>
            <td><asp:TextBox ID="txtPK_sMaSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_sMaSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ và tên: </td>
            <td><asp:TextBox ID="txtsHoTenSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsHoTenSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Tên đăng nhập: </td>
            <td><asp:TextBox ID="txtsTendangnhapSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsTendangnhapSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mật khẩu: </td>
            <td><asp:TextBox ID="txtsMatkhauSV" runat="server" Width="400px" TextMode="Password"></asp:TextBox></td>
            <td><asp:Label ID="lblsMatkhauSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ Email: </td>
            <td><asp:TextBox ID="txtsEmailSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsEmailSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ liên hệ: </td>
            <td><asp:TextBox ID="txtsDiachiSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsDiachiSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số điện thoại: </td>
            <td><asp:TextBox ID="txtsSdtSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsSdtSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày sinh: </td>
            <td><asp:TextBox ID="txttNgaysinhSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgaysinhSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Giới tính: </td>
            <td><asp:TextBox ID="txtbGioitinhSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblbGioitinhSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số CMND: </td>
            <td><asp:TextBox ID="txtsCMNDSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsCMNDSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cấp CMND: </td>
            <td><asp:TextBox ID="txttNgayCapCMNDSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapCMNDSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nơi cấp CMND: </td>
            <td><asp:TextBox ID="txtsNoiCapCMNDSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsNoiCapCMNDSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Họ và tên người liên hệ: </td>
            <td><asp:TextBox ID="txtsNguoiLienHeSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsNguoiLienHeSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Địa chỉ người liên hệ: </td>
            <td><asp:TextBox ID="txtsDiaChiNguoiLienHeSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsDiaChiNguoiLienHeSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số điện thoại người liên hệ: </td>
            <td><asp:TextBox ID="txtsSdtNguoiLienHeSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsSdtNguoiLienHeSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Quan hệ với người liên hệ: </td>
            <td><asp:TextBox ID="txtiQuanHeVoiNguoiLienHeSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliQuanHeVoiNguoiLienHeSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Năm tốt nghiệp THPT: </td>
            <td><asp:TextBox ID="txtiNamtotnghiepTHPTSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliNamtotnghiepTHPTSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày nhập học: </td>
            <td><asp:TextBox ID="txttNgayNhapHocSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayNhapHocSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày ra trường: </td>
            <td><asp:TextBox ID="txttNgayRaTruongSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayRaTruongSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Kết nạp đoàn TNCS HCM: </td>
            <td><asp:TextBox ID="txtbKetnapDoanSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblbKetnapDoanSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Năm kết nạp đoàn TNCS HCM: </td>
            <td><asp:TextBox ID="txtiNamketnapDoanSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliNamketnapDoanSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Nơi kết nạp đoàn TNCS HCM: </td>
            <td><asp:TextBox ID="txtsNoiketnapDoanSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblsNoiketnapDoanSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Hôn nhân: </td>
            <td><asp:TextBox ID="txtbHonNhanGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblbHonNhanGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Ngày cấp thẻ SV: </td>
            <td><asp:TextBox ID="txttNgayCapTheSV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbltNgayCapTheSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:TextBox ID="txtiTrangThaiGV" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lbliTrangThaiGV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" />
                <asp:Button ID="btnRefresh" runat="server" Text="Refresh" onclick="btnRefresh_Click" />
                <asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                    onclick="btnDelete_Click" style="height: 26px" />
                <asp:Button ID="btnExport" runat="server" Text="Export" 
                    onclick="btnExport_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>
