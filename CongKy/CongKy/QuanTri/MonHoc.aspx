<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonHoc.aspx.cs" Inherits="CongKy.QuanTri.MonHoc" MasterPageFile="~/ShareInterface/ReportSI.Master" %>
<%@ Register src="../UserControl/tblMonHoc_ListUC.ascx" tagname="tblMonHoc_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/tblMonHoc_DetailUC.ascx" tagname="tblMonHoc_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblMonHoc_ListUC ID="tblMonHoc_ListUC1" runat="server" OnAddNew="AddNew_Click" OnViewDetail="ViewDetail_Click" />
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br />
            <uc2:tblMonHoc_DetailUC ID="tblMonHoc_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
