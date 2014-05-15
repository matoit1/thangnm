<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinhVien.aspx.cs" Inherits="EHOU.QuanTri.SinhVien" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false"%>

<%@ Register src="../UserControl/SinhVien_ListUC.ascx" tagname="SinhVien_ListUC" tagprefix="uc1" %>

<%@ Register src="../UserControl/SinhVien_DetailUC.ascx" tagname="SinhVien_DetailUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc1:SinhVien_ListUC ID="SinhVien_ListUC1" runat="server" OnViewDetail="ViewDetail_Click" OnAddNew="AddNew_Click"/>
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
                <uc2:SinhVien_DetailUC ID="SinhVien_DetailUC1" runat="server" />
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>