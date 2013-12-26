<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tech.aspx.cs" Inherits="Tech" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:CheckBox ID="chkTech" runat="server" AutoPostBack="true" Text="I'm a Tech!" OnCheckedChanged="chkTech_CheckedChanged" />
    <br /><br />
    <asp:GridView ID="gvMain" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:HyperLinkField HeaderText="Conversations" DataTextField="Subject" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="chat.aspx?type=tech&id={0}" />
            <asp:BoundField DataField="ClientLCID" HeaderText="Client Id" />
        </Columns>
    </asp:GridView>
    <br /><br />My Session Id: <%=Session.LCID %>
</asp:Content>

