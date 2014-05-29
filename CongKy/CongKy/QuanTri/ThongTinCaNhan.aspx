<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinCaNhan.aspx.cs" Inherits="CongKy.QuanTri.ThongTinCaNhan" MasterPageFile="~/ShareInterface/QuanTriSI.Master" %>
<%@ Register src="../UserControl/tblTaiKhoan_DetailUC.ascx" tagname="tblTaiKhoan_DetailUC" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
<uc1:tblTaiKhoan_DetailUC ID="tblTaiKhoan_DetailUC1" runat="server" />
</asp:Content>
