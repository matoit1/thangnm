<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="HaBa.Admin.HoaDon" MasterPageFile="~/ShareInterface/AdminSI.Master" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="~/UserControl/tblHoaDon_ListUC.ascx" tagname="tblHoaDon_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblHoaDon_DetailUC.ascx" tagname="tblHoaDon_DetailUC" tagprefix="uc2" %>
<%@ Register src="~/UserControl/tblChiTietHoaDon_ListUC.ascx" tagname="tblChiTietHoaDon_ListUC" tagprefix="uc3" %>
<%@ Register src="~/UserControl/tblChiTietHoaDon_DetailUC.ascx" tagname="tblChiTietHoaDon_DetailUC" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblHoaDon_ListUC ID="tblHoaDon_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0" ><cc1:TabPanel runat="server" HeaderText="Thông tin hóa đơn" ID="tabHoaDon"><ContentTemplate><uc2:tblHoaDon_DetailUC ID="tblHoaDon_DetailUC1" runat="server" /></ContentTemplate></cc1:TabPanel><cc1:TabPanel runat="server" HeaderText="Chi tiết Hóa đơn" ID="tabChiTietHoaDon"><ContentTemplate><asp:MultiView ID="mtvChiTietHoaDon" runat="server" ActiveViewIndex="0"><asp:View ID="vListChiTietHoaDon" runat="server"><uc3:tblChiTietHoaDon_ListUC ID="tblChiTietHoaDon_ListUC1" runat="server" OnSelectRow="SelectRowChiTietHoaDon_Click" OnViewDetail="ViewDetailChiTietHoaDon_Click" OnAddNew="AddNewChiTietHoaDon_Click" /></asp:View><asp:View ID="vDetailChiTietHoaDon" runat="server"><asp:LinkButton ID="lbtnBackChiTietHoaDon" runat="server" onclick="lbtnBackChiTietHoaDon_Click">Quay lại danh sách</asp:LinkButton><uc4:tblChiTietHoaDon_DetailUC ID="tblChiTietHoaDon_DetailUC1" runat="server" /></asp:View></asp:MultiView></ContentTemplate></cc1:TabPanel></cc1:TabContainer>
        </asp:View>
    </asp:MultiView>
</asp:Content>
