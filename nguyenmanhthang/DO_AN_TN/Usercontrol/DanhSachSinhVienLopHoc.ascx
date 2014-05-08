<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachSinhVienLopHoc.ascx.cs" Inherits="DO_AN_TN.UserControl.DanhSachSinhVienLopHoc" %>
<div style="width: 300px; border:2px solid black;">
    <div style="height: 400px; overflow: scroll; width: 290px; padding: 5px; ">
        <asp:CheckBoxList ID="cblDanhSachLop" runat="server">
        </asp:CheckBoxList>
    </div>
    <div style="border-top: 2px solid black;">
        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
        <asp:Button ID="btnBlackList" runat="server" Text="Black List" onclick="btnBlackList_Click" />
        <asp:DropDownList ID="ddlTextFile" runat="server">
        </asp:DropDownList>
    </div>
</div>
