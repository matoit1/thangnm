<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TGiangVien.aspx.cs" Inherits="DO_AN_TN.Test.TGiangVien" MasterPageFile="~/Share_Interface/Test.Master"  EnableEventValidation="false" %>

<%@ Register src="../UserControl/GiangVien_DetailUC.ascx" tagname="GiangVien_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/GiangVien_ListUC.ascx" tagname="GiangVien_ListUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc2:GiangVien_ListUC ID="GiangVien_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc1:GiangVien_DetailUC ID="GiangVien_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
