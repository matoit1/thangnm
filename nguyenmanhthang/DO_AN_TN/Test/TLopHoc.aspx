<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TLopHoc.aspx.cs" Inherits="DO_AN_TN.Test.TLopHoc" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/LopHoc_DetailUC.ascx" tagname="LopHoc_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/LopHoc_ListUC.ascx" tagname="LopHoc_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc2:LopHoc_ListUC ID="LopHoc_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc1:LopHoc_DetailUC ID="LopHoc_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
