<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LichHoc.aspx.cs" Inherits="DO_AN_TN.SinhVien.LichHoc" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>

<%@ Register src="../UserControl/LichDayVaHoc_ListUC.ascx" tagname="LichDayVaHoc_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/LichDayVaHoc_DetailUC.ascx" tagname="LichDayVaHoc_DetailUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc1:LichDayVaHoc_ListUC ID="LichDayVaHoc_ListUC1" runat="server" OnViewDetail="ViewDetail_Click" />
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
                <uc2:LichDayVaHoc_DetailUC ID="LichDayVaHoc_DetailUC1" runat="server" />
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>