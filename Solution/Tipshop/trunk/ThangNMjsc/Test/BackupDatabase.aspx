<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackupDatabase.aspx.cs" Inherits="ThangNMjsc.Admin.BackupDatabase" MasterPageFile="~/MasterPage/PublicAdmin.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
<div>
    <asp:Panel ID="Panel1" runat="server" 
        GroupingText="Danh sách các File dữ liệu đã backup" 
         Width="400px" ScrollBars="Auto">
            <asp:TreeView ID="trvFileBackup" runat="server" ImageSet="Events">
                <ParentNodeStyle Font-Bold="False" />
                <HoverNodeStyle Font-Underline="False" ForeColor="Red" />
                <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px"
                    NodeSpacing="0px" VerticalPadding="0px" />
            </asp:TreeView>
    </asp:Panel>

    <asp:Panel ID="Panel3" runat="server">
        <asp:Button ID="btnRestore" runat="server" Text="Restore"  OnClick="btnRestore_Click" />
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" 
        Width="400px" Height="200px" GroupingText="Thực hiện Backup">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td style="height:100px" valign="top">
        <asp:Label ID="Label3" runat="server" Text="Tên Files:"></asp:Label>
        <asp:TextBox ID="txtTenFile" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnBackup" runat="server" Text="Sao Lưu dữ liệu" OnClick="btnBackup_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</div>
</asp:Content>