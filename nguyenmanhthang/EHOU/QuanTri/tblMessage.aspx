<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblMessage.aspx.cs" Inherits="EHOU.QuanTri.tblMessage" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="~/UserControl/tblMessage_ListUC.ascx" tagname="tblMessage_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblMessage_DetailUC.ascx" tagname="tblMessage_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblMessage_ListUC ID="tblMessage_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblMessage_DetailUC ID="tblMessage_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
