<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Hoc_LieuUC.ascx.cs" Inherits="DO_AN_TN.UserControl.Hoc_LieuUC" %>
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
    <asp:TreeView ID="trvFileUpload" runat="server" ImageSet="Events" Width="250px" 
        ShowCheckBoxes="All" 
        ontreenodecheckchanged="trvFileUpload_TreeNodeCheckChanged" >
        <ParentNodeStyle Font-Bold="False" Width="250px" />
        <HoverNodeStyle Font-Underline="False" ForeColor="Red" Width="250px" />
        <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" Width="250px" />
        <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px"  Width="250px"/>
    </asp:TreeView>
    </div>
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
    <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click" />
    <asp:Button ID="btnPermit" runat="server" Text="Chặn" onclick="btnPermit_Click" />
</fieldset>