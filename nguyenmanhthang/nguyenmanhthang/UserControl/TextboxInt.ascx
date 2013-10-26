<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextboxInt.ascx.cs" Inherits="nguyenmanhthang.UserControl.TextboxInt" %>
<script>
    function keyInteger(e) {
        var keyword = null;
        if (window.event) {
            keyword = window.event.keyCode;
        } else {
            keyword = e.which; //NON IE;
        }

        if (keyword < 48 || keyword > 57) {
            if (keyword == 48 || keyword == 127) {
                return;
            }
            return false;
        }
    }
</script>
<asp:TextBox ID="txtInteger" runat="server" onkeypress="return keyInteger(event);"></asp:TextBox>