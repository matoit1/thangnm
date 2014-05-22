<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhomSanPham.aspx.cs" Inherits="HaBa.NhomSanPham" MasterPageFile="~/ShareInterface/ProductSI.Master" %>
<%@ Register src="~/UserControl/Gallery3DUC.ascx" tagname="Gallery3DUC" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div id="body-wrapper"><br /><br /><br /><br />
        <uc1:Gallery3DUC ID="Gallery3DUC1" runat="server" />
    <br /><br /><br /><br /></div>
</asp:Content>