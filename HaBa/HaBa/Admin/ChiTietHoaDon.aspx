<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietHoaDon.aspx.cs" Inherits="HaBa.Admin.ChiTietHoaDon" MasterPageFile="~/ShareInterface/AdminSI.Master" %>
<%@ Register src="~/UserControl/tblChiTietHoaDon_ListUC.ascx" tagname="tblChiTietHoaDon_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblChiTietHoaDon_DetailUC.ascx"" tagname="tblChiTietHoaDon_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblChiTietHoaDon_ListUC ID="tblChiTietHoaDon_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblChiTietHoaDon_DetailUC ID="tblChiTietHoaDon_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
