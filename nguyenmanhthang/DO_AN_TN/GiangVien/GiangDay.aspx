<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiangDay.aspx.cs" Inherits="DO_AN_TN.GiangVien.GiangDay" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" %>
<%@ Register src="../UserControl/ASM_ServerUC.ascx" tagname="ASM_ServerUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/Thong_Tin_Lop_HocUC.ascx" tagname="Thong_Tin_Lop_HocUC" tagprefix="uc3" %>
<%@ Register src="../UserControl/Hoc_LieuUC.ascx" tagname="Hoc_LieuUC" tagprefix="uc4" %>
<%@ Register src="../UserControl/UploadFileUC.ascx" tagname="UploadFileUC" tagprefix="uc5" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <center><h1><asp:Label ID="lblTitle" runat="server"></asp:Label></h1></center><br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
    <asp:Panel ID="pnlLimit1" runat="server">
        <div class="livestream">
            <uc1:ASM_ServerUC ID="ASM_ServerUC1" runat="server" />
        </div>
    </asp:Panel>
        <div class="chatroom">
            <asp:ScriptManager ID="smTime" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="upTime" runat="server">
                <ContentTemplate>
                    <div class="time">
                    <asp:Timer ID="tClock" runat="server" ontick="tClock_Tick" Interval="1000"></asp:Timer>
                    <asp:Button ID="btnClock" runat="server" />
                    <asp:Label ID="lblCaHoc" runat="server"></asp:Label>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Panel ID="pnlLimit2" runat="server">
            <uc2:chatuc ID="ChatUC1" runat="server" />
            </asp:Panel>
        </div>
    <asp:Panel ID="pnlLimit3" runat="server">
        <div class="clear"></div>
        <div class="infor">
            <uc3:thong_tin_lop_hocuc ID="Thong_Tin_Lop_HocUC1" runat="server" />
        </div>
        <div class="ebook">
            <uc4:hoc_lieuuc ID="Hoc_LieuUC1" runat="server" /><br />
            <uc5:UploadFileUC ID="UploadFileUC1" runat="server" OnRefresh="Refresh_Click" />
        </div>
    </asp:Panel>
</asp:Content>