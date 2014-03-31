<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiemThi.aspx.cs" Inherits="DO_AN_TN.SinhVien.DiemThi" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>

<%@ Register src="../UserControl/DiemThi_ListUC.ascx" tagname="DiemThi_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/DiemThi_DetailUC.ascx" tagname="DiemThi_DetailUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc1:DiemThi_ListUC ID="DiemThi_ListUC1" runat="server" OnViewDetail="ViewDetail_Click"/>
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
                <uc2:DiemThi_DetailUC ID="DiemThi_DetailUC1" runat="server" />
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>