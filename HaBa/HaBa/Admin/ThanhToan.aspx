<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="HaBa.Admin.ThanhToan" MasterPageFile="~/ShareInterface/AdminSI.Master" %>

<%@ Register src="~/UserControl/tblThanhToan_ListUC.ascx" tagname="tblThanhToan_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblThanhToan_DetailUC.ascx" tagname="tblThanhToan_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblThanhToan_ListUC ID="tblThanhToan_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblThanhToan_DetailUC ID="tblThanhToan_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
