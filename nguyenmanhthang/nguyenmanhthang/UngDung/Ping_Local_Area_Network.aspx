<%@ Page Language="C#" AutoEventWireup="true" EnableViewState="false" CodeBehind="Ping_Local_Area_Network.aspx.cs" Inherits="nguyenmanhthang.UngDung.Ping_Local_Area_Network" MasterPageFile="~/Common/Default.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:ScriptManager ID="smPing_Local_Area_Network" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="upPing_Local_Area_Network" runat="server">
        <ContentTemplate>
            <br /><br /><center><asp:Label ID="lblTitle" runat="server" ForeColor="red" Font-Size="28px"></asp:Label><br /><br />
            <asp:Button ID="btnGet" runat="server" Text="Get" onclick="btnGet_Click" />
            <asp:Button ID="btnPing" runat="server" Text="Ping" onclick="btnPing_Click" /><br /><br /></center>
            <asp:Label ID="lblContent" runat="server"></asp:Label><br />
            <asp:Label ID="lblTest1" runat="server"></asp:Label><br />
            <asp:Label ID="lblTest2" runat="server"></asp:Label><br />
            <asp:Label ID="lblTest3" runat="server"></asp:Label><br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="upsPing_Local_Area_Network" runat="server" AssociatedUpdatePanelID="upPing_Local_Area_Network">
        <ProgressTemplate>
            <center><img src="http://www.benettonplay.com/toys/flipbookdeluxe/flipbooks_gif/2007/04/22/13320.gif" alt="Loading..." height="200px" /></center>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
