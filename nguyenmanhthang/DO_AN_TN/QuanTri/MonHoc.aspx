<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonHoc.aspx.cs" Inherits="DO_AN_TN.QuanTri.MonHoc" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false"%>

<%@ Register src="../UserControl/MonHoc_ListUC.ascx" tagname="MonHoc_ListUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc1:MonHoc_ListUC ID="MonHoc_ListUC1" runat="server" OnViewDetail="ViewDetail_Click"/>
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>