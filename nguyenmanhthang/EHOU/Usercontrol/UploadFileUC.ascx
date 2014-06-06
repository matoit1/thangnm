<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UploadFileUC.ascx.cs" Inherits="EHOU.UserControl.UploadFileUC" %>
<fieldset style="width: 505px; height:130px">
    <legend><asp:Label ID="lblTitle" runat="server"></asp:Label></legend>
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br /><br />
    Nhập mô tả: <asp:TextBox ID="txtsDescription" runat="server" Width="300px"></asp:TextBox><br />
    <asp:FileUpload ID="fuMaterial" runat="server"  Width="300px"/><br />
    <asp:Button ID="UploadFile" runat="server" Text="Upload File" OnClick="UploadFile_Click" />
</fieldset>