<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UploadFileUC.ascx.cs" Inherits="EHOU.UserControl.UploadFileUC" %>
<fieldset style="width: 270px; height:60px">
    <legend><asp:Label ID="lblTitle" runat="server"></asp:Label></legend>
    <input type="file" id="myfile" multiple="multiple" name="myfile" runat="server" size="100" style="width: 150px" />
    <asp:Button ID="UploadFile" runat="server" Text="Upload File" OnClick="UploadFile_Click" /><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
</fieldset>