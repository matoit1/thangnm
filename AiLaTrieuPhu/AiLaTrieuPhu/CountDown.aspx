<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountDown.aspx.cs" Inherits="AiLaTrieuPhu.CountDown" MasterPageFile="~/Public.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:ScriptManager ID="sm1" runat="server" />
    <asp:UpdatePanel ID="up1" runat="server" UpdateMode="always">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Text="10" ></asp:Label>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>