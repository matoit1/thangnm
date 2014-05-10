<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachLopHocUC.ascx.cs" Inherits="DO_AN_TN.UserControl.DanhSachLopHocUC" %>
<fieldset style="height: 280px;">
    <legend>Danh sách sinh viên lớp học</legend>
    <div style="height: 220px; width: 275px; overflow: scroll;">
        <asp:CheckBoxList ID="cblDanhSachLop" runat="server">
        </asp:CheckBoxList>
    </div>
    <div>
        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
        <asp:Button ID="btnBlackList" runat="server" Text="Black List" onclick="btnBlackList_Click" />
        <asp:DropDownList ID="ddlTextFile" runat="server"></asp:DropDownList>
    </div>
</fieldset>