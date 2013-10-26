<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DroplistKey.ascx.cs" Inherits="nguyenmanhthang.UserControl.DroplistKey" %>
<script language="javascript" type="text/javascript">
// <![CDATA[

    function slTest_onchange() {
        txtTest.value = ddlValue.ontextchanged();
    }

// ]]>
</script>

<asp:TextBox ID="txtKey" runat="server"></asp:TextBox>
<asp:DropDownList ID="ddlValue" runat="server" onselectedindexchanged="ddlValue_SelectedIndexChanged" 
    ontextchanged="ddlValue_TextChanged"></asp:DropDownList>

<p>
    &nbsp;</p><input id="txtTest" type="text" />
<select id="slTest" name="D1" onchange="return slTest_onchange()">
    <option>1</option>
    <option>2</option>
    <option>3</option>
</select>

