<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TSinhVien.aspx.cs" Inherits="DO_AN_TN.Test.TSinhVien" MasterPageFile="~/Share_Interface/Test.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/SinhVien_DetailUC.ascx" tagname="SinhVien_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/SinhVien_ListUC.ascx" tagname="SinhVien_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc2:SinhVien_ListUC ID="SinhVien_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc1:SinhVien_DetailUC ID="SinhVien_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
