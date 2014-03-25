<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TDiemThi.aspx.cs" Inherits="DO_AN_TN.Test.TDiemThi" MasterPageFile="~/Share_Interface/QuanTri_SI.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/DiemThi_DetailUC.ascx" tagname="DiemThi_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/DiemThi_ListUC.ascx" tagname="DiemThi_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc2:DiemThi_ListUC ID="DiemThi_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc1:DiemThi_DetailUC ID="DiemThi_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
