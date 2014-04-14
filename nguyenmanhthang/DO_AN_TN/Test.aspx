<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DO_AN_TN.Test1" MasterPageFile="~/Share_Interface/Test.Master" %>
<%@ Register Namespace="CuteWebUI" Assembly="CuteWebUI.AjaxUploader" TagPrefix="CuteWebUI" %>
<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
<CuteWebUI:UploadAttachments InsertText="Upload Multiple files Now" runat="server"
                ID="Attachments1" MultipleFilesUpload="true">
                <InsertButtonStyle />
            </CuteWebUI:UploadAttachments>
            <p>
                <asp:Button ID="ButtonDeleteAll" runat="server" Text="Delete All"  />&nbsp;&nbsp;
                <asp:Button ID="ButtonTellme" runat="server" Text="Show Uploaded File Information"
                     />
            </p>
            <p>
                Server Trace:
                <br />
                <asp:ListBox runat="server" ID="ListBoxEvents" />
            </p>
</asp:Content>