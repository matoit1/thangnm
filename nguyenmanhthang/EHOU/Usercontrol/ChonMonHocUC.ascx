<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChonMonHocUC.ascx.cs" Inherits="EHOU.Usercontrol.ChonMonHocUC" %>

<fieldset class="divcahoc">
    <legend>Chọn Môn Học</legend>
    <asp:RadioButtonList ID="rbtnlListSubject" runat="server" ontextchanged="rbtnlListSubject_TextChanged" AutoPostBack="true">
    </asp:RadioButtonList>
</fieldset>