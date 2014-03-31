<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinCaNhan.aspx.cs" Inherits="DO_AN_TN.GiangVien.ThongTinCaNhan" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" %>

<%@ Register src="../UserControl/GiangVien_DetailUC.ascx" tagname="GiangVien_DetailUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
    
        <uc1:GiangVien_DetailUC ID="GiangVien_DetailUC1" runat="server" />
    
    </div>
</asp:Content>
