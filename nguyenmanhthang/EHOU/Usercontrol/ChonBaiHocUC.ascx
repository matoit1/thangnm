<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChonBaiHocUC.ascx.cs" Inherits="EHOU.Usercontrol.ChonBaiHocUC" %>

<fieldset class="divcahoc">
    <legend>Chọn Bài Học</legend>
    <asp:RadioButtonList ID="rbtnlListPart" runat="server" ontextchanged="rbtnlListPart_TextChanged" AutoPostBack="true">
    </asp:RadioButtonList>
</fieldset>