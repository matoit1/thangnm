<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchProductUC.ascx.cs" Inherits="ThangNMjsc.UserControls.SearchProductUC" %>
<link href="../Css/public.css" rel="stylesheet" type="text/css" />
<div class="search">
    <center><asp:TextBox ID="txtProducts_Name" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search"  onclick="btnSearch_Click" />
        <asp:LinkButton ID="btnShowSearchAdvanced" runat="server" OnClick="btnShowSearchAdvanced_Click">Tìm kiếm nâng cao</asp:LinkButton>
    </center>
    <asp:Panel ID="PanelSearchAdvanced" runat="server" Visible="false">
        <table>
            <tr>
                <td>Tìm kiếm theo mô tả: </td><td><asp:TextBox ID="txtProducts_Description" runat="server"></asp:TextBox></td>
                <td>Tìm kiếm theo thông tin: </td><td colspan="3"><asp:TextBox ID="txtProducts_Info" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tìm kiếm theo xuất xứ: </td><td><asp:TextBox ID="txtProducts_Origin" runat="server"></asp:TextBox></td>
                <td>Tìm kiếm theo giá bán từ: </td><td><asp:TextBox ID="TextBox4" runat="server"  Width="60px"></asp:TextBox></td>
                <td>đến: </td><td><asp:TextBox ID="TextBox5" runat="server"  Width="60px"></asp:TextBox></td>
            </tr>
        </table>
        <center><asp:Button ID="btnSearch1" runat="server" Text="Search"  onclick="btnSearch_Click" /></center>
    </asp:Panel>
</div>