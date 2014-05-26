<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChonLopHoc.aspx.cs" Inherits="EHOU.SinhVien.ChonLopHoc" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../Usercontrol/ChonMonHocUC.ascx" tagname="ChonMonHocUC" tagprefix="uc1" %>
<%@ Register src="../Usercontrol/ChonBaiHocUC.ascx" tagname="ChonBaiHocUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:Panel ID="pnlMonHoc" runat="server">
        <uc1:ChonMonHocUC ID="ChonMonHocUC1" runat="server" OnGoSubject="GoSubject_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlBaiHoc" runat="server">
        <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay về danh sách Môn Học</asp:LinkButton><br />
        <uc2:ChonBaiHocUC ID="ChonBaiHocUC1" runat="server" OnGoPart="GoPart_Click" />
    </asp:Panel>
</asp:Content>