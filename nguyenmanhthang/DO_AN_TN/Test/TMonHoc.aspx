<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TMonHoc.aspx.cs" Inherits="DO_AN_TN.Test.TMonHoc" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/MonHoc_DetailUC.ascx" tagname="MonHoc_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/MonHoc_ListUC.ascx" tagname="MonHoc_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc2:MonHoc_ListUC ID="MonHoc_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc1:MonHoc_DetailUC ID="MonHoc_DetailUC2" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
