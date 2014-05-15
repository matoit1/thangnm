<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThiTracNghiem.aspx.cs" Inherits="EHOU.SinhVien.ThiTracNghiem" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../UserControl/TracNghiemUC.ascx" tagname="TracNghiemUC" tagprefix="uc1" %>
<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>

        <uc1:TracNghiemUC ID="TracNghiemUC1" runat="server" />

    </div>
</asp:Content>