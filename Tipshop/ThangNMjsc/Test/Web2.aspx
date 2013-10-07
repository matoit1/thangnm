<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web2.aspx.cs" Inherits="ThangNMjsc.url.Web2" MasterPageFile="~/Master.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<p>Trang Con</p>
    <div>
    
        <asp:Label ID="lburl" runat="server"></asp:Label>
&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="IsPostBack" />
    
    </div>
    <p>&nbsp;</p>

</div>
</asp:Content>
