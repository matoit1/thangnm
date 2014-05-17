<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="HaBa.Admin.SanPham" MasterPageFile="~/ShareInterface/AdminSI.Master" EnableEventValidation="false"%>

<%@ Register src="~/UserControl/tblSanPham_ListUC.ascx" tagname="tblSanPham_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblSanPham_DetailUC.ascx" tagname="tblSanPham_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblSanPham_ListUC ID="tblSanPham_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblSanPham_DetailUC ID="tblSanPham_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
