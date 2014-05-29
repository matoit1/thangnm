<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoan.aspx.cs" Inherits="CongKy.QuanTri.TaiKhoan" MasterPageFile="~/ShareInterface/QuanTriSI.Master" %>

<%@ Register src="~/UserControl/tblTaiKhoan_ListUC.ascx" tagname="tblTaiKhoan_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblTaiKhoan_DetailUC.ascx" tagname="tblTaiKhoan_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblTaiKhoan_ListUC ID="tblTaiKhoan_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblTaiKhoan_DetailUC ID="tblTaiKhoan_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
