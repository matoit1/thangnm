<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoToolbar.aspx.cs" Inherits="DO_AN_TN.Test.DemoToolbar" %>

<%@ Register assembly="SCS.Web.UI.WebControls.Toolbar" namespace="SCS.Web.UI.WebControls" tagprefix="SCS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../App_Themes/Toolbar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <SCS:Toolbar ID="Toolbar1" runat="server" EnableClientApi="True" 
            CssClass="toolbar" 
            OnButtonClicked="Toolbar1_ButtonClicked"  
            Width="100%" 
            SelectionMode="Single" 
            OnClientButtonClick="toolbar_buttonClicked" >             
            
            <ButtonCssClasses 
                CssClass="button" 
                CssClassEnabled="button_enabled" 
                CssClassDisabled="button_disabled" 
                CssClassSelected="button_selected"/> 
                
            <Items>
                <SCS:ToolbarButton 
                    ImageUrl="~/Images/Icon/ctxwiz_cls.gif" 
                    DisabledImageUrl="~/Images/Icon/ctxwiz_cls_off.gif" 
                    Text="New" 
                    ConfirmationMessage="Are you sure you want to delete?" 
                    ToolTip="Test the record" 
                    CommandName="CreateNew" 
                    CommandArgument="999"/>

                <SCS:ToolbarButton 
                    ImageUrl="~/Images/Icon/ctxwiz_cls.gif" 
                    DisabledImageUrl="~/Images/Icon/ctxwiz_cls_off.gif" 
                    Text="New" 
                    ConfirmationMessage="Are you sure you want to delete?" 
                    ToolTip="Create a new record" 
                    CommandName="CreateNew" 
                    CommandArgument="9991" />   
                <SCS:ToolbarButton 
                    ImageUrl="~/Images/Icon/Delete.gif" 
                    DisabledImageUrl="~/Images/Icon/Delete_off2.gif" 
                    Text="Delete" 
                    ConfirmationMessage="Are you sure you want to delete?" 
                    ToolTip="Delete the record" 
                    CommandName="Delete" 
                    CommandArgument="99"/>
                <SCS:ToolbarButton 
                    ImageUrl="~/Images/Icon/Save.gif" 
                    DisabledImageUrl="~/Images/Icon/Save_off.gif"
                    Text="Save"
                    ToolTip="Save the record" 
                    CommandName="Save" 
                    CommandArgument="88"/>
                <SCS:ToolbarButton 
                    ImageUrl="~/Images/Icon/ctxhelp_hide.gif" 
                    DisabledImageUrl="~/Images/Icon/ctxhelp_hide_off.gif" 
                    Text="Help"
                    ToolTip="Help for this form" 
                    CommandName="GotoHelp" 
                    CommandArgument="77" />                      
            </Items>    
        </SCS:Toolbar><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

