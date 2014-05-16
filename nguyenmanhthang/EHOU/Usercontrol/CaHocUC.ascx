<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CaHocUC.ascx.cs" Inherits="EHOU.Usercontrol.CaHocUC" %>

<fieldset class="divcahoc">
        <legend>Chọn lớp học muốn vào học !</legend>
    <asp:RadioButtonList ID="rbtnlListClass" runat="server" ontextchanged="rbtnlListClass_TextChanged" AutoPostBack="true">
    </asp:RadioButtonList>
</fieldset>