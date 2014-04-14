<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UploadFileUC.ascx.cs" Inherits="DO_AN_TN.UserControl.UploadFileUC" %>
<%--        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
        <asp:FileUpload ID="fulFile" runat="server" multiple="multiple" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" onclick="btnUpload_Click" />--%>
        <input type="file" id="myfile" multiple="multiple" name="myfile" runat="server" size="100" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Span1" runat="server"></asp:Label>