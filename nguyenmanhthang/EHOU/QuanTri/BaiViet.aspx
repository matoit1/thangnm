<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaiViet.aspx.cs" Inherits="EHOU.QuanTri.BaiViet" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false"%>

<%@ Register src="../UserControl/BaiViet_ListUC.ascx" tagname="BaiViet_ListUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc1:BaiViet_ListUC ID="BaiViet_ListUC1" runat="server" OnViewDetail="ViewDetail_Click" />
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>
