<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiemThi.aspx.cs" Inherits="EHOU.SinhVien.DiemThi" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" EnableEventValidation="false" %>

<%@ Register src="../UserControl/DiemThi_ListUC.ascx" tagname="DiemThi_ListUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <uc1:DiemThi_ListUC ID="DiemThi_ListUC1" runat="server"/>
    </div>
</asp:Content>