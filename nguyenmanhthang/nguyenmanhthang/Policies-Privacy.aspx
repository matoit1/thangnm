<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Policies-Privacy.aspx.cs" Inherits="nguyenmanhthang.Policies_Privacy" MasterPageFile="~/Common/Default.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
<div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div style="overflow: hidden;">
                <div style="float: left; margin: 1px; width: 70px; background: #EAEAFF; text-align:center;">
                    <%# Eval("Accounts_Username")%>
                </div>
                <div style="float: left; margin: 1px; width: 150px; background: #EAEAFF; text-align:center;">
                    <%# Eval("Accounts_Email")%>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div style="overflow: hidden;">
        <asp:Repeater ID="rptPages" runat="server"
            onitemcommand="rptPages_ItemCommand1">
            <ItemTemplate>
                <asp:Button ID="btnPage" runat="server" Text="<%# Container.DataItem %>" CommandName="Page" CommandArgument="<%# Container.DataItem %>" />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
</asp:Content>
