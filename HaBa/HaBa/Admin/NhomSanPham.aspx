<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhomSanPham.aspx.cs" Inherits="HaBa.Admin.NhomSanPham" MasterPageFile="~/ShareInterface/AdminSI.Master" %>

<%@ Register src="~/UserControl/tblNhomSanPham_ListUC.ascx" tagname="tblNhomSanPham_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblNhomSanPham_DetailUC.ascx"" tagname="tblNhomSanPham_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblNhomSanPham_ListUC ID="tblNhomSanPham_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblNhomSanPham_DetailUC ID="tblNhomSanPham_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
