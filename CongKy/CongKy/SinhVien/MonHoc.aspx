<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonHoc.aspx.cs" Inherits="CongKy.SinhVien.MonHoc" MasterPageFile="~/ShareInterface/SinhVienSI.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="../UserControl/tblMonHoc_ListUC.ascx" tagname="tblMonHoc_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/tblMonHoc_DetailUC.ascx" tagname="tblMonHoc_DetailUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/tblChiTietGiaoTrinh_ListUC.ascx" tagname="tblChiTietGiaoTrinh_ListUC" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblMonHoc_ListUC ID="tblMonHoc_ListUC1" runat="server" OnAddNew="AddNew_Click" OnViewDetail="ViewDetail_Click" />
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <cc1:TabContainer ID="tabMain" runat="server" ActiveTabIndex="0">
            <cc1:TabPanel runat="server" HeaderText="Thông tin môn học" ID="tabInfo">
            <ContentTemplate>
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br />
                <uc2:tblMonHoc_DetailUC ID="tblMonHoc_DetailUC1" runat="server" />
            </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel runat="server" HeaderText="Giáo trình mới nhất tuần này" ID="tabNew">
            <ContentTemplate>
                <uc3:tblChiTietGiaoTrinh_ListUC ID="tblChiTietGiaoTrinh_ListUC1" runat="server" />
            </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel runat="server" HeaderText="Tất cả giáo trình" ID="tabAll">
            <ContentTemplate>
                <uc3:tblChiTietGiaoTrinh_ListUC ID="tblChiTietGiaoTrinh_ListUC2" runat="server" />
            </ContentTemplate>
            </cc1:TabPanel>
        </cc1:TabContainer>
        </asp:View>
    </asp:MultiView>
</asp:Content>