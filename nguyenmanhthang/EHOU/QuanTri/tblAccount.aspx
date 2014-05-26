<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblAccount.aspx.cs" Inherits="EHOU.QuanTri.tblAccount" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="~/UserControl/tblAccount_ListUC.ascx" tagname="tblAccount_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblAccount_DetailUC.ascx" tagname="tblAccount_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblAccount_ListUC ID="tblAccount_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblAccount_DetailUC ID="tblAccount_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
