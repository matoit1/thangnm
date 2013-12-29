<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnimatedPictures.aspx.cs" Inherits="nguyenmanhthang.AnimatedPictures" MasterPageFile="~/Common/Default.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
<table width="700px">
    <tr>
        <td class="left-right"><asp:Button ID="btnBack" runat="server" Text="Trở lại" 
                onclick="btnBack_Click" /></td>
        <td></td>
        <td class="left-right"><asp:Button ID="btnPrevious" runat="server" Text="Tiến" onclick="btnPrevious_Click" /></td>
    </tr>
    <tr>
        <td class="left-right"></td>
        <td class="center"><asp:Image ID="imgAnimatedPictures" runat="server" ImageUrl="~/Images/Gif/1.gif" width="650px" /></td>
        <td class="left-right"></td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="cphHead">
    <style type="text/css">
        .left-right
        {
            width: 20px;
        }
        .center
        {
            width: 680px;
        }
    </style>
</asp:Content>

