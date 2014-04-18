<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HocTap.aspx.cs" Inherits="DO_AN_TN.SinhVien.HocTap" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../UserControl/ASM_ClientUC.ascx" tagname="ASM_ClientUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/Thong_Tin_Lop_HocUC.ascx" tagname="Thong_Tin_Lop_HocUC" tagprefix="uc3" %>
<%@ Register src="../UserControl/Hoc_LieuUC.ascx" tagname="Hoc_LieuUC" tagprefix="uc4" %>
<%@ Register src="../UserControl/DongHoUC.ascx" tagname="DongHoUC" tagprefix="uc6" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:ScriptManager ID="scrAjax" runat="server"></asp:ScriptManager>
    <h1><asp:Label ID="lblTitle" runat="server"></asp:Label></h1><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
    <div class="livestream">
        <uc1:ASM_ClientUC ID="ASM_ClientUC1" runat="server" />
    </div>
    <div class="chatroom">
        <uc6:DongHoUC ID="DongHoUC1" runat="server" /><br />
        <uc2:chatuc ID="ChatUC1" runat="server" />
    </div>
    <div class="clear"></div>
    <div class="infor">
        <uc3:thong_tin_lop_hocuc ID="Thong_Tin_Lop_HocUC1" runat="server" />
    </div>
    <div class="ebook">
        <asp:UpdatePanel ID="udpSync" runat="server">
            <ContentTemplate>
                <asp:Timer ID="tSync" runat="server" Interval="5000" ontick="tSync_Tick"></asp:Timer>
                <uc4:hoc_lieuuc ID="Hoc_LieuUC1" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
