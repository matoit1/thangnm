<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietGiaoTrinh.aspx.cs" Inherits="CongKy.QuanTri.ChiTietGiaoTrinh" MasterPageFile="~/ShareInterface/QuanTriSI.Master" %>

<%@ Register src="../UserControl/tblChiTietGiaoTrinh_ListUC.ascx" tagname="tblChiTietGiaoTrinh_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/tblChiTietGiaoTrinh_DetailUC.ascx" tagname="tblChiTietGiaoTrinh_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblChiTietGiaoTrinh_ListUC ID="tblChiTietGiaoTrinh_ListUC1" runat="server" OnAddNew="AddNew_Click" OnViewDetail="ViewDetail_Click" />
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br />
            <uc2:tblChiTietGiaoTrinh_DetailUC ID="tblChiTietGiaoTrinh_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
