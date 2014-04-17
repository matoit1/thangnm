<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UploadFileUC.ascx.cs" Inherits="DO_AN_TN.UserControl.UploadFileUC" %>
<fieldset style="width: 270px; height:60px">
    <legend>Upload học liệu</legend>
    <input type="file" id="myfile" multiple="multiple" name="myfile" runat="server" size="100" style="width: 150px" />
    <asp:Button ID="UploadFile" runat="server" Text="Upload File" OnClick="UploadFile_Click" /><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
</fieldset>