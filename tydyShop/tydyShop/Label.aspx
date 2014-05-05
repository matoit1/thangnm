<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Label.aspx.cs" Inherits="tydyShop.Labels" MasterPageFile="~/ShareInterface/ProductSI.Master" %>
<%@ Register src="UserControl/AdvancedSearchUC.ascx" tagname="AdvancedSearchUC" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
<div class="clear"></div>
<div style="padding: 0px 100px 0px 100px">
    <h1><asp:Label ID="lblTitle" runat="server"></asp:Label></h1>
    <asp:Panel ID="pnlSearch" runat="server" DefaultButton="btnSearch">
        <asp:TextBox ID="txtKeyWord" runat="server" Width="500px" Height="30px"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Width="90px" Height="37px" Text="Tìm kiếm" onclick="btnSearch_Click" />
        <asp:LinkButton ID="lbtnAdvancedSearch" runat="server" 
            onclick="lbtnAdvancedSearch_Click">Tìm kiếm nâng cao</asp:LinkButton>
    </asp:Panel>
    <uc1:AdvancedSearchUC ID="AdvancedSearchUC1" runat="server" Visible="false"/>
    <h4><i><asp:Label ID="lblMsg" runat="server"></asp:Label></i></h4>
    <asp:Repeater ID="rptResultSearch" runat="server" onitemdatabound="rptResultSearch_ItemDataBound">
        <ItemTemplate>
            <asp:Label ID="lblPK_lProductID" runat="server" Text='<%# Eval("PK_lProductID") %>'></asp:Label><br />
            <asp:Label ID="lblsName" runat="server" Text='<%# Eval("sName") %>'></asp:Label><br />
            <asp:Label ID="lblsDescription" runat="server" Text='<%# Eval("sDescription") %>'></asp:Label><br />
            <br /><hr />
        </ItemTemplate>
    </asp:Repeater>
    <br />
    
    <br />
</div>
</asp:Content>