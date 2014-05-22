<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinCaNhan.aspx.cs" Inherits="HaBa.Admin.ThongTinCaNhan" MasterPageFile="~/ShareInterface/AdminSI.Master" %>

<%@ Register src="../UserControl/tblTaiKhoan_DetailUC.ascx" tagname="tblTaiKhoan_DetailUC" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div style="width: 800px; height: 600px;">
        <uc1:tblTaiKhoan_DetailUC ID="tblTaiKhoan_DetailUC1" runat="server" />
    </div>
</asp:Content>
