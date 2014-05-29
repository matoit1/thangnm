<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiaoTrinh.aspx.cs" Inherits="CongKy.QuanTri.GiaoTrinh" MasterPageFile="~/ShareInterface/QuanTriSI.Master" %>

<%@ Register src="../UserControl/tblGiaoTrinh_ListUC.ascx" tagname="tblGiaoTrinh_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/tblGiaoTrinh_DetailUC.ascx" tagname="tblGiaoTrinh_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblGiaoTrinh_ListUC ID="tblGiaoTrinh_ListUC1" runat="server" OnAddNew="AddNew_Click" OnViewDetail="ViewDetail_Click" />
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br />
            <uc2:tblGiaoTrinh_DetailUC ID="tblGiaoTrinh_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
