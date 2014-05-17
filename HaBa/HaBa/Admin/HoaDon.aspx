<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="HaBa.Admin.HoaDon" MasterPageFile="~/ShareInterface/AdminSI.Master" EnableEventValidation="false" %>

<%@ Register src="~/UserControl/tblHoaDon_ListUC.ascx" tagname="tblHoaDon_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblHoaDon_DetailUC.ascx" tagname="tblHoaDon_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblHoaDon_ListUC ID="tblHoaDon_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblHoaDon_DetailUC ID="tblHoaDon_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
