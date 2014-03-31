<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinCaNhan.aspx.cs" Inherits="DO_AN_TN.SinhVien.ThongTinCaNhan" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>

<%@ Register src="../UserControl/SinhVien_DetailUC.ascx" tagname="SinhVien_DetailUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
    
        <uc1:SinhVien_DetailUC ID="SinhVien_DetailUC1" runat="server" />
    
    </div>
</asp:Content>
