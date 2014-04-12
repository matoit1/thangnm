<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiangDay.aspx.cs" Inherits="DO_AN_TN.GiangVien.GiangDay" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" %>
<%@ Register src="../UserControl/ASM_ServerUC.ascx" tagname="ASM_ServerUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/Thong_Tin_Lop_HocUC.ascx" tagname="Thong_Tin_Lop_HocUC" tagprefix="uc3" %>
<%@ Register src="../UserControl/Hoc_LieuUC.ascx" tagname="Hoc_LieuUC" tagprefix="uc4" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div class="livestream">
        <uc1:ASM_ServerUC ID="ASM_ServerUC1" runat="server" />
    </div>
    <div class="chatroom">
        <uc2:chatuc ID="ChatUC1" runat="server" />
    </div>
    <div class="clear"></div>
    <div class="infor">
        <uc3:thong_tin_lop_hocuc ID="Thong_Tin_Lop_HocUC1" runat="server" />
    </div>
    <div class="ebook">
        <uc4:hoc_lieuuc ID="Hoc_LieuUC1" runat="server" />
    </div>
</asp:Content>