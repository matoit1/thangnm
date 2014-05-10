<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiangDay.aspx.cs" Inherits="DO_AN_TN.GiangVien.GiangDay" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" %>
<%@ Register src="../UserControl/ASM_ServerUC.ascx" tagname="ASM_ServerUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/ChatUC.ascx" tagname="ChatUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/Thong_Tin_Lop_HocUC.ascx" tagname="Thong_Tin_Lop_HocUC" tagprefix="uc3" %>
<%@ Register src="../UserControl/Hoc_LieuUC.ascx" tagname="Hoc_LieuUC" tagprefix="uc4" %>
<%@ Register src="../UserControl/VideoUC.ascx" tagname="VideoUC" tagprefix="uc5" %>
<%@ Register src="../UserControl/UploadFileUC.ascx" tagname="UploadFileUC" tagprefix="uc6" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:ScriptManager ID="scrAjax" runat="server"></asp:ScriptManager>
    <center><h1><asp:Label ID="lblTitle" runat="server"></asp:Label></h1><br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br /></center>
    <div class="livestream">
        <asp:MultiView ID="vLiveStream" runat="server" ActiveViewIndex="2">
            <asp:View ID="vOnline" runat="server">
                <uc1:ASM_ServerUC ID="ASM_ServerUC1" runat="server" />
            </asp:View>
            <asp:View ID="vOffline" runat="server">
                <uc5:VideoUC ID="VideoUC1" runat="server" />
            </asp:View>
            <asp:View ID="vDefault" runat="server">
                <center><h1><asp:Label ID="lblNotify" runat="server"></asp:Label></h1></center>
            </asp:View>
        </asp:MultiView>
    </div>
    <div class="chatroom">
        <%--<uc2:ChatUC ID="ChatUC1" runat="server" />--%>
    </div>
    <div class="clear"></div>
    <div class="infor">
        <uc3:Thong_Tin_Lop_HocUC ID="Thong_Tin_Lop_HocUC1" runat="server" />
    </div>
    <div class="ebook">
        <uc4:Hoc_LieuUC ID="Hoc_LieuUC1" runat="server" /><br />
        <uc6:UploadFileUC ID="UploadFileUC1" runat="server" OnRefresh="Refresh1_Click" />
        <uc6:UploadFileUC ID="UploadFileUC2" runat="server" OnRefresh="Refresh2_Click" />
    </div>
    <uc2:ChatUC ID="ChatUC1" runat="server" />
</asp:Content>