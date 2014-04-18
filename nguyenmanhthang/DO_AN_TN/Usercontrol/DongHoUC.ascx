<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DongHoUC.ascx.cs" Inherits="DO_AN_TN.UserControl.DongHoUC" %>
<asp:ScriptManager ID="smTime" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="upTime" runat="server">
    <ContentTemplate>
        <div class="time">
        <asp:Timer ID="tClock" runat="server" ontick="tClock_Tick"></asp:Timer>
        <asp:Button ID="btnClock" runat="server" />
        <asp:Label ID="lblCaHoc" runat="server"></asp:Label>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
