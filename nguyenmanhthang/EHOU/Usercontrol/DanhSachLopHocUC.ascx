<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachLopHocUC.ascx.cs" Inherits="EHOU.UserControl.DanhSachLopHocUC" %>
<fieldset style="height: 280px;">
    <legend>Danh sách sinh viên lớp học</legend>
    <div style="height: 270px; width: 270px; overflow: scroll;">
        <asp:CheckBoxList ID="cblDanhSachLop" runat="server">
        </asp:CheckBoxList>
    </div>
</fieldset>