<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblPart.aspx.cs" Inherits="EHOU.QuanTri.tblPart" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="~/UserControl/tblPart_ListUC.ascx" tagname="tblPart_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblPart_DetailUC.ascx" tagname="tblPart_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblPart_ListUC ID="tblPart_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblPart_DetailUC ID="tblPart_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>
