<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="ThangNMjsc.Admin.Database" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
<br /><br />
    <asp:Button ID="btnTab1" runat="server" Text="Sao lưu dữ liệu" onclick="btnTab1_Click" />
    <asp:Button ID="btnTab2" runat="server" Text="Khôi phục dữ liệu" onclick="btnTab2_Click" />
    <asp:MultiView ID="multiViewDatabase" runat="server">
        <asp:View ID="viewBackup" runat="server">
            <asp:Panel ID="pnlBackup" runat="server" GroupingText="Sao lưu dữ liệu" Width="400px" ScrollBars="Auto">
                    <asp:RadioButton ID="radioSaveClient" runat="server" Text="Lưu trên Máy tính" AutoPostBack="true" Checked="true" GroupName="Save" oncheckedchanged="radioSaveClient_CheckedChanged"></asp:RadioButton>
                    <asp:RadioButton ID="radioSaveServer" runat="server" Text="Lưu vào Server" AutoPostBack="true" GroupName="Save" oncheckedchanged="radioSaveServer_CheckedChanged"></asp:RadioButton><br />
                    <asp:TextBox ID="txtPath" runat="server" Text="D:\"></asp:TextBox><br />
                <br /><asp:Button ID="btnBackup" runat="server" Text="Backup" onclick="btnBackup_Click" /><br />
            </asp:Panel>
        </asp:View>
        <asp:View ID="viewRestore" runat="server">
            <asp:Panel ID="pnlRestore" runat="server" GroupingText="Danh sách các File Backup" Width="400px" ScrollBars="Auto">
                    <asp:TreeView ID="trvFileBackup" runat="server" ImageSet="Events">
                        <ParentNodeStyle Font-Bold="False" />
                        <HoverNodeStyle Font-Underline="False" ForeColor="Red" />
                        <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                        <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    </asp:TreeView><br />
                    <asp:Button ID="btnRestore" runat="server" Text="Restore" onclick="btnRestore_Click" />
            </asp:Panel>
        </asp:View>
    </asp:MultiView>
</asp:Content>
