<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblMaterial.aspx.cs" Inherits="EHOU.QuanTri.tblMaterial" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false"  %>

<%@ Register src="~/UserControl/tblMaterial_ListUC.ascx" tagname="tblMaterial_ListUC" tagprefix="uc1" %>
<%@ Register src="~/UserControl/tblMaterial_DetailUC.ascx" tagname="tblMaterial_DetailUC" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
        <asp:View ID="vList" runat="server">
            <uc1:tblMaterial_ListUC ID="tblMaterial_ListUC1" runat="server" OnSelectRow="SelectRow_Click" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
        </asp:View>
        <asp:View ID="vDetail" runat="server">
            <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton>
            <uc2:tblMaterial_DetailUC ID="tblMaterial_DetailUC1" runat="server" />
        </asp:View>
    </asp:MultiView>
</asp:Content>

