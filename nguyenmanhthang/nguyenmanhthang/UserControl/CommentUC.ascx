<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommentUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.CommentUC" %>

<asp:Label ID="lblMessage" runat="server"></asp:Label>
<table>
    <tr>
        <td>Họ và tên: </td>
        <td><asp:TextBox ID="txtComment_Name" runat="server"></asp:TextBox></td>
        <td style="color:Red; ">*</td>
        <td><asp:RequiredFieldValidator ID="rfvComment_Name" runat="server" ErrorMessage="Bạn chưa nhập Họ và Tên" ControlToValidate="txtComment_Name"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>Email: </td>
        <td><asp:TextBox ID="txtComment_Email" runat="server"></asp:TextBox></td>
        <td style="color:Red; ">*</td>
        <td><asp:RequiredFieldValidator ID="rfvComment_Email" runat="server" ErrorMessage="Bạn chưa nhập Email" ControlToValidate="txtComment_Email"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>Website: </td>
        <td><asp:TextBox ID="txtComment_Website" runat="server"></asp:TextBox></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>Nội dung: </td>
        <td><asp:TextBox ID="txtComment_Content" runat="server" TextMode="MultiLine" Height="100px" Width="300px"></asp:TextBox></td>
        <td style="color:Red;">*</td>
        <td><asp:RequiredFieldValidator ID="rfvComment_Content" runat="server" ErrorMessage="Bạn chưa nhập Nội dung" ControlToValidate="txtComment_Content"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button ID="btnComment" runat="server" Text="Bình luận" 
                onclick="btnComment_Click" /></td>
    </tr>
    <tr>
        <td></td>
        <td><span style="color:Red;">*</span> Các trường bắt buộc</td>
    </tr>
</table>