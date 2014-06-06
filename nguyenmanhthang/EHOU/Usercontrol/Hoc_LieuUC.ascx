<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Hoc_LieuUC.ascx.cs" Inherits="EHOU.UserControl.Hoc_LieuUC" %>
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
<fieldset style="width: 270px; height:240px">
    <legend>Học liệu giảng viên cung cấp</legend>
    <div style="width: 270px; height:185px; overflow: scroll;">
        <asp:Repeater ID="rptMaterial" runat="server">
            <ItemTemplate>
                <a href='<%#"../Preview.aspx?PK_lMaterial="+ Eval("PK_lMaterial")%>' target="_blank"><%#Eval("sDescription")%></a><br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
    <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click" />
    <asp:Button ID="btnPermit" runat="server" Text="Chặn" onclick="btnPermit_Click" />
</fieldset>