<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="HaBa.Client.HoaDon" MasterPageFile="~/ShareInterface/ClientSI.Master" %>

<%@ Register src="../UserControl/tblHoaDon_ListUC.ascx" tagname="tblHoaDon_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/tblHoaDon_PrintUC.ascx" tagname="tblHoaDon_PrintUC" tagprefix="uc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblHoaDon_ListUC ID="tblHoaDon_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <uc2:tblHoaDon_PrintUC ID="tblHoaDon_PrintUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
