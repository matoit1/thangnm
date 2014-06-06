<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UploadMultiFileUC.ascx.cs" Inherits="EHOU.UserControl.UploadMultiFileUC" %>
<fieldset style="width: 270px; height:60px">
    <legend><asp:Label ID="lblTitle" runat="server"></asp:Label></legend>
    Nhập mô tả: <asp:TextBox ID="txtsDescription" runat="server"></asp:TextBox><br />
    <input type="file" id="myfile" multiple="multiple" name="myfile" runat="server" size="100" style="width: 150px" />
    <asp:Button ID="UploadFile" runat="server" Text="Upload File" OnClick="UploadFile_Click" /><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
</fieldset>