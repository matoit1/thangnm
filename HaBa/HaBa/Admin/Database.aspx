<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="HaBa.Admin.Database" MasterPageFile="~/ShareInterface/AdminSI.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
            <cc1:TabPanel runat="server" HeaderText="Sao lưu Cơ sở dữ liệu" ID="tabBackup">
            <ContentTemplate>
                <asp:RadioButton ID="radioSaveClient" runat="server" Text="Lưu trên Máy tính" AutoPostBack="true" Checked="true" GroupName="Save" oncheckedchanged="radioSaveClient_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton ID="radioSaveServer" runat="server" Text="Lưu vào Server" AutoPostBack="true" GroupName="Save" oncheckedchanged="radioSaveServer_CheckedChanged"></asp:RadioButton><br />
                <asp:TextBox ID="txtPath" runat="server" Text="D:\"></asp:TextBox><br />
                <br /><asp:Button ID="btnBackup" runat="server" Text="Backup" onclick="btnBackup_Click" /><br />
            </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel runat="server" HeaderText="Khôi phục Cơ sở dữ liệu" ID="tabRestore">
            <ContentTemplate>
                <asp:TreeView ID="trvFileBackup" runat="server" ImageSet="Events">
                    <ParentNodeStyle Font-Bold="False" />
                    <HoverNodeStyle Font-Underline="False" ForeColor="Red" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                    <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                </asp:TreeView><br />
                <asp:Button ID="btnRestore" runat="server" Text="Restore" onclick="btnRestore_Click" />
            </ContentTemplate>
            </cc1:TabPanel>
        </cc1:TabContainer>
    </div>
</asp:Content>
